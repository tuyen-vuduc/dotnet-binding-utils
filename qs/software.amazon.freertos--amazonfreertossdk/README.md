# Build package

```
sh build.sh --base-path $PWD
```

# Issues

1/  `Error CS0534: 'ArrayDecoder' does not implement inherited abstract member 'AbstractDecoder.Decode(int)'` 

```js
var x = `COPIED_ERRORS`;

console.log(
    x
    .split('\n')
    .filter(item => item.indexOf('Xamarin.Android.Bindings.Core.targets') == -1)
    .filter(item => item.indexOf('net6.0') == -1)
    .map(item => /.+src\/([^(]+)\(.+[^']+'(\w+)'[^']+'(\w+)\.(\w+)/.exec(item))
    .map(item => Array.prototype.slice.call(item, 1, item.length))
    .map(item => `    partial class ${item[1]} {
        public override global::Java.Lang.Object Decode (int p0) => DecodeX(p0);
    }`).join('\n')
)
```

2/  `Error CS0534: 'ArrayEncoder' does not implement inherited abstract member 'AbstractEncoder.Encode(Object)'` 

```js
var x = `COPIED_ERRORS`;

console.log(
    x
    .split('\n')
    .filter(item => item.indexOf('Xamarin.Android.Bindings.Core.targets') == -1)
    .filter(item => item.indexOf('net6.0') == -1)
    .map(item => /.+src\/([^(]+)\(.+[^']+'(\w+)'[^']+'(\w+)\.(\w+)/.exec(item))
    .map(item => Array.prototype.slice.call(item, 1, item.length))
    .map(item => `    partial class ${item[1]} {
        public override void Encode (global::Java.Lang.Object p0) => Encode(p0 as global::CO.Nstant.IN.Cbor.Model.${item[1].replace('Encoder', '')});
    }`).join('\n')
)
```