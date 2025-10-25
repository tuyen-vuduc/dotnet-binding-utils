dotnet nuget locals -c all
dotnet pack -c Release -t:Clean,Rebuild iZettle.iOS/iZettle.iOS.csproj --output ../../../nugets