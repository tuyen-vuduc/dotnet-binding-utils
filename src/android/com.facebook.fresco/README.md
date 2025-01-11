# Steps to upgrade
- 1. Ensure metadata is up to date 

```bash
sh fetch.sh
```

- 2. Bind library of `com.facebook.fresco:imagepipeline:3.6.0` first 

```bash
sh bind.sh --artifact com.facebook.fresco:imagepipeline:3.6.0
```

- 3. Bind library of `com.facebook.fresco:fresco:3.6.0`

```bash
sh bind.sh --artifact com.facebook.fresco:fresco:3.6.0
```

**NOTES**: In a revision upgrade, we will need additional stuff to ensure the packages will be updated correctly.

- Mark dependencies of `Com.Facebook.Fresco.Imagepipeline` are not dependency only
- After publishing these packages, mark those dependencies are dependency only again
- Mark the remaining dependencies of `com.facebook.fresco:fresco` are not dependency only
- After publishing these packages, mark those dependencies are dependency only again

Dependencies of `Com.Facebook.Fresco.Imagepipeline`

```txt
- Com.Facebook.Fresco.Fbcore
- Com.Facebook.Fresco.Imagepipeline
- Com.Facebook.Fresco.ImagepipelineBase
- Com.Facebook.Fresco.Middleware
- Com.Facebook.Fresco.UiCommon
- Com.Facebook.Fresco.UiCore
- Com.Facebook.Fresco.Urimod
- Com.Facebook.Fresco.VitoSource
- Com.Facebook.Soloader.Annotation
- Com.Facebook.Soloader.Nativeloader
```