const fs = require("node:fs");

process_Android_OS_IParcelableCreator();

function onlyUnique(value, index, array) {
  return array.indexOf(value) === index;
}

function process_Android_OS_IParcelableCreator() {
  var input = fs.readFileSync("input.Android.OS.IParcelableCreator.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var parts = x[0].split(".");
      var ns = x[1].replace("." + parts[0], "");
      var cls = parts.reverse().reduce(
        (result, item) => {
          return `partial class ${item} {${result}}`;
        },
        `global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
                {
                    return this.CreateFromParcel(source);
                }
    
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                {
                    return this.NewArray(size);
                }`
      );
      return [ns, cls];
    })
    .reduce((result, item) => {
      var reduced = result.find((x) => x[0] == item[0]);
      if (reduced) {
        reduced.push(item[1]);
      } else {
        result.push(item);
      }
      return result;
    }, [])
    .map((x) => {
      return `namespace ${x[0]} {
            ${x.slice(1).join("\n")}
        }`;
    });

  // console.log(items[0]);
  fs.writeFileSync("output.Android.OS.IParcelableCreator.cs", items.join("\n"));
}
