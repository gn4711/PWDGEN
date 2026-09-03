dotnet publish PWDGEN.csproj ^
  -c Release ^
  -r win-x64 ^
  --self-contained false ^
  -p:PublishSingleFile=true ^
  -p:IncludeNativeLibrariesForSelfExtract=true ^
  -p:AllowedReferenceRelatedFileExtensions=none ^
  -p:DebugType=none ^
  -p:DebugSymbols=false ^
  -o "publish"

pause
