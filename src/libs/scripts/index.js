const fs = require("node:fs");

// process_Com_Squareup_Moshi_JsonAdapter();
// process_protocol();
// process_stripe('STPAPIResponseDecodable', `
//         ISTPAPIResponseDecodable ISTPAPIResponseDecodable.DecodedObjectFromAPIResponse(NSDictionary response)
//             => DecodedObjectFromAPIResponse(response);
//     `);
// process_stripe('STPFormEncodable', '');
// process_field();
// process_IJsonDeserializer();
// process_Com_Example_Dsroom_Dao_IBaseDao();
// process_Com_Google_Android_Material_Circularreveal_ICircularRevealWidget();
// process_Android_Util_ITypeEvaluator();
// process_Android_Util_Property();
// process_downgrade();
// process_AndroidX_ViewBinding_IViewBinding();
// process_Com_Stripe_Android_Uicore_Elements_IFormElement();
process_JavaX_Inject_IProvider();
// process_Android_OS_IParcelableCreator();
// process_Com_Stripe_Android_Model_IStripeIntent();

function process_Com_Squareup_Moshi_JsonAdapter() {
  var input = fs.readFileSync("input.Com.Squareup.Moshi.JsonAdapter.txt");
  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+src\\([^ ]+JsonAdapter)\.cs.+'(\w+(?:_\w+)?JsonAdapter)'.+/.exec(x))
    .filter(x => !!x && x.length == 3)
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(' '))
    .map((x) => {
      var parts = x[1].split('.');
      var ns = x[0].replace("." + parts[0], '');
      var cls = parts.reverse().reduce(
        (result, item) => {
          return `partial class ${item} {
          ${result.replace('MODEL_NAME', item.replace('JsonAdapter', ''))}
        }`;
        },        
        `public unsafe override global::Java.Lang.Object? FromJson (global::Com.Squareup.Moshi.JsonReader reader)
            => this.FromJson_(reader); 
        public unsafe override void ToJson (global::Com.Squareup.Moshi.JsonWriter writer, global::Java.Lang.Object? obj)
            => this.ToJson_(writer, obj as ${ns}.MODEL_NAME); `
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
  fs.writeFileSync("output.Com.Squareup.Moshi.JsonAdapter.cs", items.join("\n"));
}

function process_protocol() {
  var input = fs.readFileSync("input.stripe.txt");
  var regex = /.+@protocol (\w+).+/;

  var items = input
    .toString()
    .trim()
    .split("\n")
    .filter(x => regex.test(x))
    .map(x => regex.exec(x));
  
  items = items
    .map(x => {
      return x.slice(1, 2);
    })
    .map(x => {
      return x[0];
    })
    .filter(onlyUnique)
    .map((x) => `
    partial interface I${x} { }
    `)
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.stripe.cs", items.join(""));
}
function process_stripe(protocol, additional) {
  var input = fs.readFileSync("input.stripe.txt");
  var regex = new RegExp(`interface ([\\w]+)[^<]+${protocol}`);

  var items = input
    .toString()
    .trim()
    .split("\n")
    .filter(x => regex.test(x))
    .map(x => regex.exec(x));
  
  items = items
    .map(x => {
      return x.slice(1, 2);
    })
    .map(x => {
      return x[0];
    })
    .filter(onlyUnique)
    .map((x) => `
    partial class ${x} : I${protocol} {${additional}}
    `)
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.stripe.cs", items.join(""));
}

function process_field() {
  var input = fs.readFileSync("input.field.txt")
  .toString()
  .trim()
  .split("\n")
  .filter(x => x.indexOf('<field') > -1);

  var items = input
    .map(x => /.+ name="([A-Za-z0-9._]+)".+/.exec(x))
    .map(x => {
      return x.slice(1, 2);
    })
    .map(x => x[0]);
  
  items = items
    .filter(onlyUnique)
    .map((x) => {
      var csName = x.toUpperCase() == x
        ? x : x + '_'
      return `<attr path=\"//field[@name='${x}']\" name=\"managedName\">${csName}</attr>`
    })
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.field.xml", items.join("\n"));
}

function process_Com_Example_Dsroom_Dao_IBaseDao() {
  var input = fs.readFileSync("input.Com.Example.Dsroom.Dao.IBaseDao.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^_]+_Impl)'.+src\\([^_]+_Impl)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[0];
      var modelname = clsName.replace('Dao_Impl', 'Model');
      var ns = x[1].replace("." + clsName, "");
      return [ns, `partial class ${clsName} {        
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.${modelname}, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.${modelname}>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.${modelname}, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.${modelname}>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.${modelname}, p1);
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
  fs.writeFileSync("output.Com.Example.Dsroom.Dao.IBaseDao.cs", items.join("\n"));
}

function process_IJsonDeserializer() {
  var input = fs.readFileSync("input.Com.Example.Dsroom.Dao.IBaseDao.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^_]+_Impl)'.+src\\([^_]+_Impl)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[0];
      var modelname = clsName.replace('Dao_Impl', 'Model');
      var ns = x[1].replace("." + clsName, "");
      return [ns, `partial class ${clsName} {        
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.${modelname}, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.${modelname}>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.${modelname}, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.${modelname}>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.${modelname}, p1);
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
  fs.writeFileSync("output.Com.Example.Dsroom.Dao.IBaseDao.cs", items.join("\n"));
}

function process_Com_Google_Android_Material_Circularreveal_ICircularRevealWidget() {
  var input = fs.readFileSync("input.Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /Error	CS0535	'(\w+[^']+)'.+src\\([^ ]+)\.cs.+/.exec(x))
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[0];
      var ns = x[1].replace("." + clsName, "");
      return [ns, `partial class ${clsName} {
        global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.GetRevealInfo () 
          => RevealInfo;
        void Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.SetRevealInfo (global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo? arg) 
            => RevealInfo = arg;
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

  console.log(items[0]);
  fs.writeFileSync("output.Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.cs", items.join("\n"));
}

function process_downgrade() {
  var input = fs.readFileSync("input.downgrade.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .filter(x => x.indexOf('downgrade:') > 0)
    .map(x => /.+ downgrade: ([A-Za-z0-9._]+) from ([0-9.]+) to .+/.exec(x));
  
  items = items
    .map(x => {
      return x.slice(1, 3);
    })
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => "\"" + x.join('": "') + "\"")
    ;

  // console.log(items[0]);
  fs.writeFileSync("output.downgrade.cs", items.join(",\n"));
}

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
    .map(x => /.+src\\([^ ]+Factory)\.cs.+'(\w+[^ ]+Factory)'.+/.exec(x))
    .filter(x => !!x)
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var clsName = x[1];
      var ns = x[0].replace("." + clsName, "");
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
    .map(x => /.+src\\([^ ]+)\.cs.+'(\w+[^ ]+Creator)'.+/.exec(x))
    .filter(x => !!x)
    .map(x => x.slice(1, 3))
    .map(x => x.join(' '))
    .filter(onlyUnique)
    .map((x) => x.split(" "))
    .map((x) => {
      var parts = x[1].split(".");
      var ns = x[0].replace("." + parts[0], "");
      var cls = parts.reverse().reduce(
        (result, item) => {
          return `partial class ${item} {${result}}`;
        },
        `global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);    
         global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);`
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

function process_Android_Util_Property() {
  var input = fs.readFileSync("input.Android.Util.Property.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^ ]+Property)'.+src\\([^ ]+)\.cs.+/.exec(x))
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
        `public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
            => this.Get(source); `
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
  fs.writeFileSync("output.Android.Util.Property.cs", items.join("\n"));
}

function process_Android_Util_ITypeEvaluator() {
  var input = fs.readFileSync("input.Android.Animation.ITypeEvaluator.txt");

  var items = input
    .toString()
    .trim()
    .split("\n")
    .map(x => /.+'(\w+[^ ]+Evaluator)'.+src\\([^ ]+)\.cs.+/.exec(x))
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
        `Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
            => this.Evaluate(fraction, startValue as Java.Lang.Integer, endValue as Java.Lang.Integer); `
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
  fs.writeFileSync("output.Android.Animation.ITypeEvaluator.cs", items.join("\n"));
}
