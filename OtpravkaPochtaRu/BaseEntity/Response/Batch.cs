﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Response.Batch;
//
//    var batch = Batch.FromJson(jsonString);

namespace Response.Batch
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Batch
    {
        [JsonProperty("batch-name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        [JsonProperty("batch-status", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchStatus { get; set; }

        [JsonProperty("batch-status-date", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchStatusDate { get; set; }

        [JsonProperty("combined-batch-mail-types", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CombinedBatchMailTypes { get; set; }

        [JsonProperty("courier-call-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? CourierCallRateWithVat { get; set; }

        [JsonProperty("courier-call-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? CourierCallRateWoVat { get; set; }

        [JsonProperty("courier-order-statuses", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CourierOrderStatuses { get; set; }

        [JsonProperty("delivery-notice-payment-method", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryNoticePaymentMethod { get; set; }

        [JsonProperty("international", NullValueHandling = NullValueHandling.Ignore)]
        public bool? International { get; set; }

        [JsonProperty("list-number", NullValueHandling = NullValueHandling.Ignore)]
        public long? ListNumber { get; set; }

        [JsonProperty("list-number-date", NullValueHandling = NullValueHandling.Ignore)]
        public string ListNumberDate { get; set; }

        [JsonProperty("mail-category", NullValueHandling = NullValueHandling.Ignore)]
        public string MailCategory { get; set; }

        [JsonProperty("mail-category-text", NullValueHandling = NullValueHandling.Ignore)]
        public string MailCategoryText { get; set; }

        [JsonProperty("mail-rank", NullValueHandling = NullValueHandling.Ignore)]
        public string MailRank { get; set; }

        [JsonProperty("mail-type", NullValueHandling = NullValueHandling.Ignore)]
        public string MailType { get; set; }

        [JsonProperty("mail-type-text", NullValueHandling = NullValueHandling.Ignore)]
        public string MailTypeText { get; set; }

        [JsonProperty("notice-payment-method", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticePaymentMethod { get; set; }

        [JsonProperty("payment-method", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethod { get; set; }

        [JsonProperty("postmarks", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Postmarks { get; set; }

        [JsonProperty("postoffice-address", NullValueHandling = NullValueHandling.Ignore)]
        public string PostofficeAddress { get; set; }

        [JsonProperty("postoffice-code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostofficeCode { get; set; }

        [JsonProperty("postoffice-name", NullValueHandling = NullValueHandling.Ignore)]
        public string PostofficeName { get; set; }

        [JsonProperty("shipment-avia-rate-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentAviaRateSum { get; set; }

        [JsonProperty("shipment-avia-rate-vat-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentAviaRateVatSum { get; set; }

        [JsonProperty("shipment-completeness-checking-rate-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentCompletenessCheckingRateSum { get; set; }

        [JsonProperty("shipment-completeness-checking-rate-vat-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentCompletenessCheckingRateVatSum { get; set; }

        [JsonProperty("shipment-count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentCount { get; set; }

        [JsonProperty("shipment-ground-rate-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentGroundRateSum { get; set; }

        [JsonProperty("shipment-ground-rate-vat-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentGroundRateVatSum { get; set; }

        [JsonProperty("shipment-insure-rate-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentInsureRateSum { get; set; }

        [JsonProperty("shipment-insure-rate-vat-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentInsureRateVatSum { get; set; }

        [JsonProperty("shipment-inventory-rate-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentInventoryRateSum { get; set; }

        [JsonProperty("shipment-inventory-rate-vat-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentInventoryRateVatSum { get; set; }

        [JsonProperty("shipment-mass", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentMass { get; set; }

        [JsonProperty("shipment-mass-rate-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentMassRateSum { get; set; }

        [JsonProperty("shipment-mass-rate-vat-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentMassRateVatSum { get; set; }

        [JsonProperty("shipment-notice-rate-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentNoticeRateSum { get; set; }

        [JsonProperty("shipment-notice-rate-vat-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentNoticeRateVatSum { get; set; }

        [JsonProperty("shipment-sms-notice-rate-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentSmsNoticeRateSum { get; set; }

        [JsonProperty("shipment-sms-notice-rate-vat-sum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipmentSmsNoticeRateVatSum { get; set; }

        [JsonProperty("shipping-notice-type", NullValueHandling = NullValueHandling.Ignore)]
        public string ShippingNoticeType { get; set; }

        [JsonProperty("transport-type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransportType { get; set; }

        [JsonProperty("use-online-balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseOnlineBalance { get; set; }

        [JsonProperty("wo-mass", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WoMass { get; set; }
    }

    public partial class Batch
    {
        public static Batch[] FromJson(string json) => JsonConvert.DeserializeObject<Batch[]>(json, Response.Batch.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Batch[] self) => JsonConvert.SerializeObject(self, Response.Batch.Converter.Settings);
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
