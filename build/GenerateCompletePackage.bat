@ECHO OFF
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild build.csproj /m /t:PrepareOutputDirectory
IF ERRORLEVEL 1 GOTO END

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild build.csproj /m /t:Build;PreparePackageComponent /p:BuildConfiguration=Debug /p:Platform="Any CPU"
IF ERRORLEVEL 1 GOTO END

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild build.csproj /m /t:Build;PreparePackageComponent /p:BuildConfiguration=Debug_Silverlight2 /p:Platform="Any CPU"
IF ERRORLEVEL 1 GOTO END

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild build.csproj /m /t:Build;PreparePackageComponent /p:BuildConfiguration=Release /p:Platform="Any CPU"
IF ERRORLEVEL 1 GOTO END

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild build.csproj /m /t:Build;PreparePackageComponent /p:BuildConfiguration=Release_Silverlight2 /p:Platform="Any CPU"
IF ERRORLEVEL 1 GOTO END

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild build.csproj /m /t:GeneratePackage /p:PackageName=AllBinariesAndSource.zip /p:Platform="Any CPU"

:END
PAUSE