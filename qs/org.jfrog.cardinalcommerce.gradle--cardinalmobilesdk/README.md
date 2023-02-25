This package will restore Cardinal Mobile SDK for Android using Gradle tools. 

Please following these steps to enable that feature:

- Prepare your credentials to access Cardinal Mobile SDK gradle repository
- Open the Android csproj file for editing
- Amend and add these lines to the mentioned csproj file

```
<GradleRepository Include="https://api.mapbox.com/downloads/v2/releases/maven">
      <Repository>
      maven {
          url 'https://cardinalcommerceprod.jfrog.io/artifactory/android'
          credentials {
              username 'PUT_YOUR_USER_NAME_HERE'
              password 'PUT_YOUR_PASSWORD_HERE'
          }
      }
      </Repository>
</GradleRepository>
```