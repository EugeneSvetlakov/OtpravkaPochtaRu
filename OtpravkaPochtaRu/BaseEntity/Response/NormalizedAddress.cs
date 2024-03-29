﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Response.NormalizedAddress;
//
//    var normalizedAddress = NormalizedAddress.FromJson(jsonString);

namespace Response.NormalizedAddress
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Класс "результат Нормализации адреса"
    /// Анализируйте код качества (quality-code) и код проверки (validation-code) в ответах.
    /// Код качества должен быть: GOOD, POSTAL_BOX, ON_DEMAND или UNDEF_05.
    /// Код проверки должен быть: VALIDATED, OVERRIDDEN или CONFIRMED_MANUALLY.
    /// Иначе нормализуемый адрес может быть неприемлем для доставки!
    /// </summary>
    public partial class NormalizedAddress
    {
        /// <summary>
        /// Тип адреса: "DEFAULT",...
        /// см. https://otpravka.pochta.ru/specification#/enums-base-address-type
        /// </summary>
        [JsonProperty("address-type", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressType { get; set; }

        /// <summary>
        /// Район (Опционально)
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// Часть здания: Строение (Опционально)
        /// </summary>
        [JsonProperty("building", NullValueHandling = NullValueHandling.Ignore)]
        public string Building { get; set; }

        /// <summary>
        /// Часть здания: Корпус (Опционально)
        /// </summary>
        [JsonProperty("corpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Corpus { get; set; }

        /// <summary>
        /// Название гостиницы (Опционально)
        /// </summary>
        [JsonProperty("hotel", NullValueHandling = NullValueHandling.Ignore)]
        public string Hotel { get; set; }

        /// <summary>
        /// Часть адреса: Номер здания (Опционально)
        /// </summary>
        [JsonProperty("house", NullValueHandling = NullValueHandling.Ignore)]
        public string House { get; set; }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Почтовый индекс
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public string Index { get; set; }

        /// <summary>
        /// Часть здания: Литера (Опционально)
        /// </summary>
        [JsonProperty("letter", NullValueHandling = NullValueHandling.Ignore)]
        public string Letter { get; set; }

        /// <summary>
        /// Микрорайон (Опционально)
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// Номер для а/я, войсковая часть, войсковая часть ЮЯ, полевая почта (Опционально)
        /// </summary>
        [JsonProperty("num-address-type", NullValueHandling = NullValueHandling.Ignore)]
        public string NumAddressType { get; set; }

        /// <summary>
        /// Оригинальные адрес одной строкой
        /// </summary>
        [JsonProperty("original-address", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAddress { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        [JsonProperty("place", NullValueHandling = NullValueHandling.Ignore)]
        public string Place { get; set; }

        /// <summary>
        /// Код качества нормализации адреса: "GOOD",...
        /// см. https://otpravka.pochta.ru/specification#/enums-clean-address-quality
        /// </summary>
        [JsonProperty("quality-code", NullValueHandling = NullValueHandling.Ignore)]
        public string QualityCode { get; set; }

        /// <summary>
        /// Область, регион
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Часть здания: Номер помещения (Опционально)
        /// </summary>
        [JsonProperty("room", NullValueHandling = NullValueHandling.Ignore)]
        public string Room { get; set; }

        /// <summary>
        /// Часть здания: Дробь (Опционально)
        /// </summary>
        [JsonProperty("slash", NullValueHandling = NullValueHandling.Ignore)]
        public string Slash { get; set; }

        /// <summary>
        /// Часть адреса: Улица (Опционально)
        /// </summary>
        [JsonProperty("street", NullValueHandling = NullValueHandling.Ignore)]
        public string Street { get; set; }

        /// <summary>
        /// Код проверки нормализации адреса: "CONFIRMED_MANUALLY",...
        /// см. https://otpravka.pochta.ru/specification#/enums-clean-address-validation
        /// </summary>
        [JsonProperty("validation-code", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationCode { get; set; }
    }

    public partial class NormalizedAddress
    {
        public static NormalizedAddress[] FromJson(string json) => JsonConvert.DeserializeObject<NormalizedAddress[]>(json, Response.NormalizedAddress.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NormalizedAddress[] self) => JsonConvert.SerializeObject(self, Response.NormalizedAddress.Converter.Settings);
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
