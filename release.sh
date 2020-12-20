ApiKey=$1
dotnet pack ./Sellix.net/Sellix.Net.csproj -c Release -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd ./Sellix.net/bin/Release
dotnet nuget push "*.nupkg" -k $ApiKey -s https://api.nuget.org/v3/index.json --skip-duplicate
