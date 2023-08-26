# Build package

```
sh build.sh --base-path $PWD
```

# Prepare

- Amend `csproj` file to have these lines
```
<ItemGroup>
    <GradleRepository Include="https://cardinalcommerceprod.jfrog.io/artifactory/android">
        <Repository>
        maven {
            url = uri("https://maven.pkg.github.com/iZettle/sdk-android")
            credentials(HttpHeaderCredentials) {
              name "Authorization"
               value "Bearer " + GITHUB_PACKAGES_READ_TOKEN
            }
            authentication {
              header(HttpHeaderAuthentication)
            }
        }
        </Repository>
    </GradleRepository>
</ItemGroup>
```
- Add `GITHUB_PACKAGES_READ_TOKEN` to your `~/.gradle/gradle.properties`