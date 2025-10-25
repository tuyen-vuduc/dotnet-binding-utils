dotnet nuget locals -c all
dotnet pack -c Release -t:Clean,Rebuild iZettleSDK.iOS/iZettleSDK.iOS.csproj --output ../../../nugets