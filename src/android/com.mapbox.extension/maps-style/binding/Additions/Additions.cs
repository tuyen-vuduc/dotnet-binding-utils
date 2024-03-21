using System;
using Android.Runtime;

namespace Com.Mapbox.Maps.Extension.Style.Projection.Generated
{
    public static class StyleProjectionUtilsExtensions
    {
        public static unsafe void SetProjection(
            this global::Com.Mapbox.Maps.MapboxStyleManager obj,
            global::Com.Mapbox.Maps.Extension.Style.Projection.Generated.Projection projection)
            => StyleProjectionUtils.SetProjection(obj, projection);
        public static unsafe global::Com.Mapbox.Maps.Extension.Style.Projection.Generated.Projection GetProjection(
            this global::Com.Mapbox.Maps.MapboxStyleManager obj)
            => StyleProjectionUtils.GetProjection(obj);
    }
}

namespace Com.Mapbox.Maps.Extension.Style.Light.Generated
{
    partial class FlatLightKt
    {
        public static unsafe void FlatLight(
            Action<Com.Mapbox.Maps.Extension.Style.Light.Generated.IFlatLightDslReceiver> build,
            string id = "flat")
            => FlatLightKt.FlatLight(id, new global::Com.Mapbox.Functions.Function1Action<IFlatLightDslReceiver>(build));
    }
}

namespace Com.Mapbox.Maps.Extension.Style.Light
{
    public static class LightUtilsExt
    {
        public static unsafe void SetLight(
            this global::Com.Mapbox.Maps.MapboxStyleManager obj,
            Action<Com.Mapbox.Maps.Extension.Style.Light.Generated.IFlatLightDslReceiver> build,
            string id = "flat")
            => LightUtils.SetLight(
                obj,
                Com.Mapbox.Maps.Extension.Style.Light.Generated.FlatLightKt.FlatLight(
                    id, new
                    global::Com.Mapbox.Functions.Function1Action<Com.Mapbox.Maps.Extension.Style.Light.Generated.IFlatLightDslReceiver>(build)));
        public static unsafe void SetLight(
            this global::Com.Mapbox.Maps.MapboxStyleManager obj,
            global::Com.Mapbox.Maps.Extension.Style.Light.Generated.FlatLight flatLight)
            => LightUtils.SetLight(obj, flatLight);
        public static unsafe void SetLight(
            this global::Com.Mapbox.Maps.MapboxStyleManager obj,
            global::Com.Mapbox.Maps.Extension.Style.Light.Generated.AmbientLight ambientLight,
            global::Com.Mapbox.Maps.Extension.Style.Light.Generated.DirectionalLight directionalLight)
            => LightUtils.SetLight(obj, ambientLight, directionalLight);
        public static unsafe void SetLights(
            this global::Com.Mapbox.Maps.MapboxStyleManager obj,
            global::System.Collections.Generic.IList<global::Com.Mapbox.Maps.Extension.Style.Light.Light> lights)
            => LightUtils.SetLights(obj, lights);
        public static unsafe global::Com.Mapbox.Maps.Extension.Style.Light.Light GetLight(
            this global::Com.Mapbox.Maps.MapboxStyleManager obj,
            string lightId)
            => LightUtils.GetLight(obj, lightId);
    }
}

