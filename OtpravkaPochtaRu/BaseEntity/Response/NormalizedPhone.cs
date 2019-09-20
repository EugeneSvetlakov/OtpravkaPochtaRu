﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Response.NormalizedPhone;
//
//    var normalizedPhone = NormalizedPhone.FromJson(jsonString);

namespace Response.NormalizedPhone
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Класс результат "Нормализация Телефонного номера"
    /// </summary>
    public partial class NormalizedPhone
    {
        /// <summary>
        /// Идентификатор исходной записи
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Оригинальные номер одной строкой
        /// </summary>
        [JsonProperty("original-phone", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalPhone { get; set; }

        /// <summary>
        /// Оригинальные номер одной строкой
        /// </summary>
        [JsonProperty("phone-city-code", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneCityCode { get; set; }

        /// <summary>
        /// Код страны
        /// </summary>
        [JsonProperty("phone-country-code", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneCountryCode { get; set; }

        /// <summary>
        /// Добавочный номер
        /// </summary>
        [JsonProperty("phone-extension", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneExtension { get; set; }

        /// <summary>
        /// Телефонный номер
        /// </summary>
        [JsonProperty("phone-number", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Код качества нормализации телефона: "CONFIRMED_MANUALLY","GOOD",...
        /// см. https://otpravka.pochta.ru/specification#/enums-clean-fio-phone-quality
        /// </summary>
        [JsonProperty("quality-code", NullValueHandling = NullValueHandling.Ignore)]
        public string QualityCode { get; set; }
    }

    public partial class NormalizedPhone
    {
        public static NormalizedPhone[] FromJson(string json) => JsonConvert.DeserializeObject<NormalizedPhone[]>(json, Response.NormalizedPhone.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NormalizedPhone[] self) => JsonConvert.SerializeObject(self, Response.NormalizedPhone.Converter.Settings);
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
