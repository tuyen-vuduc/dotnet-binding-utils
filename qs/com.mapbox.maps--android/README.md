# Build package

```
sh build.sh --base-path $PWD
```

# Prepration

- Add these lines to your Android app `csproj` file

```
  <ItemGroup>
    <GradleRepository Include="https://api.mapbox.com/downloads/v2/releases/maven">
      <Repository>
      maven {
        url 'https://api.mapbox.com/downloads/v2/releases/maven'
        authentication {
          basic(BasicAuthentication)
        }
        credentials {
          // Do not change the username below.
          // This should always be `mapbox` (not your username).
          username = "mapbox"
          // Use the secret token you stored in gradle.properties as the password
          password = MAPBOX_DOWNLOADS_TOKEN
        }
      }
      </Repository>
    </GradleRepository>
  </ItemGroup>
```
