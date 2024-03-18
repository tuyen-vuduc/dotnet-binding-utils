# Build the library

```
sh build.sh --base-path $PWD
```

# Home page

https://github.com/DriveSmart-MobileTeam/dstracker_integration_sample

# Additional setup

## OPTION 1: Everything in CSPROJ file
1/ Change your CSPROJ file to have Gradle configuration
```
<ItemGroup>
    <GradleImplementation Include="DriveSmart:DS-Tracker:1.2.1"></GradleImplementation>
    <GradleRepository Include="https://cardinalcommerceprod.jfrog.io/artifactory/android">
      <Repository>
        maven {
          url 'https://tfsdrivesmart.pkgs.visualstudio.com/5243836b-8777-4cb6-aded-44ab518bc748/_packaging/Android_Libraries/maven/v1'
          name 'Android_Libraries'
          credentials {
              username 'YOUR_USER_NAME'
              password 'YOUR_PASSWORD'
          }
      }
      </Repository>
    </GradleRepository>
  </ItemGroup>
```

**NOTE**: Please consider using PROPS file to not commit your credentials into the VCS.

## OPTION 2: Use ~/.gradle/gradle.properties file
1/ Change your CSPROJ file to have Gradle configuration
```
<ItemGroup>
    <GradleImplementation Include="DriveSmart:DS-Tracker:1.2.1"></GradleImplementation>
    <GradleRepository Include="https://cardinalcommerceprod.jfrog.io/artifactory/android">
      <Repository>
        maven {
          url 'https://tfsdrivesmart.pkgs.visualstudio.com/5243836b-8777-4cb6-aded-44ab518bc748/_packaging/Android_Libraries/maven/v1'
          name 'Android_Libraries'
          credentials {
              username tfsdrivesmart_user
              password tfsdrivesmart_password
          }
      }
      </Repository>
    </GradleRepository>
  </ItemGroup>
```

2/ Set your username and password in gradle.properties file
```
tfsdrivesmart_user=YOUR_USERNAME
tfsdrivesmart_password=YOUR_PASSWORD
```