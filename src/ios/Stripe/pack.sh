dotnet nuget locals -c all
dotnet pack -c Release -t:Clean,Rebuild stripe-ios.sln --output ../../../nugets