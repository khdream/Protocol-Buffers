#!/bin/bash
#
# Change to repo root
cd $(dirname $0)/../../..

set -ex

export OUTPUT_DIR=testoutput
repo_root="$(pwd)"

# tcmalloc
if [ ! -f gperftools/.libs/libtcmalloc.so ]; then
  git clone https://github.com/gperftools/gperftools.git
  pushd gperftools
  ./autogen.sh
  ./configure
  make -j8
  popd
fi

# download datasets for benchmark
pushd benchmarks
datasets=$(for file in $(find . -type f -name "dataset.*.pb" -not -path "./tmp/*"); do echo "$(pwd)/$file"; done | xargs)
echo $datasets
popd

# build Python protobuf
./autogen.sh
./configure CXXFLAGS="-fPIC -O2"
make -j8
pushd python
python setup.py build --cpp_implementation
pip install . --user
popd

# build and run Python benchmark
# We do this before building protobuf C++ since C++ build
# will rewrite some libraries used by protobuf python.
pushd benchmarks
make python-pure-python-benchmark
make python-cpp-reflection-benchmark
make -j8 python-cpp-generated-code-benchmark
echo "[" > tmp/python_result.json
echo "benchmarking pure python..."
./python-pure-python-benchmark --json --behavior_prefix="pure-python-benchmark" $datasets  >> tmp/python_result.json
echo "," >> "tmp/python_result.json"
echo "benchmarking python cpp reflection..."
env LD_PRELOAD="${repo_root}/gperftools/.libs/libtcmalloc.so" LD_LIBRARY_PATH="${repo_root}/src/.libs" ./python-cpp-reflection-benchmark --json --behavior_prefix="cpp-reflection-benchmark" $datasets  >> tmp/python_result.json
echo "," >> "tmp/python_result.json"
echo "benchmarking python cpp generated code..."
env LD_PRELOAD="${repo_root}/gperftools/.libs/libtcmalloc.so" LD_LIBRARY_PATH="${repo_root}/src/.libs" ./python-cpp-generated-code-benchmark --json --behavior_prefix="cpp-generated-code-benchmark" $datasets >> tmp/python_result.json
echo "]" >> "tmp/python_result.json"
popd

# build CPP protobuf
./configure
make clean && make -j8

# build Java protobuf
pushd java
mvn package
popd

pushd benchmarks

# build and run C++ benchmark
# TODO: avoid the magic with moving python_result.json
mv tmp/python_result.json . && make clean && make -j8 cpp-benchmark && mv python_result.json tmp
echo "benchmarking cpp..."
env LD_PRELOAD="${repo_root}/gperftools/.libs/libtcmalloc.so" ./cpp-benchmark --benchmark_min_time=5.0 --benchmark_out_format=json --benchmark_out="tmp/cpp_result.json" $datasets

# TODO(jtattermusch): add benchmarks for https://github.com/protocolbuffers/protobuf-go.
# The original benchmarks for https://github.com/golang/protobuf were removed
# because:
# * they were broken and haven't been producing results for a long time
# * the https://github.com/golang/protobuf implementation has been superseded by
#   https://github.com/protocolbuffers/protobuf-go

# build and run java benchmark
make java-benchmark
echo "benchmarking java..."
./java-benchmark -Cresults.file.options.file="tmp/java_result.json" $datasets

# build and run js benchmark
make js-benchmark
echo "benchmarking js..."
./js-benchmark $datasets  --json_output=$(pwd)/tmp/node_result.json

# php only supports a subset of benchmark datasets
make -j8 generate_proto3_data
proto3_datasets=$(for file in $datasets; do echo $(pwd)/tmp/proto3_data/${file#$(pwd)}; done | xargs)
echo $proto3_datasets

# build and run php benchmark
make -j8 php-c-benchmark
echo "benchmarking php_c..."
./php-c-benchmark $proto3_datasets --json --behavior_prefix="php_c" > tmp/php_c_result.json

# upload results to bq
make python_add_init
env LD_LIBRARY_PATH="${repo_root}/src/.libs" python -m util.result_uploader -php_c="../tmp/php_c_result.json"  \
	-cpp="../tmp/cpp_result.json" -java="../tmp/java_result.json" -go="../tmp/go_result.txt" -python="../tmp/python_result.json" -node="../tmp/node_result.json"
popd
