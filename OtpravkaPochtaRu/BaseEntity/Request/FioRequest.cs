﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Request.FioRequest;
//
//    var fioRequest = FioRequest.FromJson(jsonString);

namespace Request.FioRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FioRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("original-fio")]
        public string OriginalFio { get; set; }
    }

    public partial class FioRequest
    {
        public static FioRequest[] FromJson(string json) => JsonConvert.DeserializeObject<FioRequest[]>(json, Request.FioRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FioRequest[] self) => JsonConvert.SerializeObject(self, Request.FioRequest.Converter.Settings);
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