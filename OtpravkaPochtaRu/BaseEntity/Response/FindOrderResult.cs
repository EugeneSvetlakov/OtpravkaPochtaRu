﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using NameSpaceFindOrderResult;
//
//    var findOrderResult = FindOrderResult.FromJson(jsonString);

namespace Response.FindOrderResult
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FindOrderResult
    {
        [JsonProperty("address-changed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddressChanged { get; set; }

        [JsonProperty("address-type-to", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressTypeTo { get; set; }

        [JsonProperty("area-to", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaTo { get; set; }

        [JsonProperty("avia-rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? AviaRate { get; set; }

        [JsonProperty("avia-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? AviaRateWithVat { get; set; }

        [JsonProperty("avia-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? AviaRateWoVat { get; set; }

        [JsonProperty("barcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Barcode { get; set; }

        [JsonProperty("batch-category", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchCategory { get; set; }

        [JsonProperty("batch-name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        [JsonProperty("batch-status", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchStatus { get; set; }

        [JsonProperty("building-to", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingTo { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        [JsonProperty("completeness-checking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CompletenessChecking { get; set; }

        [JsonProperty("completeness-checking-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletenessCheckingRateWithVat { get; set; }

        [JsonProperty("completeness-checking-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletenessCheckingRateWoVat { get; set; }

        [JsonProperty("corpus-to", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpusTo { get; set; }

        [JsonProperty("customs-declaration", NullValueHandling = NullValueHandling.Ignore)]
        public CustomsDeclaration CustomsDeclaration { get; set; }

        [JsonProperty("delivery-time", NullValueHandling = NullValueHandling.Ignore)]
        public DeliveryTime DeliveryTime { get; set; }

        [JsonProperty("delivery-with-cod", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeliveryWithCod { get; set; }

        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public Dimension Dimension { get; set; }

        [JsonProperty("envelope-type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvelopeType { get; set; }

        [JsonProperty("fragile-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? FragileRateWithVat { get; set; }

        [JsonProperty("fragile-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? FragileRateWoVat { get; set; }

        [JsonProperty("given-name", NullValueHandling = NullValueHandling.Ignore)]
        public string GivenName { get; set; }

        [JsonProperty("goods", NullValueHandling = NullValueHandling.Ignore)]
        public Goods Goods { get; set; }

        [JsonProperty("ground-rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? GroundRate { get; set; }

        [JsonProperty("ground-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? GroundRateWithVat { get; set; }

        [JsonProperty("ground-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? GroundRateWoVat { get; set; }

        [JsonProperty("hotel-to", NullValueHandling = NullValueHandling.Ignore)]
        public string HotelTo { get; set; }

        [JsonProperty("house-to", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseTo { get; set; }

        [JsonProperty("human-operation-name", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanOperationName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("index-to", NullValueHandling = NullValueHandling.Ignore)]
        public long? IndexTo { get; set; }

        [JsonProperty("insr-rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsrRate { get; set; }

        [JsonProperty("insr-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsrRateWithVat { get; set; }

        [JsonProperty("insr-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsrRateWoVat { get; set; }

        [JsonProperty("insr-value", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsrValue { get; set; }

        [JsonProperty("inventory-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? InventoryRateWithVat { get; set; }

        [JsonProperty("inventory-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? InventoryRateWoVat { get; set; }

        [JsonProperty("is-deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleted { get; set; }

        [JsonProperty("last-oper-attr", NullValueHandling = NullValueHandling.Ignore)]
        public string LastOperAttr { get; set; }

        [JsonProperty("last-oper-type", NullValueHandling = NullValueHandling.Ignore)]
        public string LastOperType { get; set; }

        [JsonProperty("legal-hid", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalHid { get; set; }

        [JsonProperty("letter-to", NullValueHandling = NullValueHandling.Ignore)]
        public string LetterTo { get; set; }

        [JsonProperty("location-to", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationTo { get; set; }

        [JsonProperty("mail-category", NullValueHandling = NullValueHandling.Ignore)]
        public string MailCategory { get; set; }

        [JsonProperty("mail-direct", NullValueHandling = NullValueHandling.Ignore)]
        public long? MailDirect { get; set; }

        [JsonProperty("mail-rank", NullValueHandling = NullValueHandling.Ignore)]
        public string MailRank { get; set; }

        [JsonProperty("mail-type", NullValueHandling = NullValueHandling.Ignore)]
        public string MailType { get; set; }

        [JsonProperty("manual-address-input", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManualAddressInput { get; set; }

        [JsonProperty("mass", NullValueHandling = NullValueHandling.Ignore)]
        public long? Mass { get; set; }

        [JsonProperty("mass-rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? MassRate { get; set; }

        [JsonProperty("mass-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? MassRateWithVat { get; set; }

        [JsonProperty("mass-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? MassRateWoVat { get; set; }

        [JsonProperty("middle-name", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        [JsonProperty("notice-payment-method", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticePaymentMethod { get; set; }

        [JsonProperty("notice-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? NoticeRateWithVat { get; set; }

        [JsonProperty("notice-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? NoticeRateWoVat { get; set; }

        [JsonProperty("num-address-type-to", NullValueHandling = NullValueHandling.Ignore)]
        public string NumAddressTypeTo { get; set; }

        [JsonProperty("office-to", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficeTo { get; set; }

        [JsonProperty("online-payment-mark", NullValueHandling = NullValueHandling.Ignore)]
        public OnlinePaymentMark OnlinePaymentMark { get; set; }

        [JsonProperty("order-num", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNum { get; set; }

        [JsonProperty("oversize-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? OversizeRateWithVat { get; set; }

        [JsonProperty("oversize-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? OversizeRateWoVat { get; set; }

        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public long? Payment { get; set; }

        [JsonProperty("payment-method", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethod { get; set; }

        [JsonProperty("place-to", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceTo { get; set; }

        [JsonProperty("pochtaid-hid", NullValueHandling = NullValueHandling.Ignore)]
        public string PochtaidHid { get; set; }

        [JsonProperty("postmarks", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Postmarks { get; set; }

        [JsonProperty("postoffice-code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostofficeCode { get; set; }

        [JsonProperty("raw-address", NullValueHandling = NullValueHandling.Ignore)]
        public string RawAddress { get; set; }

        [JsonProperty("recipient-name", NullValueHandling = NullValueHandling.Ignore)]
        public string RecipientName { get; set; }

        [JsonProperty("region-to", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionTo { get; set; }

        [JsonProperty("room-to", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomTo { get; set; }

        [JsonProperty("slash-to", NullValueHandling = NullValueHandling.Ignore)]
        public string SlashTo { get; set; }

        [JsonProperty("sms-notice-recipient", NullValueHandling = NullValueHandling.Ignore)]
        public long? SmsNoticeRecipient { get; set; }

        [JsonProperty("sms-notice-recipient-rate-with-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? SmsNoticeRecipientRateWithVat { get; set; }

        [JsonProperty("sms-notice-recipient-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? SmsNoticeRecipientRateWoVat { get; set; }

        [JsonProperty("str-index-to", NullValueHandling = NullValueHandling.Ignore)]
        public string StrIndexTo { get; set; }

        [JsonProperty("street-to", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetTo { get; set; }

        [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
        public string Surname { get; set; }

        [JsonProperty("tel-address", NullValueHandling = NullValueHandling.Ignore)]
        public long? TelAddress { get; set; }

        [JsonProperty("total-rate-wo-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRateWoVat { get; set; }

        [JsonProperty("total-vat", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalVat { get; set; }

        [JsonProperty("transport-mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TransportMode { get; set; }

        [JsonProperty("transport-type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransportType { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

        [JsonProperty("vladenie-to", NullValueHandling = NullValueHandling.Ignore)]
        public string VladenieTo { get; set; }
    }

    public partial class CustomsDeclaration
    {
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("customs-entries", NullValueHandling = NullValueHandling.Ignore)]
        public CustomsEntry[] CustomsEntries { get; set; }

        [JsonProperty("entries-type", NullValueHandling = NullValueHandling.Ignore)]
        public string EntriesType { get; set; }

        [JsonProperty("with-certificate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithCertificate { get; set; }

        [JsonProperty("with-invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithInvoice { get; set; }

        [JsonProperty("with-license", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithLicense { get; set; }
    }

    public partial class CustomsEntry
    {
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }

        [JsonProperty("country-code", NullValueHandling = NullValueHandling.Ignore)]
        public long? CountryCode { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("tnved-code", NullValueHandling = NullValueHandling.Ignore)]
        public string TnvedCode { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public long? Weight { get; set; }
    }

    public partial class DeliveryTime
    {
        [JsonProperty("max-days", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxDays { get; set; }

        [JsonProperty("min-days", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinDays { get; set; }
    }

    public partial class Dimension
    {
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public long? Length { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }
    }

    public partial class Goods
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("insr-value", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsrValue { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Quantity { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("vat-rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? VatRate { get; set; }
    }

    public partial class OnlinePaymentMark
    {
        [JsonProperty("index-oper", NullValueHandling = NullValueHandling.Ignore)]
        public string IndexOper { get; set; }

        [JsonProperty("online-payment-mark-id", NullValueHandling = NullValueHandling.Ignore)]
        public string OnlinePaymentMarkId { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }
    }

    public partial class FindOrderResult
    {
        public static FindOrderResult[] FromJson(string json) => JsonConvert.DeserializeObject<FindOrderResult[]>(json, Response.FindOrderResult.Converter.Settings);

        public static FindOrderResult FromJsonSingl(string json) => JsonConvert.DeserializeObject<FindOrderResult>(json, Response.FindOrderResult.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FindOrderResult[] self) => JsonConvert.SerializeObject(self, Response.FindOrderResult.Converter.Settings);

        public static string ToJson(this FindOrderResult self) => JsonConvert.SerializeObject(self, Response.FindOrderResult.Converter.Settings);
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
