dotnet nuget locals -c all
dotnet pack -c Release -o ../../../../nugets binding/Com.Tsl.Rfid.AsciiProtocol.csproj

# dotnet build -c Release dependencies.gradle.qs.sln