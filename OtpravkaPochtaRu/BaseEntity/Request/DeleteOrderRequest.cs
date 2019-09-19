﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Request.DeleteOrderRequest;
//
//    var deleteOrderRequest = DeleteOrderRequest.FromJson(jsonString);

namespace Request.DeleteOrderRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class DeleteOrderRequest
    {
        public static long[] FromJson(string json) => JsonConvert.DeserializeObject<long[]>(json, Request.DeleteOrderRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this long[] self) => JsonConvert.SerializeObject(self, Request.DeleteOrderRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
