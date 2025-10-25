<img src="./art/repo_header.png" alt="iZettle for Xamarin.iOS" width="728" />

# iZettle for Xamarin.iOS

A Xamarin.iOS binding library for [iZettle](https://www.izettle.com/gb/developer) library.

## About
This project is maintained by Naxam Co.,Ltd.<br>
We specialize in developing mobile applications using Xamarin and native technology stack.<br>

**Looking for developers for your project?**<br>

<a href="mailto:tuyen@naxam.net"> 
<img src="https://github.com/NAXAM/naxam.github.io/blob/master/assets/img/hire_button.png?raw=true" height="40"></a> <br>

## Installation
```
Install-Package Naxam.iZettle.iOS
```

## How to upgrade
The binding library is very hard for the first time and isn't easy to use `sharpie` to upgrade.
The steps are below

1. Update `Cartfile` with the desired version
2. Use `carthage update --use-xcframeworks` to build the framework files
3. Run `sh create-fat-lib-from-xcf-framework.sh` to create appropriate fat files
4. Check for git changes of header files and add/remove binding accordingly
5. Build project `msbuild izettle-ios.sln /property:Configuration=Release`
6. Run `nuget pack`
7. Create a PR then I will publish on Nuget.org

**NOTE**: 
1. If you don't know Carthage. Check it out [here](https://github.com/Carthage/Carthage).
2. You might use `sharpie` to for step-5 above
3. Carthage: Actually, it doesn't do any special thing, just help us download frameworks from Github

## License

iZettle binding library for iOS is released under the MIT license.
See [LICENSE](./LICENSE) for details.

iZettle library iselft is under iZettle license as specified [here](https://github.com/iZettle/sdk-ios/blob/master/LICENSE).

## Backers
Most of our libraries are built with our own effort at very small funding or just side projects.
However, maintaining binding libraries always takes a lot of time and effort.
Sometimes, people ask us for the latest version, we couldn't afford to upgrade for free due to many other higher prioritized works. Become a backer is the best way to help us always arrange resources to maintain (upgrade and fix issue) binding libraries.

# Get our showcases on AppStore/PlayStore
Try our showcases to know more about our capabilities. 

<a href="https://itunes.apple.com/us/developer/tuyen-vu/id1255432728/" > 
<img src="https://github.com/NAXAM/imagepicker-android-binding/raw/master/art/apple_store.png" width="117" height="34"></a>

<a href="https://play.google.com/store/apps/developer?id=NAXAM+CO.,+LTD" > 
<img src="https://github.com/NAXAM/imagepicker-android-binding/raw/master/art/google_store.png" width="117" height="34"></a>

Contact us if interested.

<a href="mailto:tuyen@naxam.net"> 
<img src="https://github.com/NAXAM/naxam.github.io/blob/master/assets/img/hire_button.png" height="34"></a> <br>
<br>

Follow us for the latest updates<br>[![Twitter URL](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/intent/tweet?text=https://github.com/naxam/izettle-ios-binding)
[![Twitter Follow](https://img.shields.io/twitter/follow/naxamco.svg?style=social)](https://twitter.com/naxamco)
