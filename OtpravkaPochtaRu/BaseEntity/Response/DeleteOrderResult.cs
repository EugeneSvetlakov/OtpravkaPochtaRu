﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Response.DeleteOrderResult;
//
//    var deleteOrderResult = DeleteOrderResult.FromJson(jsonString);

namespace Response.DeleteOrderResult
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Класс "результат удаления заказа(отправления)
    /// </summary>
    public partial class DeleteOrderResult
    {
        /// <summary>
        /// Массив ошибок
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public Error[] Errors { get; set; }

        /// <summary>
        /// Id удаленных заказов(отправлений)
        /// </summary>
        [JsonProperty("result-ids", NullValueHandling = NullValueHandling.Ignore)]
        public long[] ResultIds { get; set; }
    }

    /// <summary>
    /// Класс "ошибки при удалении заказа(отправления)"
    /// </summary>
    public partial class Error
    {
        /// <summary>
        /// Код ошибки
        /// </summary>
        [JsonProperty("error-code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Подробности
        /// </summary>
        [JsonProperty("error-details", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Порядковый номер элемента в массиве DeleteOrderRequest[]
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public long? Position { get; set; }
    }

    public partial class DeleteOrderResult
    {
        public static DeleteOrderResult FromJson(string json) => JsonConvert.DeserializeObject<DeleteOrderResult>(json, Response.DeleteOrderResult.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DeleteOrderResult self) => JsonConvert.SerializeObject(self, Response.DeleteOrderResult.Converter.Settings);
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
