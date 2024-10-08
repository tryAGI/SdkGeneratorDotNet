﻿// using System;
// using System.Text.Json;
// using System.Text.Json.Serialization;
//
// namespace AutoSDK.JsonConverters;
//
// /// <summary>
// /// https://github.com/dotnet/runtime/issues/74385#issuecomment-1456725149
// /// </summary>
// internal sealed class JsonStringEnumConverterFactory : JsonConverterFactory
// {
//     public override bool CanConvert(Type typeToConvert)
//         => typeToConvert.IsEnum;
//
//     public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
//         => (JsonConverter)Activator.CreateInstance(typeof(JsonStringEnumConverter<>).MakeGenericType(typeToConvert))!;
// }