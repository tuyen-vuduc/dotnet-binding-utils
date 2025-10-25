rm -rf Naxam.iZettle.iOS/bin
rm -rf Naxam.iZettle.iOS/obj

# dotnet clean
# dotnet restore
dotnet pack -c Release Naxam.iZettle.iOS/Naxam.iZettle.iOS.csproj

mv Naxam.iZettle.iOS/bin/Release/Naxam.iZettle.iOS.*.nupkg nugets/