namespace Com.Mapbox.Maps.Extension.Style.Expressions.Generated
{
    partial class Expression
    {
        partial class ExpressionBuilder
        {
            /**
            * For two inputs, returns the result of subtracting the second input from the first. For a
            * single input, returns the result of subtracting it from 0.
            */
            public ExpressionBuilder Subtract(Action<ExpressionBuilder> action) => Subtract(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Logical negation. Returns `true` if the input is `false`, and `false` if the input is `true`.
             */
            public ExpressionBuilder Not(Action<ExpressionBuilder> action) => Not(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns `true` if the input values are not equal, `false` otherwise. The comparison is strictly typed:
             * values of different runtime types are always considered unequal. Cases where the types are known to
             * be different at parse time are considered invalid and will produce a parse error. Accepts an
             * optional `collator` argument to control locale-dependent string comparisons.
             */
            public ExpressionBuilder Neq(Action<ExpressionBuilder> action) => Neq(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the product of the inputs.
             */
            public ExpressionBuilder Product(Action<ExpressionBuilder> action) => Product(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the result of floating point division of the first input by the second.
             */
            public ExpressionBuilder Division(Action<ExpressionBuilder> action) => Division(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the remainder after integer division of the first input by the second.
             */
            public ExpressionBuilder Mod(Action<ExpressionBuilder> action) => Mod(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the result of raising the first input to the power specified by the second.
             */
            public ExpressionBuilder Pow(Action<ExpressionBuilder> action) => Pow(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the sum of the inputs.
             */
            public ExpressionBuilder Sum(Action<ExpressionBuilder> action) => Sum(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns `true` if the first input is strictly less than the second, `false` otherwise. The arguments
             * are required to be either both strings or both numbers; if during evaluation they are not,
             * expression evaluation produces an error. Cases where this constraint is known not to hold at parse
             * time are considered in valid and will produce a parse error. Accepts an optional `collator` argument
             * to control locale-dependent string comparisons.
             */
            public ExpressionBuilder Lt(Action<ExpressionBuilder> action) => Lt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns `true` if the first input is less than or equal to the second, `false` otherwise.
             * The arguments are required to be either both strings or both numbers; if during evaluation they
             * are not, expression evaluation produces an error. Cases where this constraint is known not to hold
             * at parse time are considered in valid and will produce a parse error. Accepts an optional
             * `collator` argument to control locale-dependent string comparisons.
             */
            public ExpressionBuilder Lte(Action<ExpressionBuilder> action) => Lte(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns `true` if the input values are equal, `false` otherwise. The comparison is strictly typed: values
             * of different runtime types are always considered unequal. Cases where the types are known to be
             * different at parse time are considered invalid and will produce a parse error. Accepts an optional
             * `collator` argument to control locale-dependent string comparisons.
             */
            public ExpressionBuilder Eq(Action<ExpressionBuilder> action) => Eq(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns `true` if the first input is strictly greater than the second, `false` otherwise. The arguments
             * are required to be either both strings or both numbers; if during evaluation they are not,
             * expression evaluation produces an error. Cases where this constraint is known not to hold at parse
             * time are considered in valid and will produce a parse error. Accepts an optional `collator` argument
             * to control locale-dependent string comparisons.
             */
            public ExpressionBuilder Gt(Action<ExpressionBuilder> action) => Gt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns `true` if the first input is greater than or equal to the second, `false` otherwise.
             * The arguments are required to be either both strings or both numbers; if during evaluation they
             * are not, expression evaluation produces an error. Cases where this constraint is known not to hold
             * at parse time are considered in valid and will produce a parse error. Accepts an optional
             * `collator` argument to control locale-dependent string comparisons.
             */
            public ExpressionBuilder Gte(Action<ExpressionBuilder> action) => Gte(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the absolute value of the input.
             */
            public ExpressionBuilder Abs(Action<ExpressionBuilder> action) => Abs(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the arccosine of the input.
             */
            public ExpressionBuilder Acos(Action<ExpressionBuilder> action) => Acos(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns `true` if all the inputs are `true`, `false` otherwise. The inputs are evaluated in order,
             * and evaluation is short-circuiting: once an input expression evaluates to `false`, the result is `false` and
             * no further input expressions are evaluated.
             */
            public ExpressionBuilder All(Action<ExpressionBuilder> action) => All(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns `true` if any of the inputs are `true`, `false` otherwise. The inputs are evaluated in
             * order, and evaluation is short-circuiting: once an input expression evaluates to `true`, the result is `true`
             * and no further input expressions are evaluated.
             */
            public ExpressionBuilder Any(Action<ExpressionBuilder> action) => Any(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Asserts that the input is an array (optionally with a specific item type and length). If,
             * when the input expression is evaluated, it is not of the asserted type, then this assertion
             * will cause the whole expression to be aborted.
             */
            public ExpressionBuilder Array(Action<ExpressionBuilder> action) => Array(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the arcsine of the input.
             */
            public ExpressionBuilder Asin(Action<ExpressionBuilder> action) => Asin(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Retrieves an item from an array.
             */
            public ExpressionBuilder At(Action<ExpressionBuilder> action) => At(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the arctangent of the input.
             */
            public ExpressionBuilder Atan(Action<ExpressionBuilder> action) => Atan(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Asserts that the input value is a boolean. If multiple values are provided, each one is
             * evaluated in order until a boolean is obtained. If none of the inputs are booleans, the
             * expression is an error.
             */
            public ExpressionBuilder Boolean(Action<ExpressionBuilder> action) => Boolean(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Selects the first output whose corresponding test condition evaluates to true, or the fallback value otherwise.
             */
            public ExpressionBuilder SwitchCase(Action<ExpressionBuilder> action) => SwitchCase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the smallest integer that is greater than or equal to the input.
             */
            public ExpressionBuilder Ceil(Action<ExpressionBuilder> action) => Ceil(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Evaluates each expression in turn until the first valid value is obtained. Invalid values are `null`
             * and [`'image'`](#types-image) expressions that are unavailable in the style. If all values are invalid, `coalesce` returns
             * the first value listed.
             */
            public ExpressionBuilder Coalesce(Action<ExpressionBuilder> action) => Coalesce(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns a `collator` for use in locale-dependent comparison operations. The `case-sensitive` and `diacritic-sensitive` options default to
             * `false`. The `locale` argument specifies the IETF language tag of the locale to use. If none
             * is provided, the default locale is used. If the requested locale is not available, the `collator`
             * will use a system-defined fallback locale. Use `resolved-locale` to test the results of locale fallback behavior.
             */
            public ExpressionBuilder Collator(Action<CollatorBuilder> action) => Collator(new global::Com.Mapbox.Functions.Function1Action<CollatorBuilder>(action));

            /**
             * Returns a `string` consisting of the concatenation of the inputs. Each input is converted to a
             * string as if by `to-string`.
             */
            public ExpressionBuilder Concat(Action<ExpressionBuilder> action) => Concat(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Retrieves the configuration value for the given option.
             */
            public ExpressionBuilder Config(Action<ExpressionBuilder> action) => Config(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the cosine of the input.
             */
            public ExpressionBuilder Cos(Action<ExpressionBuilder> action) => Cos(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the input string converted to lowercase. Follows the Unicode Default Case Conversion algorithm and the
             * locale-insensitive case mappings in the Unicode Character Database.
             */
            public ExpressionBuilder Downcase(Action<ExpressionBuilder> action) => Downcase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Retrieves a property value from the current feature's state. Returns `null` if the requested property is
             * not present on the feature's state. A feature's state is not part of the GeoJSON or
             * vector tile data, and must be set programmatically on each feature. Features are identified by their
             * `id` attribute, which must be an integer or a string that can be cast to an
             * integer. Note that ["feature-state"] can only be used with paint properties that support data-driven styling.
             */
            public ExpressionBuilder FeatureState(Action<ExpressionBuilder> action) => FeatureState(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the largest integer that is less than or equal to the input.
             */
            public ExpressionBuilder Floor(Action<ExpressionBuilder> action) => Floor(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns a `formatted` string for displaying mixed-format text in the `text-field` property. The input may contain
             * a string literal or expression, including an [`'image'`](#types-image) expression. Strings may be followed by a style
             * override object that supports the following properties:
             * - `"text-font"`: Overrides the font stack specified by the root layout property.
             * - `"text-color"`: Overrides the color specified by the root paint property.
             * - `"font-scale"`: Applies a scaling factor on `text-size` as specified by the root layout property.
             */
            public ExpressionBuilder Format(Action<FormatBuilder> action) => Format(new global::Com.Mapbox.Functions.Function1Action<FormatBuilder>(action));

            /**
             * Retrieves a property value from the current feature's properties, or from another object if a second
             * argument is provided. Returns `null` if the requested property is missing.
             */
            public ExpressionBuilder Get(Action<ExpressionBuilder> action) => Get(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Tests for the presence of an property value in the current feature's properties, or from another
             * object if a second argument is provided.
             */
            public ExpressionBuilder Has(Action<ExpressionBuilder> action) => Has(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Creates a color value from hue (range 0-360), saturation and lightness components (range 0-100), and an
             * alpha component of 1. If any component is out of range, the expression is an error.
             */
            public ExpressionBuilder Hsl(Action<ExpressionBuilder> action) => Hsl(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Creates a color value from hue (range 0-360), saturation and lightness components (range 0-100), and an
             * alpha component (range 0-1). If any component is out of range, the expression is an error.
             */
            public ExpressionBuilder Hsla(Action<ExpressionBuilder> action) => Hsla(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns a [`ResolvedImage`](/mapbox-gl-js/style-spec/types/#resolvedimage) for use in [`icon-image`](/mapbox-gl-js/style-spec/layers/#layout-symbol-icon-image), `--pattern` entries, and as a section in the [`'format'`](#types-format)
             * expression. A [`'coalesce'`](#coalesce) expression containing `image` expressions will evaluate to the first listed image that is
             * currently in the style. This validation process is synchronous and requires the image to have been
             * added to the style before requesting it in the `'image'` argument.
             */
            public ExpressionBuilder Image(Action<ExpressionBuilder> action) => Image(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Determines whether an item exists in an array or a substring exists in a string. In
             * the specific case when the second and third arguments are string literals, you must wrap at
             * least one of them in a [`literal`](#types-literal) expression to hint correct interpretation to the [type system](#type-system).
             */
            public ExpressionBuilder InExpression(Action<ExpressionBuilder> action) => InExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the first position at which an item can be found in an array or a
             * substring can be found in a string, or `-1` if the input cannot be found. Accepts
             * an optional index from where to begin the search.
             */
            public ExpressionBuilder IndexOf(Action<ExpressionBuilder> action) => IndexOf(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Produces continuous, smooth results by interpolating between pairs of input and output values ("stops"). The `input`
             * may be any numeric expression (e.g., `["get", "population"]`). Stop inputs must be numeric literals in strictly
             * ascending order. The output type must be `number`, `array<number>`, or `color`.
             *
             * Interpolation types:
             * - `["linear"]`: Interpolates linearly between the pair of stops just less than and just greater than
             * the input.
             * - `["exponential", base]`: Interpolates exponentially between the stops just less than and just greater than the
             * input. `base` controls the rate at which the output increases: higher values make the output increase
             * more towards the high end of the range. With values close to 1 the output increases
             * linearly.
             * - `["cubic-bezier", x1, y1, x2, y2]`: Interpolates using the cubic bezier curve defined by the given
             * control points.
             */
            public ExpressionBuilder Interpolate(Action<InterpolatorBuilder> action) => Interpolate(new global::Com.Mapbox.Functions.Function1Action<InterpolatorBuilder>(action));

            /**
             * Returns `true` if the input string is expected to render legibly. Returns `false` if the input
             * string contains sections that cannot be rendered without potential loss of meaning (e.g. Indic scripts that
             * require complex text shaping, or right-to-left scripts if the the `mapbox-gl-rtl-text` plugin is not in use
             * in Mapbox GL JS).
             */
            public ExpressionBuilder IsSupportedScript(Action<ExpressionBuilder> action) => IsSupportedScript(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the length of an array or string.
             */
            public ExpressionBuilder Length(Action<ExpressionBuilder> action) => Length(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Binds expressions to named variables, which can then be referenced in the result expression using ["var",
             * "variable_name"].
             */
            public ExpressionBuilder LetExpression(Action<ExpressionBuilder> action) => LetExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the natural logarithm of the input.
             */
            public ExpressionBuilder Ln(Action<ExpressionBuilder> action) => Ln(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the base-ten logarithm of the input.
             */
            public ExpressionBuilder Log10(Action<ExpressionBuilder> action) => Log10(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the base-two logarithm of the input.
             */
            public ExpressionBuilder Log2(Action<ExpressionBuilder> action) => Log2(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Selects the output for which the label value matches the input value, or the fallback value
             * if no match is found. The input can be any expression (for example, `["get", "building_type"]`). Each
             * label must be unique, and must be either:
             * - a single literal value; or
             * - an array of literal values, the values of which must be all strings or
             * all numbers (for example `[100, 101]` or `["c", "b"]`).
             *
             * The input matches if any of the values in the array matches using strict equality, similar
             * to the `"in"` operator.
             * If the input type does not match the type of the labels, the result will be
             * the fallback value.
             */
            public ExpressionBuilder Match(Action<ExpressionBuilder> action) => Match(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the maximum value of the inputs.
             */
            public ExpressionBuilder Max(Action<ExpressionBuilder> action) => Max(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns a requested property of the light configuration based on the supplied options. Currently the only
             * supported option is `brightness` which returns the global brightness value of the lights on a scale
             * of 0 to 1, where 0 means total darkness and 1 means full brightness. This expression
             * works only with 3D light, i.e. when `lights` root property is defined.
             */
            public ExpressionBuilder MeasureLight(Action<ExpressionBuilder> action) => MeasureLight(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the minimum value of the inputs.
             */
            public ExpressionBuilder Min(Action<ExpressionBuilder> action) => Min(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Asserts that the input value is a number. If multiple values are provided, each one is
             * evaluated in order until a number is obtained. If none of the inputs are numbers, the
             * expression is an error.
             */
            public ExpressionBuilder Number(Action<ExpressionBuilder> action) => Number(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Converts the input number into a string representation using the providing formatting rules. If set, the
             * `locale` argument specifies the locale to use, as a BCP 47 language tag. If set, the
             * `currency` argument specifies an ISO 4217 code to use for currency-style formatting. If set, the `unit`
             * argument specifies a [simple ECMAScript unit](https://tc39.es/proposal-unified-intl-numberformat/section6/locales-currencies-tz_proposed_out.html#sec-issanctionedsimpleunitidentifier) to use for unit-style formatting. If set, the `min-fraction-digits` and
             * `max-fraction-digits` arguments specify the minimum and maximum number of fractional digits to include.
             */
            public ExpressionBuilder NumberFormat(Expression input, Action<NumberFormatBuilder> action) => NumberFormat(input, new global::Com.Mapbox.Functions.Function1Action<NumberFormatBuilder>(action));

            /**
             * Asserts that the input value is an object. If multiple values are provided, each one is
             * evaluated in order until an object is obtained. If none of the inputs are objects, the
             * expression is an error.
             */
            public ExpressionBuilder ObjectExpression(Action<ExpressionBuilder> action) => ObjectExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns a random value in the specified range (first two input numbers) based on a supplied
             * seed (third input). The seed can be an expression or a constant number or string value.
             */
            public ExpressionBuilder Random(Action<ExpressionBuilder> action) => Random(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the IETF language tag of the locale being used by the provided `collator`. This can
             * be used to determine the default system locale, or to determine if a requested locale was
             * successfully loaded.
             */
            public ExpressionBuilder ResolvedLocale(Action<ExpressionBuilder> action) => ResolvedLocale(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Creates a color value from red, green, and blue components, which must range between 0 and
             * 255, and an alpha component of 1. If any component is out of range, the expression
             * is an error.
             */
            public ExpressionBuilder Rgb(Action<ExpressionBuilder> action) => Rgb(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Creates a color value from red, green, blue components, which must range between 0 and 255,
             * and an alpha component which must range between 0 and 1. If any component is out
             * of range, the expression is an error.
             */
            public ExpressionBuilder Rgba(Action<ExpressionBuilder> action) => Rgba(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Rounds the input to the nearest integer. Halfway values are rounded away from zero. For example,
             * `["round", -1.5]` evaluates to -2.
             */
            public ExpressionBuilder Round(Action<ExpressionBuilder> action) => Round(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the sine of the input.
             */
            public ExpressionBuilder Sin(Action<ExpressionBuilder> action) => Sin(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns an item from an array or a substring from a string from a specified start
             * index, or between a start index and an end index if set. The return value is
             * inclusive of the start index but not of the end index.
             */
            public ExpressionBuilder Slice(Action<ExpressionBuilder> action) => Slice(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the square root of the input.
             */
            public ExpressionBuilder Sqrt(Action<ExpressionBuilder> action) => Sqrt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Produces discrete, stepped results by evaluating a piecewise-constant function defined by pairs of input and output
             * values ("stops"). The `input` may be any numeric expression (e.g., `["get", "population"]`). Stop inputs must be
             * numeric literals in strictly ascending order. Returns the output value of the stop just less than
             * the input, or the first output if the input is less than the first stop.
             */
            public ExpressionBuilder Step(Action<ExpressionBuilder> action) => Step(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Asserts that the input value is a string. If multiple values are provided, each one is
             * evaluated in order until a string is obtained. If none of the inputs are strings, the
             * expression is an error.
             */
            public ExpressionBuilder String(Action<ExpressionBuilder> action) => String(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the tangent of the input.
             */
            public ExpressionBuilder Tan(Action<ExpressionBuilder> action) => Tan(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Converts the input value to a boolean. The result is `false` when then input is an
             * empty string, 0, `false`, `null`, or `NaN`; otherwise it is `true`.
             */
            public ExpressionBuilder ToBoolean(Action<ExpressionBuilder> action) => ToBoolean(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Converts the input value to a color. If multiple values are provided, each one is evaluated
             * in order until the first successful conversion is obtained. If none of the inputs can be
             * converted, the expression is an error.
             */
            public ExpressionBuilder ToColor(Action<ExpressionBuilder> action) => ToColor(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Converts the input value to a number, if possible. If the input is `null` or `false`,
             * the result is 0. If the input is `true`, the result is 1. If the input
             * is a string, it is converted to a number as specified by the ["ToNumber Applied to
             * the String Type" algorithm](https://tc39.github.io/ecma262/#sec-tonumber-applied-to-the-string-type) of the ECMAScript Language Specification. If multiple values are provided, each one
             * is evaluated in order until the first successful conversion is obtained. If none of the inputs
             * can be converted, the expression is an error.
             */
            public ExpressionBuilder ToNumber(Action<ExpressionBuilder> action) => ToNumber(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns a four-element array containing the input color's red, green, blue, and alpha components, in that
             * order.
             */
            public ExpressionBuilder ToRgba(Action<ExpressionBuilder> action) => ToRgba(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Converts the input value to a string. If the input is `null`, the result is `""`.
             * If the input is a [`boolean`](#types-boolean), the result is `"true"` or `"false"`. If the input is
             * a number, it is converted to a string as specified by the ["NumberToString" algorithm](https://tc39.github.io/ecma262/#sec-tostring-applied-to-the-number-type) of the
             * ECMAScript Language Specification. If the input is a [`color`](#color), it is converted to a string of
             * the form `"rgba(r,g,b,a)"`, where `r`, `g`, and `b` are numerals ranging from 0 to 255, and
             * `a` ranges from 0 to 1. If the input is an [`'image'`](#types-image) expression, `'to-string'` returns the
             * image name. Otherwise, the input is converted to a string in the format specified by the
             * [`JSON.stringify`](https://tc39.github.io/ecma262/#sec-json.stringify) function of the ECMAScript Language Specification.
             */
            public ExpressionBuilder ToString(Action<ExpressionBuilder> action) => ToString(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns a string describing the type of the given value.
             */
            public ExpressionBuilder TypeofExpression(Action<ExpressionBuilder> action) => TypeofExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Returns the input string converted to uppercase. Follows the Unicode Default Case Conversion algorithm and the
             * locale-insensitive case mappings in the Unicode Character Database.
             */
            public ExpressionBuilder Upcase(Action<ExpressionBuilder> action) => Upcase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * References variable bound using "let".
             */
            public ExpressionBuilder VarExpression(Action<ExpressionBuilder> action) => VarExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Add a pair of input and output values.
             * The `input` may be any numeric expression (e.g., `["get", "population"]`).
             * Stop inputs must be numeric literals in strictly ascending order.
             * Returns the output value of the stop just less than the input,
             * or the first output if the input is less than the first stop.
             *
             * It is to be used as part of parameters in the step expression.
             */
            public ExpressionBuilder Stop(Action<ExpressionBuilder> action) => Stop(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Add a pair of input and output values.
             * The `input` may be any numeric expression (e.g., `["get", "population"]`).
             * Stop inputs must be numeric literals in strictly ascending order.
             * Returns the output value of the stop just less than the input,
             * or the first output if the input is less than the first stop.
             * It is to be used as part of parameters in the step expression.
             *
             * @param input as a double
             * @param output as Expression DSL block
             */
            public ExpressionBuilder Stop(Double input, Action<ExpressionBuilder> action) => Stop(input, new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Converts the input number into a string representation using the providing formatting rules. If set, the
             * `locale` argument specifies the locale to use, as a BCP 47 language tag. If set, the
             * `currency` argument specifies an ISO 4217 code to use for currency-style formatting. If set, the `min-fraction-digits`
             * and `max-fraction-digits` arguments specify the minimum and maximum number of fractional digits to include.
             */
            public ExpressionBuilder NumberFormat(Double value, Action<NumberFormatBuilder> action) => NumberFormat(value, new global::Com.Mapbox.Functions.Function1Action<NumberFormatBuilder>(action));

        }

        partial class InterpolatorBuilder
        {
            /**
             * Interpolates exponentially between the stops just less than and just greater than the input.
             * `base` controls the rate at which the output increases:
             * higher values make the output increase more towards the high end of the range.
             * With values close to 1 the output increases linearly.
             */
            public InterpolatorBuilder Exponential(Action<ExpressionBuilder> action) => Exponential(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Interpolates using the cubic bezier curve defined by the given control points.
             */
            public InterpolatorBuilder CubicBezier(Action<ExpressionBuilder> action) => CubicBezier(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));
        }

        partial class NumberFormatBuilder
        {
            /**
             * Number formatting option for specifying the locale to use, as a BCP 47 language tag.
             *
             * @return number format builder
             */
            public NumberFormatBuilder Locale(Action<ExpressionBuilder> action) => Locale(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Number formatting option for specifying the currency to use, an ISO 4217 code.
             *
             * @return number format option
             */
            public NumberFormatBuilder Currency(Action<ExpressionBuilder> action) => Currency(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Number formatting options for specifying the minimum fraction digits to include.
             *
             * @return number format option
             */
            public NumberFormatBuilder MinFractionDigits(Action<ExpressionBuilder> action) => MinFractionDigits(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Number formatting options for specifying the minimum fraction digits to include.
             *
             * @return number format option
             */
            public NumberFormatBuilder MaxFractionDigits(Action<ExpressionBuilder> action) => MaxFractionDigits(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));
        }

        partial class FormatSectionBuilder
        {
            /**
             * If set, the font-scale argument specifies a scaling factor relative to the text-size
             * specified in the root layout properties.
             *
             * "font-scale" is required to be of a resulting type number.
             */
            public FormatSectionBuilder FontScale(Action<ExpressionBuilder> action) => FontScale(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * If set, the text-font argument overrides the font specified by the root layout properties.
             *
             * "text-font" is required to be a literal array.
             *
             * The requested font stack has to be a part of the used style.
             * For more information see [The online documentation](https://www.mapbox.com/help/define-font-stack/).
             */
            public FormatSectionBuilder TextFont(Action<ExpressionBuilder> action) => TextFont(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * If set, the text-color argument overrides the color specified by the root paint properties.
             */
            public FormatSectionBuilder TextColor(Action<ExpressionBuilder> action) => TextColor(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));
        }

        partial class FormatBuilder
        {
            /**
             * A component of the Formatted expression.
             *
             * @param content displayed string or image as an Expression
             */
            public FormatBuilder FormatSection(Expression content, Action<FormatSectionBuilder> action) => FormatSection(content, new global::Com.Mapbox.Functions.Function1Action<FormatSectionBuilder>(action));

            /**
             * A component of the Formatted expression.
             *
             * @param text displayed string
             */
            public FormatBuilder FormatSection(String text, Action<FormatSectionBuilder> action) => FormatSection(text, new global::Com.Mapbox.Functions.Function1Action<FormatSectionBuilder>(action));
        }

        /**
         * Builder for Collator expression.
         */
        partial class CollatorBuilder
        {
            /**
             * Set the case-sensitive option, default to false.
             */
            public CollatorBuilder CaseSensitive(Action<ExpressionBuilder> action) => CaseSensitive(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Set the  diacritic-sensitive option, default to false.
             */
            public CollatorBuilder DiacriticSensitive(Action<ExpressionBuilder> action) => DiacriticSensitive(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Set the locale option.
             */
            public CollatorBuilder Locale(Action<ExpressionBuilder> action) => Locale(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));
        }

        /**
         * Static variables and methods.
         */
        partial class Companion
        {
            /**
             * DSL function for "-".
             */
            public Expression Subtract(Action<ExpressionBuilder> action) => Subtract(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "!".
             */
            public Expression Not(Action<ExpressionBuilder> action) => Not(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "!=".
             */
            public Expression Neq(Action<ExpressionBuilder> action) => Neq(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "*".
             */
            public Expression Product(Action<ExpressionBuilder> action) => Product(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "/".
             */
            public Expression Division(Action<ExpressionBuilder> action) => Division(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "%".
             */
            public Expression Mod(Action<ExpressionBuilder> action) => Mod(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "^".
             */
            public Expression Pow(Action<ExpressionBuilder> action) => Pow(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "+".
             */
            public Expression Sum(Action<ExpressionBuilder> action) => Sum(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "<".
             */
            public Expression Lt(Action<ExpressionBuilder> action) => Lt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "<=".
             */
            public Expression Lte(Action<ExpressionBuilder> action) => Lte(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "==".
             */
            public Expression Eq(Action<ExpressionBuilder> action) => Eq(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for ">".
             */
            public Expression Gt(Action<ExpressionBuilder> action) => Gt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for ">=".
             */
            public Expression Gte(Action<ExpressionBuilder> action) => Gte(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "abs".
             */
            public Expression Abs(Action<ExpressionBuilder> action) => Abs(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "acos".
             */
            public Expression Acos(Action<ExpressionBuilder> action) => Acos(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "all".
             */
            public Expression All(Action<ExpressionBuilder> action) => All(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "any".
             */
            public Expression Any(Action<ExpressionBuilder> action) => Any(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "array".
             */
            public Expression Array(Action<ExpressionBuilder> action) => Array(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "asin".
             */
            public Expression Asin(Action<ExpressionBuilder> action) => Asin(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "at".
             */
            public Expression At(Action<ExpressionBuilder> action) => At(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "atan".
             */
            public Expression Atan(Action<ExpressionBuilder> action) => Atan(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "boolean".
             */
            public Expression Boolean(Action<ExpressionBuilder> action) => Boolean(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "case".
             */
            public Expression SwitchCase(Action<ExpressionBuilder> action) => SwitchCase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "ceil".
             */
            public Expression Ceil(Action<ExpressionBuilder> action) => Ceil(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "coalesce".
             */
            public Expression Coalesce(Action<ExpressionBuilder> action) => Coalesce(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Dsl function for "collator".
             */
            public Expression Collator(Action<CollatorBuilder> action) => Collator(new global::Com.Mapbox.Functions.Function1Action<CollatorBuilder>(action));

            /**
             * DSL function for "concat".
             */
            public Expression Concat(Action<ExpressionBuilder> action) => Concat(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "config".
             */
            public Expression Config(Action<ExpressionBuilder> action) => Config(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "cos".
             */
            public Expression Cos(Action<ExpressionBuilder> action) => Cos(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "downcase".
             */
            public Expression Downcase(Action<ExpressionBuilder> action) => Downcase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "feature-state".
             */
            public Expression FeatureState(Action<ExpressionBuilder> action) => FeatureState(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "floor".
             */
            public Expression Floor(Action<ExpressionBuilder> action) => Floor(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "format".
             */
            public Expression Format(Action<FormatBuilder> action) => Format(new global::Com.Mapbox.Functions.Function1Action<FormatBuilder>(action));

            /**
             * DSL function for "get".
             */
            public Expression Get(Action<ExpressionBuilder> action) => Get(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "has".
             */
            public Expression Has(Action<ExpressionBuilder> action) => Has(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "hsl".
             */
            public Expression Hsl(Action<ExpressionBuilder> action) => Hsl(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "hsla".
             */
            public Expression Hsla(Action<ExpressionBuilder> action) => Hsla(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "image".
             */
            public Expression Image(Action<ExpressionBuilder> action) => Image(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "in".
             */
            public Expression InExpression(Action<ExpressionBuilder> action) => InExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "index-of".
             */
            public Expression IndexOf(Action<ExpressionBuilder> action) => IndexOf(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "interpolate".
             */
            public Expression Interpolate(Action<InterpolatorBuilder> action) => Interpolate(new global::Com.Mapbox.Functions.Function1Action<InterpolatorBuilder>(action));

            /**
             * DSL function for "is-supported-script".
             */
            public Expression IsSupportedScript(Action<ExpressionBuilder> action) => IsSupportedScript(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "length".
             */
            public Expression Length(Action<ExpressionBuilder> action) => Length(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "let".
             */
            public Expression LetExpression(Action<ExpressionBuilder> action) => LetExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "ln".
             */
            public Expression Ln(Action<ExpressionBuilder> action) => Ln(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "log10".
             */
            public Expression Log10(Action<ExpressionBuilder> action) => Log10(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "log2".
             */
            public Expression Log2(Action<ExpressionBuilder> action) => Log2(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "match".
             */
            public Expression Match(Action<ExpressionBuilder> action) => Match(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "max".
             */
            public Expression Max(Action<ExpressionBuilder> action) => Max(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "measure-light".
             */
            public Expression MeasureLight(Action<ExpressionBuilder> action) => MeasureLight(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "min".
             */
            public Expression Min(Action<ExpressionBuilder> action) => Min(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "number".
             */
            public Expression Number(Action<ExpressionBuilder> action) => Number(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "number-format".
             */
            public Expression NumberFormat(Expression number, Action<NumberFormatBuilder> action) => NumberFormat(number, new global::Com.Mapbox.Functions.Function1Action<NumberFormatBuilder>(action));

            /**
             * DSL function for "object".
             */
            public Expression ObjectExpression(Action<ExpressionBuilder> action) => ObjectExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "random".
             */
            public Expression Random(Action<ExpressionBuilder> action) => Random(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "resolved-locale".
             */
            public Expression ResolvedLocale(Action<ExpressionBuilder> action) => ResolvedLocale(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "rgb".
             */
            public Expression Rgb(Action<ExpressionBuilder> action) => Rgb(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "rgba".
             */
            public Expression Rgba(Action<ExpressionBuilder> action) => Rgba(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "round".
             */
            public Expression Round(Action<ExpressionBuilder> action) => Round(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "sin".
             */
            public Expression Sin(Action<ExpressionBuilder> action) => Sin(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "slice".
             */
            public Expression Slice(Action<ExpressionBuilder> action) => Slice(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "sqrt".
             */
            public Expression Sqrt(Action<ExpressionBuilder> action) => Sqrt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "step".
             */
            public Expression Step(Action<ExpressionBuilder> action) => Step(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "string".
             */
            public Expression String(Action<ExpressionBuilder> action) => String(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "tan".
             */
            public Expression Tan(Action<ExpressionBuilder> action) => Tan(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "to-boolean".
             */
            public Expression ToBoolean(Action<ExpressionBuilder> action) => ToBoolean(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "to-color".
             */
            public Expression ToColor(Action<ExpressionBuilder> action) => ToColor(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "to-number".
             */
            public Expression ToNumber(Action<ExpressionBuilder> action) => ToNumber(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "to-rgba".
             */
            public Expression ToRgba(Action<ExpressionBuilder> action) => ToRgba(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "to-string".
             */
            public Expression ToString(Action<ExpressionBuilder> action) => ToString(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "typeof".
             */
            public Expression TypeofExpression(Action<ExpressionBuilder> action) => TypeofExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "upcase".
             */
            public Expression Upcase(Action<ExpressionBuilder> action) => Upcase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * DSL function for "var".
             */
            public Expression VarExpression(Action<ExpressionBuilder> action) => VarExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Interpolates exponentially between the stops just less than and just greater than the input.
             * `base` controls the rate at which the output increases:
             * higher values make the output increase more towards the high end of the range.
             * With values close to 1 the output increases linearly.
             */
            public Expression Exponential(Action<ExpressionBuilder> action) => Exponential(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Interpolates using the cubic bezier curve defined by the given control points.
             */
            public Expression CubicBezier(Action<ExpressionBuilder> action) => CubicBezier(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

            /**
             * Converts the input number into a string representation using the providing formatting rules. If set, the
             * `locale` argument specifies the locale to use, as a BCP 47 language tag. If set, the
             * `currency` argument specifies an ISO 4217 code to use for currency-style formatting. If set, the `min-fraction-digits`
             * and `max-fraction-digits` arguments specify the minimum and maximum number of fractional digits to include.
             */
            public Expression NumberFormat(Double value, Action<NumberFormatBuilder> action) => NumberFormat(value, new global::Com.Mapbox.Functions.Function1Action<NumberFormatBuilder>(action));
        }
    }
}

namespace Com.Mapbox.Maps.Extension.Style.Expressions.Dsl.Generated
{
    using Com.Mapbox.Maps.Extension.Style.Expressions.Generated;
    using static Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression;

    partial class ExpressionDslKt
    {

        // DSL functions for [Expression].

        /**
        * For two inputs, returns the result of subtracting the second input from the first. For a single input, returns the result of subtracting it from 0.
        */
        public static Expression Subtract(Action<ExpressionBuilder> action) => Subtract(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Logical negation. Returns `true` if the input is `false`, and `false` if the input is `true`.
        */
        public static Expression Not(Action<ExpressionBuilder> action) => Not(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns `true` if the input values are not equal, `false` otherwise. The comparison is strictly typed: values of different runtime types are always considered unequal. Cases where the types are known to be different at parse time are considered invalid and will produce a parse error. Accepts an optional `collator` argument to control locale-dependent string comparisons.
        */
        public static Expression Neq(Action<ExpressionBuilder> action) => Neq(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the product of the inputs.
        */
        public static Expression Product(Action<ExpressionBuilder> action) => Product(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the result of floating point division of the first input by the second.
        */
        public static Expression Division(Action<ExpressionBuilder> action) => Division(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the remainder after integer division of the first input by the second.
        */
        public static Expression Mod(Action<ExpressionBuilder> action) => Mod(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the result of raising the first input to the power specified by the second.
        */
        public static Expression Pow(Action<ExpressionBuilder> action) => Pow(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the sum of the inputs.
        */
        public static Expression Sum(Action<ExpressionBuilder> action) => Sum(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns `true` if the first input is strictly less than the second, `false` otherwise. The arguments are required to be either both strings or both numbers; if during evaluation they are not, expression evaluation produces an error. Cases where this constraint is known not to hold at parse time are considered in valid and will produce a parse error. Accepts an optional `collator` argument to control locale-dependent string comparisons.
        */
        public static Expression Lt(Action<ExpressionBuilder> action) => Lt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns `true` if the first input is less than or equal to the second, `false` otherwise. The arguments are required to be either both strings or both numbers; if during evaluation they are not, expression evaluation produces an error. Cases where this constraint is known not to hold at parse time are considered in valid and will produce a parse error. Accepts an optional `collator` argument to control locale-dependent string comparisons.
        */
        public static Expression Lte(Action<ExpressionBuilder> action) => Lte(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns `true` if the input values are equal, `false` otherwise. The comparison is strictly typed: values of different runtime types are always considered unequal. Cases where the types are known to be different at parse time are considered invalid and will produce a parse error. Accepts an optional `collator` argument to control locale-dependent string comparisons.
        */
        public static Expression Eq(Action<ExpressionBuilder> action) => Eq(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns `true` if the first input is strictly greater than the second, `false` otherwise. The arguments are required to be either both strings or both numbers; if during evaluation they are not, expression evaluation produces an error. Cases where this constraint is known not to hold at parse time are considered in valid and will produce a parse error. Accepts an optional `collator` argument to control locale-dependent string comparisons.
        */
        public static Expression Gt(Action<ExpressionBuilder> action) => Gt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns `true` if the first input is greater than or equal to the second, `false` otherwise. The arguments are required to be either both strings or both numbers; if during evaluation they are not, expression evaluation produces an error. Cases where this constraint is known not to hold at parse time are considered in valid and will produce a parse error. Accepts an optional `collator` argument to control locale-dependent string comparisons.
        */
        public static Expression Gte(Action<ExpressionBuilder> action) => Gte(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the absolute value of the input.
        */
        public static Expression Abs(Action<ExpressionBuilder> action) => Abs(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the arccosine of the input.
        */
        public static Expression Acos(Action<ExpressionBuilder> action) => Acos(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns `true` if all the inputs are `true`, `false` otherwise. The inputs are evaluated in order, and evaluation is short-circuiting: once an input expression evaluates to `false`, the result is `false` and no further input expressions are evaluated.
        */
        public static Expression All(Action<ExpressionBuilder> action) => All(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns `true` if any of the inputs are `true`, `false` otherwise. The inputs are evaluated in order, and evaluation is short-circuiting: once an input expression evaluates to `true`, the result is `true` and no further input expressions are evaluated.
        */
        public static Expression Any(Action<ExpressionBuilder> action) => Any(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Asserts that the input is an array (optionally with a specific item type and length). If, when the input expression is evaluated, it is not of the asserted type, then this assertion will cause the whole expression to be aborted.
        */
        public static Expression Array(Action<ExpressionBuilder> action) => Array(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the arcsine of the input.
        */
        public static Expression Asin(Action<ExpressionBuilder> action) => Asin(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Retrieves an item from an array.
        */
        public static Expression At(Action<ExpressionBuilder> action) => At(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the arctangent of the input.
        */
        public static Expression Atan(Action<ExpressionBuilder> action) => Atan(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Asserts that the input value is a boolean. If multiple values are provided, each one is evaluated in order until a boolean is obtained. If none of the inputs are booleans, the expression is an error.
        */
        public static Expression Boolean(Action<ExpressionBuilder> action) => Boolean(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Selects the first output whose corresponding test condition evaluates to true, or the fallback value otherwise.
        */
        public static Expression SwitchCase(Action<ExpressionBuilder> action) => SwitchCase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the smallest integer that is greater than or equal to the input.
        */
        public static Expression Ceil(Action<ExpressionBuilder> action) => Ceil(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Evaluates each expression in turn until the first valid value is obtained. Invalid values are `null` and [`'image'`](#types-image) expressions that are unavailable in the style. If all values are invalid, `coalesce` returns the first value listed.
        */
        public static Expression Coalesce(Action<ExpressionBuilder> action) => Coalesce(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns a `collator` for use in locale-dependent comparison operations. The `case-sensitive` and `diacritic-sensitive` options default to `false`. The `locale` argument specifies the IETF language tag of the locale to use. If none is provided, the default locale is used. If the requested locale is not available, the `collator` will use a system-defined fallback locale. Use `resolved-locale` to test the results of locale fallback behavior.
        */
        public static Expression Collator(Action<CollatorBuilder> action) => Collator(new global::Com.Mapbox.Functions.Function1Action<CollatorBuilder>(action));

        /**
        * Returns a `string` consisting of the concatenation of the inputs. Each input is converted to a string as if by `to-string`.
        */
        public static Expression Concat(Action<ExpressionBuilder> action) => Concat(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Retrieves the configuration value for the given option.
        */
        public static Expression Config(Action<ExpressionBuilder> action) => Config(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the cosine of the input.
        */
        public static Expression Cos(Action<ExpressionBuilder> action) => Cos(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the input string converted to lowercase. Follows the Unicode Default Case Conversion algorithm and the locale-insensitive case mappings in the Unicode Character Database.
        */
        public static Expression Downcase(Action<ExpressionBuilder> action) => Downcase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Retrieves a property value from the current feature's state. Returns `null` if the requested property is not present on the feature's state. A feature's state is not part of the GeoJSON or vector tile data, and must be set programmatically on each feature. Features are identified by their `id` attribute, which must be an integer or a string that can be cast to an integer. Note that ["feature-state"] can only be used with paint properties that support data-driven styling.
        */
        public static Expression FeatureState(Action<ExpressionBuilder> action) => FeatureState(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the largest integer that is less than or equal to the input.
        */
        public static Expression Floor(Action<ExpressionBuilder> action) => Floor(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns a `formatted` string for displaying mixed-format text in the `text-field` property. The input may contain a string literal or expression, including an [`'image'`](#types-image) expression. Strings may be followed by a style override object that supports the following properties:
        - `"text-font"`: Overrides the font stack specified by the root layout property.
        - `"text-color"`: Overrides the color specified by the root paint property.
        - `"font-scale"`: Applies a scaling factor on `text-size` as specified by the root layout property.
        */
        public static Expression Format(Action<FormatBuilder> action) => Format(new global::Com.Mapbox.Functions.Function1Action<FormatBuilder>(action));

        /**
        * Retrieves a property value from the current feature's properties, or from another object if a second argument is provided. Returns `null` if the requested property is missing.
        */
        public static Expression Get(Action<ExpressionBuilder> action) => Get(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Tests for the presence of an property value in the current feature's properties, or from another object if a second argument is provided.
        */
        public static Expression Has(Action<ExpressionBuilder> action) => Has(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Creates a color value from hue (range 0-360), saturation and lightness components (range 0-100), and an alpha component of 1. If any component is out of range, the expression is an error.
        */
        public static Expression Hsl(Action<ExpressionBuilder> action) => Hsl(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Creates a color value from hue (range 0-360), saturation and lightness components (range 0-100), and an alpha component (range 0-1). If any component is out of range, the expression is an error.
        */
        public static Expression Hsla(Action<ExpressionBuilder> action) => Hsla(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns a [`ResolvedImage`](/mapbox-gl-js/style-spec/types/#resolvedimage) for use in [`icon-image`](/mapbox-gl-js/style-spec/layers/#layout-symbol-icon-image), `*-pattern` entries, and as a section in the [`'format'`](#types-format) expression. A [`'coalesce'`](#coalesce) expression containing `image` expressions will evaluate to the first listed image that is currently in the style. This validation process is synchronous and requires the image to have been added to the style before requesting it in the `'image'` argument.
        */
        public static Expression Image(Action<ExpressionBuilder> action) => Image(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Determines whether an item exists in an array or a substring exists in a string. In the specific case when the second and third arguments are string literals, you must wrap at least one of them in a [`literal`](#types-literal) expression to hint correct interpretation to the [type system](#type-system).
        */
        public static Expression InExpression(Action<ExpressionBuilder> action) => InExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the first position at which an item can be found in an array or a substring can be found in a string, or `-1` if the input cannot be found. Accepts an optional index from where to begin the search.
        */
        public static Expression IndexOf(Action<ExpressionBuilder> action) => IndexOf(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Produces continuous, smooth results by interpolating between pairs of input and output values ("stops"). The `input` may be any numeric expression (e.g., `["get", "population"]`). Stop inputs must be numeric literals in strictly ascending order. The output type must be `number`, `array<number>`, or `color`.

        Interpolation types:
        - `["linear"]`: Interpolates linearly between the pair of stops just less than and just greater than the input.
        - `["exponential", base]`: Interpolates exponentially between the stops just less than and just greater than the input. `base` controls the rate at which the output increases: higher values make the output increase more towards the high end of the range. With values close to 1 the output increases linearly.
        - `["cubic-bezier", x1, y1, x2, y2]`: Interpolates using the cubic bezier curve defined by the given control points.
        */
        public static Expression Interpolate(Action<InterpolatorBuilder> action) => Interpolate(new global::Com.Mapbox.Functions.Function1Action<InterpolatorBuilder>(action));

        /**
        * Returns `true` if the input string is expected to render legibly. Returns `false` if the input string contains sections that cannot be rendered without potential loss of meaning (e.g. Indic scripts that require complex text shaping, or right-to-left scripts if the the `mapbox-gl-rtl-text` plugin is not in use in Mapbox GL JS).
        */
        public static Expression IsSupportedScript(Action<ExpressionBuilder> action) => IsSupportedScript(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the length of an array or string.
        */
        public static Expression Length(Action<ExpressionBuilder> action) => Length(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Binds expressions to named variables, which can then be referenced in the result expression using ["var", "variable_name"].
        */
        public static Expression LetExpression(Action<ExpressionBuilder> action) => LetExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the natural logarithm of the input.
        */
        public static Expression Ln(Action<ExpressionBuilder> action) => Ln(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the base-ten logarithm of the input.
        */
        public static Expression Log10(Action<ExpressionBuilder> action) => Log10(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the base-two logarithm of the input.
        */
        public static Expression Log2(Action<ExpressionBuilder> action) => Log2(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Selects the output for which the label value matches the input value, or the fallback value if no match is found. The input can be any expression (for example, `["get", "building_type"]`). Each label must be unique, and must be either:
        - a single literal value; or
        - an array of literal values, the values of which must be all strings or all numbers (for example `[100, 101]` or `["c", "b"]`).

        The input matches if any of the values in the array matches using strict equality, similar to the `"in"` operator.
        If the input type does not match the type of the labels, the result will be the fallback value.
        */
        public static Expression Match(Action<ExpressionBuilder> action) => Match(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the maximum value of the inputs.
        */
        public static Expression Max(Action<ExpressionBuilder> action) => Max(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns a requested property of the light configuration based on the supplied options. Currently the only supported option is `brightness` which returns the global brightness value of the lights on a scale of 0 to 1, where 0 means total darkness and 1 means full brightness. This expression works only with 3D light, i.e. when `lights` root property is defined.
        */
        public static Expression MeasureLight(Action<ExpressionBuilder> action) => MeasureLight(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the minimum value of the inputs.
        */
        public static Expression Min(Action<ExpressionBuilder> action) => Min(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Asserts that the input value is a number. If multiple values are provided, each one is evaluated in order until a number is obtained. If none of the inputs are numbers, the expression is an error.
        */
        public static Expression Number(Action<ExpressionBuilder> action) => Number(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Converts the input number into a string representation using the providing formatting rules. If set, the `locale` argument specifies the locale to use, as a BCP 47 language tag. If set, the `currency` argument specifies an ISO 4217 code to use for currency-style formatting. If set, the `unit` argument specifies a [simple ECMAScript unit](https://tc39.es/proposal-unified-intl-numberformat/section6/locales-currencies-tz_proposed_out.html#sec-issanctionedsimpleunitidentifier) to use for unit-style formatting. If set, the `min-fraction-digits` and `max-fraction-digits` arguments specify the minimum and maximum number of fractional digits to include.
        */
        public static Expression NumberFormat(Expression input, Action<NumberFormatBuilder> action) => NumberFormat(input, new global::Com.Mapbox.Functions.Function1Action<NumberFormatBuilder>(action));

        /**
        * Asserts that the input value is an object. If multiple values are provided, each one is evaluated in order until an object is obtained. If none of the inputs are objects, the expression is an error.
        */
        public static Expression ObjectExpression(Action<ExpressionBuilder> action) => ObjectExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns a random value in the specified range (first two input numbers) based on a supplied seed (third input). The seed can be an expression or a constant number or string value.
        */
        public static Expression Random(Action<ExpressionBuilder> action) => Random(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the IETF language tag of the locale being used by the provided `collator`. This can be used to determine the default system locale, or to determine if a requested locale was successfully loaded.
        */
        public static Expression ResolvedLocale(Action<ExpressionBuilder> action) => ResolvedLocale(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Creates a color value from red, green, and blue components, which must range between 0 and 255, and an alpha component of 1. If any component is out of range, the expression is an error.
        */
        public static Expression Rgb(Action<ExpressionBuilder> action) => Rgb(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Creates a color value from red, green, blue components, which must range between 0 and 255, and an alpha component which must range between 0 and 1. If any component is out of range, the expression is an error.
        */
        public static Expression Rgba(Action<ExpressionBuilder> action) => Rgba(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Rounds the input to the nearest integer. Halfway values are rounded away from zero. For example, `["round", -1.5]` evaluates to -2.
        */
        public static Expression Round(Action<ExpressionBuilder> action) => Round(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the sine of the input.
        */
        public static Expression Sin(Action<ExpressionBuilder> action) => Sin(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns an item from an array or a substring from a string from a specified start index, or between a start index and an end index if set. The return value is inclusive of the start index but not of the end index.
        */
        public static Expression Slice(Action<ExpressionBuilder> action) => Slice(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the square root of the input.
        */
        public static Expression Sqrt(Action<ExpressionBuilder> action) => Sqrt(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Produces discrete, stepped results by evaluating a piecewise-constant function defined by pairs of input and output values ("stops"). The `input` may be any numeric expression (e.g., `["get", "population"]`). Stop inputs must be numeric literals in strictly ascending order. Returns the output value of the stop just less than the input, or the first output if the input is less than the first stop.
        */
        public static Expression Step(Action<ExpressionBuilder> action) => Step(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Asserts that the input value is a string. If multiple values are provided, each one is evaluated in order until a string is obtained. If none of the inputs are strings, the expression is an error.
        */
        public static Expression String(Action<ExpressionBuilder> action) => String(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the tangent of the input.
        */
        public static Expression Tan(Action<ExpressionBuilder> action) => Tan(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Converts the input value to a boolean. The result is `false` when then input is an empty string, 0, `false`, `null`, or `NaN`; otherwise it is `true`.
        */
        public static Expression ToBoolean(Action<ExpressionBuilder> action) => ToBoolean(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Converts the input value to a color. If multiple values are provided, each one is evaluated in order until the first successful conversion is obtained. If none of the inputs can be converted, the expression is an error.
        */
        public static Expression ToColor(Action<ExpressionBuilder> action) => ToColor(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Converts the input value to a number, if possible. If the input is `null` or `false`, the result is 0. If the input is `true`, the result is 1. If the input is a string, it is converted to a number as specified by the ["ToNumber Applied to the String Type" algorithm](https://tc39.github.io/ecma262/#sec-tonumber-applied-to-the-string-type) of the ECMAScript Language Specification. If multiple values are provided, each one is evaluated in order until the first successful conversion is obtained. If none of the inputs can be converted, the expression is an error.
        */
        public static Expression ToNumber(Action<ExpressionBuilder> action) => ToNumber(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns a four-element array containing the input color's red, green, blue, and alpha components, in that order.
        */
        public static Expression ToRgba(Action<ExpressionBuilder> action) => ToRgba(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Converts the input value to a string. If the input is `null`, the result is `""`. If the input is a [`boolean`](#types-boolean), the result is `"true"` or `"false"`. If the input is a number, it is converted to a string as specified by the ["NumberToString" algorithm](https://tc39.github.io/ecma262/#sec-tostring-applied-to-the-number-type) of the ECMAScript Language Specification. If the input is a [`color`](#color), it is converted to a string of the form `"rgba(r,g,b,a)"`, where `r`, `g`, and `b` are numerals ranging from 0 to 255, and `a` ranges from 0 to 1. If the input is an [`'image'`](#types-image) expression, `'to-string'` returns the image name. Otherwise, the input is converted to a string in the format specified by the [`JSON.stringify`](https://tc39.github.io/ecma262/#sec-json.stringify) function of the ECMAScript Language Specification.
        */
        public static Expression ToString(Action<ExpressionBuilder> action) => ToString(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns a string describing the type of the given value.
        */
        public static Expression TypeofExpression(Action<ExpressionBuilder> action) => TypeofExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * Returns the input string converted to uppercase. Follows the Unicode Default Case Conversion algorithm and the locale-insensitive case mappings in the Unicode Character Database.
        */
        public static Expression Upcase(Action<ExpressionBuilder> action) => Upcase(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        /**
        * References variable bound using "let".
        */
        public static Expression VarExpression(Action<ExpressionBuilder> action) => VarExpression(new global::Com.Mapbox.Functions.Function1Action<ExpressionBuilder>(action));

        // End of generated file.
    }
}

namespace Com.Mapbox.Maps.Extension.Style.Layers.Properties
{
    using System;
    using System.Collections.Generic;
    using Java.Interop;

    partial class PropertyValue
    {
        [Register("getValue", "()Lcom/mapbox/bindgen/Value;", "")]
        public unsafe global::Com.Mapbox.Bindgen.Value GetBindGenValue()
        {
            const string __id = "getValue.()Lcom/mapbox/bindgen/Value;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Bindgen.Value>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        [Register("getValue", "()Ljava/lang/Object;", "")]
        public unsafe global::Java.Lang.Object GetValue()
        {
            const string __id = "getValue.()Ljava/lang/Object;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
                return (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}
namespace Com.Mapbox.Maps.Extension.Style
{
    using System.Collections.Generic;
    using System.Linq;
    using Com.Mapbox.Maps;
    using Kotlin;

    partial class StyleExtensionImpl : global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension
    {
        public IStyleContract.IStyleAtmosphereExtension Atmosphere => GetAtmosphere();

        public IList<IStyleContract.IStyleImageExtension> Images => GetImages();

        public IList<Pair> Layers => GetLayers();

        public IStyleContract.IStyleProjectionExtension Projection => GetProjection();

        public IList<IStyleContract.IStyleSourceExtension> Sources => GetSources()
            .Cast<IStyleContract.IStyleSourceExtension>()
            .ToArray();

        public IStyleContract.IStyleTerrainExtension Terrain => GetTerrain();

        public global::System.Collections.Generic.IList<global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleModelExtension> Models => GetModels();

        public IStyleContract.IStyleLightExtension DynamicLight => GetDynamicLight();

        public IStyleContract.IStyleLightExtension FlatLight => GetFlatLight();

        public string Style => GetStyle();

        public TransitionOptions Transition => GetTransition();
    }
}

namespace Com.Mapbox.Maps.Extension.Style.Layers.Generated
{
    partial class BackgroundLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class ModelLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class HeatmapLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class CircleLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class FillExtrusionLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class HillshadeLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class FillLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class SkyLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class RasterLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class LineLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class LocationIndicatorLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
    partial class SymbolLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
}
namespace Com.Mapbox.Maps.Extension.Style.Layers
{
    partial class CustomLayer
    {
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Slot(string slot)
        {
            return SetSlot(slot);
        }
        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MaxZoom(double maxZoom)
        {
            return SetMaxZoom(maxZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer MinZoom(double minZoom)
        {
            return SetMinZoom(minZoom);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility visibility)
        {
            return SetVisibility(visibility);
        }

        public override unsafe global::Com.Mapbox.Maps.Extension.Style.Layers.Layer Visibility(global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression visibility)
        {
            return SetVisibility(visibility);
        }
    }
}