dotnet nuget locals -c all
dotnet pack -c Release -t:Clean,Rebuild Shake.iOS/Shake.iOS.csproj --output ../../../nugets