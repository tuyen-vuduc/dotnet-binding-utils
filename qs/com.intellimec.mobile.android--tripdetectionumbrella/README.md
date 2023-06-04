# Build package

```
sh build.sh --base-path $PWD
```

# Prepare

- Amend `csproj` file to have these lines
```
<ItemGroup>
    <GradleRepository Include="https://maven.pkg.github.com/ims-developers/android-sdk">
        <Repository>
    maven {
        url 'https://maven.pkg.github.com/ims-developers/android-sdk'
        credentials {
            username 'YOUR_GITHUB_USER_NAME'
            password 'YOUR_GITHUB_PAT'
        }
    }
        </Repository>
    </GradleRepository>
</ItemGroup>
```

