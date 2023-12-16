# Build package

```
sh build.sh --base-path $PWD
```

# prepare

- Amend `csproj` file to have these lines
```
<ItemGroup>
    <GradleRepository Include="https://jitpack.io">
        <Repository>
        maven {
            url 'https://jitpack.io'
        }
        </Repository>
    </GradleRepository>
</ItemGroup>
```