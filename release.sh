ApiKey=$1
dotnet pack ./Sellix.net/Sellix.Net.csproj -c Release
cd /Sellix.net/bin/Release
dotnet nuget push **/*.nupkg -s https://api.nuget.org/v3/index.json -k $ApiKey