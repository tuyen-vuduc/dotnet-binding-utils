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
            url 'https://cardinalcommerceprod.jfrog.io/artifactory/android'
            credentials {
                username 'braintree_team_sdk'
                password 'AKCp8jQcoDy2hxSWhDAUQKXLDPDx6NYRkqrgFLRc3qDrayg6rrCbJpsKKyMwaykVL8FWusJpp'
            }
        }
        </Repository>
    </GradleRepository>
</ItemGroup>
```

