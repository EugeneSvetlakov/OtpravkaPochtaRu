﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Request.AddressRequest;
//
//    var addressRequest = AddressRequest.FromJson(jsonString);

namespace Request.AddressRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Класс Исходные данные для Нормализации адреса
    /// </summary>
    public partial class AddressRequest
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Оригинальные адрес одной строкой
        /// </summary>
        [JsonProperty("original-address")]
        public string OriginalAddress { get; set; }
    }

    public partial class AddressRequest
    {
        public static AddressRequest[] FromJson(string json) => JsonConvert.DeserializeObject<AddressRequest[]>(json, Request.AddressRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AddressRequest[] self) => JsonConvert.SerializeObject(self, Request.AddressRequest.Converter.Settings);
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
