# Steps to upgrade
- 1. Ensure metadata is up to date 

```bash
sh fetch.sh
```

- 2. Update all packages with changes to not dependency only in `nuget.json`, except `imagepipeline` and `fresco`

- 3. Bind library of `com.facebook.fresco:imagepipeline:3.6.0` first 

```bash
sh bind.sh --artifact com.facebook.fresco:imagepipeline:3.6.0
```

- 3. Bind library of `com.facebook.fresco:fresco:3.6.0`

```bash
sh bind.sh --artifact com.facebook.fresco:fresco:3.6.0
```

**NOTES**: In a normal upgrade, we will need additional stuff to ensure the packages will be updated correctly.

- Mark dependencies of `com.facebook.fresco:imagepipeline` (A) are not dependency only
- After publishing (A), mark (A) are dependency only again
- Mark the remaining dependencies of `com.facebook.fresco:fresco` (B) are not dependency only
- After publishing (A), mark (A) are dependency only again

Dependencies of `com.facebook.fresco:imagepipeline`

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