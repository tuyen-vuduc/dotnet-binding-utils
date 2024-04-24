const fs = require("node:fs");

process_AndroidX_ViewBinding_IViewBinding();
// process_Com_Stripe_Android_Uicore_Elements_IFormElement();
// process_JavaX_Inject_IProvider();
// process_Android_OS_IParcelableCreator();
// process_Com_Stripe_Android_Model_IStripeIntent();

function process_AndroidX_ViewBinding_IViewBinding() {
  var input = fs.readFileSync("input.AndroidX.ViewBinding.IViewBinding.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^ ]+Binding)'.+src\\([^ ]+Binding)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[0];
      var ns = x[1].replace("." + clsName, "");
      return [ns, `partial class ${clsName} {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
        }`];
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
    })
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.AndroidX.ViewBinding.IViewBinding.cs", items.join("\n"));
}

function process_Com_Stripe_Android_Uicore_Elements_IFormElement() {
  var input = fs.readFileSync("input.Com.Stripe.Android.Uicore.Elements.IFormElement.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^ ]+Element)'.+src\\([^ ]+Element)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[0];
      var ns = x[1].replace("." + clsName, "");
      return [ns, `partial class ${clsName} {
        global::Com.Stripe.Android.Uicore.Elements.IController? global::Com.Stripe.Android.Uicore.Elements.IFormElement.Controller => Controller;
        }`];
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
    })
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.Com.Stripe.Android.Uicore.Elements.IFormElement.cs", items.join("\n"));
}

function process_Com_Stripe_Android_Model_IStripeIntent() {
  var input = fs.readFileSync("input.Com.Stripe.Android.Model.IStripeIntent.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^ ]+Intent)'.+src\\([^ ]+Intent)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[0];
      var ns = x[1].replace("." + clsName, "");
      return [ns, `partial class ${clsName} {
        global::Com.Stripe.Android.Model.IStripeIntent.NextActionData? global::Com.Stripe.Android.Model.IStripeIntent.GetNextActionData () => NextActionData;
        global::Com.Stripe.Android.Model.IStripeIntent.NextActionType? global::Com.Stripe.Android.Model.IStripeIntent.GetNextActionType () => NextActionType;
        global::Com.Stripe.Android.Model.IStripeIntent.Status? global::Com.Stripe.Android.Model.IStripeIntent.GetStatus () => Status;
        }`];
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
    })
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.Com.Stripe.Android.Model.IStripeIntent.cs", items.join("\n"));
}

// process_Com_Stripe_Android_Core_Model_Parsers_IModelJsonParser();

function process_Com_Stripe_Android_Core_Model_Parsers_IModelJsonParser() {
  var input = fs.readFileSync("input.Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^ ]+Parser)'.+src\\([^ ]+Parser)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[0];
      var ns = x[1].replace("." + clsName, "");
      return [ns, `partial class ${clsName} {
          global::Java.Lang.Object? global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json) => Parse(json);
        }`];
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
    })
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.cs", items.join("\n"));
}

function process_JavaX_Inject_IProvider() {
  var input = fs.readFileSync("input.JavaX.Inject.IProvider.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^ ]+Factory)'.+src\\([^ ]+Factory)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[0];
      var ns = x[1].replace("." + clsName, "");
      return [ns, `partial class ${clsName} {
          global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object )(object)Get();
        }`];
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
    })
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.JavaX.Inject.IProvider.cs", items.join("\n"));
}

function onlyUnique(value, index, array) {
  return array.indexOf(value) === index;
}

function process_Android_OS_IParcelableCreator() {
  var input = fs.readFileSync("input.Android.OS.IParcelableCreator.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^ ]+Creator)'.+src\\([^ ]+)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var parts = x[0].split(".");
      var ns = x[1].replace("." + parts[0], "");
      var cls = parts.reverse().reduce(
        (result, item) => {
          return `partial class ${item} {${result}}`;
        },
        `global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source)
          => this.CreateFromParcel(source);    
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => this.NewArray(size);`
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
