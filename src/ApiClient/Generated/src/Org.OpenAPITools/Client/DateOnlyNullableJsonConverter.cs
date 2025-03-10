/*
 * Sample API
 *
 * This is a sample API for demonstration purposes.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class DateOnlyNullableJsonConverter : JsonConverter<DateOnly?>
    {
        /// <summary>
        /// The formats used to deserialize the date
        /// </summary>
        public static string[] Formats { get; } = {
            "yyyy'-'MM'-'dd",
            "yyyyMMdd"

        };

        /// <summary>
        /// Returns a DateOnly from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            string value = reader.GetString()!;

            foreach(string format in Formats)
                if (DateOnly.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out DateOnly result))
                    return result;

            throw new NotSupportedException();
        }

        /// <summary>
        /// Writes the DateOnly to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dateOnlyValue"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, DateOnly? dateOnlyValue, JsonSerializerOptions options)
        {
            if (dateOnlyValue == null)
                writer.WriteNullValue();
            else
                writer.WriteStringValue(dateOnlyValue.Value.ToString("yyyy'-'MM'-'dd", CultureInfo.InvariantCulture));
        }
    }
}
