﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OrderRequest;
//
//    var orderRequest = OrderRequest.FromJson(jsonString);

namespace Request.OrderRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Класс Заказ(Отправление)
    /// </summary>
    public partial class OrderRequest
    {
        /// <summary>
        /// Тип адреса. "DEFAULT" or "PO_BOX" or "DEMAND" or "UNIT"
        /// </summary>
        [JsonProperty("address-type-to", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressTypeTo { get; set; } = "DEFAULT";

        /// <summary>
        /// Район. (Опционально)
        /// </summary>
        [JsonProperty("area-to", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaTo { get; set; }

        /// <summary>
        /// Идентификатор подразделения. (Опционально)
        /// </summary>
        [JsonProperty("branch-name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// Часть здания: Строение. (Опционально)
        /// </summary>
        [JsonProperty("building-to", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingTo { get; set; }

        /// <summary>
        /// ??? нет поля в текстовом описании схемы
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// Признак услуги проверки комплектности. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("completeness-checking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CompletenessChecking { get; set; }

        /// <summary>
        /// К оплате с получателя (копейки). (Опционально)
        /// </summary>
        [JsonProperty("compulsory-payment", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompulsoryPayment { get; set; }

        /// <summary>
        /// Часть здания: Корпус
        /// </summary>
        [JsonProperty("corpus-to", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpusTo { get; set; }

        /// <summary>
        /// Отметка "Курьер". Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("courier", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Courier { get; set; }

        /// <summary>
        /// Таможенная декларация (для международных отправлений). (Опционально)
        /// </summary>
        [JsonProperty("customs-declaration", NullValueHandling = NullValueHandling.Ignore)]
        public CustomsDeclaration CustomsDeclaration { get; set; }

        /// <summary>
        /// Признак оплаты при получении. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("delivery-with-cod", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeliveryWithCod { get; set; }

        /// <summary>
        /// Линейные размеры. (Опционально)
        /// </summary>
        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public Dimension Dimension { get; set; }

        /// <summary>
        /// Тип конверта - ГОСТ Р 51506-99. (Опционально). "C4"(229мм x 324мм), "C5"(162мм x 229мм),
        /// "DL"(110мм x 220мм), "A6"(105мм x 148мм), "A7"(74мм x 105мм)
        /// </summary>
        [JsonProperty("envelope-type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvelopeType { get; set; }

        /// <summary>
        /// Установлена ли отметка "Осторожно/Хрупкое"? Логические: true или false
        /// </summary>
        [JsonProperty("fragile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fragile { get; set; }

        /// <summary>
        /// Имя получателя
        /// </summary>
        [JsonProperty("given-name", NullValueHandling = NullValueHandling.Ignore)]
        public string GivenName { get; set; }

        /// <summary>
        /// Товарное вложение РПО. (Опционально)
        /// </summary>
        [JsonProperty("goods", NullValueHandling = NullValueHandling.Ignore)]
        public Goods Goods { get; set; }

        /// <summary>
        /// Название гостиницы. (Опционально)
        /// </summary>
        [JsonProperty("hotel-to", NullValueHandling = NullValueHandling.Ignore)]
        public string HotelTo { get; set; }

        /// <summary>
        /// Часть адреса: Номер здания. (Опционально)
        /// </summary>
        [JsonProperty("house-to", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseTo { get; set; }

        /// <summary>
        /// Почтовый индекс
        /// </summary>
        [JsonProperty("index-to", NullValueHandling = NullValueHandling.Ignore)]
        public long? IndexTo { get; set; }

        /// <summary>
        /// Объявленная ценность (копейки). (Опционально)
        /// </summary>
        [JsonProperty("insr-value", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsrValue { get; set; }

        /// <summary>
        /// Наличие описи вложения. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("inventory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inventory { get; set; }

        /// <summary>
        /// Часть здания: Литера. (Опционально)
        /// </summary>
        [JsonProperty("letter-to", NullValueHandling = NullValueHandling.Ignore)]
        public string LetterTo { get; set; }

        /// <summary>
        /// Микрорайон. (Опционально)
        /// </summary>
        [JsonProperty("location-to", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationTo { get; set; }

        /// <summary>
        /// Категория РПО. "SIMPLE"(Простое), "ORDERED"(Заказное), "ORDINARY"(Обыкновенное), 
        /// "WITH_DECLARED_VALUE"(С объявленной ценностью), 
        /// "WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY"(С объявленной ценностью и наложенным платежом), 
        /// "WITH_DECLARED_VALUE_AND_COMPULSORY_PAYMENT"(С объявленной ценностью и обязательным платежом), 
        /// "WITH_COMPULSORY_PAYMENT"(С обязательным платежом)
        /// </summary>
        [JsonProperty("mail-category", NullValueHandling = NullValueHandling.Ignore)]
        public string MailCategory { get; set; }

        /// <summary>
        /// Код страны. 643(Российская федерация), 840(Соединенные штаты америки),...
        /// см. https://otpravka.pochta.ru/specification#/dictionary-countries
        /// </summary>
        [JsonProperty("mail-direct", NullValueHandling = NullValueHandling.Ignore)]
        public long? MailDirect { get; set; } = 643;

        /// <summary>
        /// Вид РПО. "LETTER"(Письмо), "EMS"(Отправление EMS), ...
        /// см. https://otpravka.pochta.ru/specification#/enums-base-mail-type
        /// </summary>
        [JsonProperty("mail-type", NullValueHandling = NullValueHandling.Ignore)]
        public string MailType { get; set; }

        /// <summary>
        /// Нучной ввод адреса. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("manual-address-input", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManualAddressInput { get; set; }

        /// <summary>
        /// Вес РПО (в граммах).
        /// </summary>
        [JsonProperty("mass", NullValueHandling = NullValueHandling.Ignore)]
        public long? Mass { get; set; }

        /// <summary>
        /// Отчество получателя. (Опционально)
        /// </summary>
        [JsonProperty("middle-name", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Отметка "Возврату не подлежит". Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("no-return", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoReturn { get; set; }

        /// <summary>
        /// Способ оплаты уведомления. (Опционально). "CASHLESS"(Безналичный расчет), "STAMP"(Оплата марками), 
        /// "FRANKING"(Франкирование), "TO_FRANKING"(На франкировку), "ONLINE_PAYMENT_MARK"(Знак онлайн оплаты)
        /// см. https://otpravka.pochta.ru/specification#/enums-payment-methods
        /// </summary>
        [JsonProperty("notice-payment-method", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticePaymentMethod { get; set; }

        /// <summary>
        /// Номер для а/я, войсковая часть, войсковая часть ЮЯ, полевая почта. (Опционально)
        /// </summary>
        [JsonProperty("num-address-type-to", NullValueHandling = NullValueHandling.Ignore)]
        public string NumAddressTypeTo { get; set; }

        /// <summary>
        /// Часть здания: Оффис
        /// </summary>
        [JsonProperty("office-to", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficeTo { get; set; }

        /// <summary>
        /// Номер заказа. Внешний идентификатор заказа, который формируется отправителем
        /// </summary>
        [JsonProperty("order-num", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNum { get; set; }

        /// <summary>
        /// Сумма наложенного платежа (копейки). (Опционально)
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public long? Payment { get; set; }

        /// <summary>
        /// Способ оплаты. (Опционально). "CASHLESS"(Безналичный расчет), "STAMP"(Оплата марками), 
        /// "FRANKING"(Франкирование), "TO_FRANKING"(На франкировку), "ONLINE_PAYMENT_MARK"(Знак онлайн оплаты)
        /// См. https://otpravka.pochta.ru/specification#/enums-payment-methods
        /// </summary>
        [JsonProperty("payment-method", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Населенный пункт.
        /// </summary>
        [JsonProperty("place-to", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceTo { get; set; }

        /// <summary>
        /// Индекс места приема. (Опционально)
        /// </summary>
        [JsonProperty("postoffice-code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostofficeCode { get; set; }

        /// <summary>
        /// Необработанный адрес получателя. (Опционально)
        /// </summary>
        [JsonProperty("raw-address", NullValueHandling = NullValueHandling.Ignore)]
        public string RawAddress { get; set; }

        /// <summary>
        /// Наименование получателя одной строкой (ФИО, наименование организации)
        /// </summary>
        [JsonProperty("recipient-name", NullValueHandling = NullValueHandling.Ignore)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Область, регион
        /// </summary>
        [JsonProperty("region-to", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionTo { get; set; }

        /// <summary>
        /// Часть здания: Номер помещения. (Опционально)
        /// </summary>
        [JsonProperty("room-to", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomTo { get; set; }

        /// <summary>
        /// Часть здания: Дробь. (Опционально)
        /// </summary>
        [JsonProperty("slash-to", NullValueHandling = NullValueHandling.Ignore)]
        public string SlashTo { get; set; }

        /// <summary>
        /// Признак услуги SMS уведомления. Целое число (Опционально)
        /// </summary>
        [JsonProperty("sms-notice-recipient", NullValueHandling = NullValueHandling.Ignore)]
        public long? SmsNoticeRecipient { get; set; }

        /// <summary>
        /// Почтовый индекс (буквенно-цифровой). (Опционально)
        /// </summary>
        [JsonProperty("str-index-to", NullValueHandling = NullValueHandling.Ignore)]
        public string StrIndexTo { get; set; }

        /// <summary>
        /// Часть адреса: Улица. 
        /// </summary>
        [JsonProperty("street-to", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetTo { get; set; }

        /// <summary>
        /// Фамилия получателя
        /// </summary>
        [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
        public string Surname { get; set; }

        /// <summary>
        /// Телефон получателя (может быть обязательным для некоторых типов отправлений). (Опционально)
        /// </summary>
        [JsonProperty("tel-address", NullValueHandling = NullValueHandling.Ignore)]
        public long? TelAddress { get; set; }

        /// <summary>
        /// Возможный вид транспортировки (для международных отправлений). "SURFACE"(Наземный), 
        /// "AVIA"(Авиа), "COMBINED"(Комбинированный), "EXPRESS"(Системой ускоренной почты), 
        /// "STANDARD"(Используется для отправлений "EMS Оптимальное")
        /// См. https://otpravka.pochta.ru/specification#/enums-base-transport-type
        /// </summary>
        [JsonProperty("transport-type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransportType { get; set; }

        /// <summary>
        /// Часть здания: Владение. (Опционально)
        /// </summary>
        [JsonProperty("vladenie-to", NullValueHandling = NullValueHandling.Ignore)]
        public string VladenieTo { get; set; }

        /// <summary>
        /// Отметка 'С электронным уведомлением'. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("with-electronic-notice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithElectronicNotice { get; set; }

        /// <summary>
        /// Отметка 'С заказным уведомлением'. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("with-order-of-notice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithOrderOfNotice { get; set; }

        /// <summary>
        /// Отметка 'С простым уведомлением'. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("with-simple-notice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithSimpleNotice { get; set; }

        /// <summary>
        /// Отметка "Без разряда". Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("wo-mail-rank", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WoMailRank { get; set; }
    }

    /// <summary>
    /// /// <summary>
    /// Таможенная декларация (для международных отправлений). (Опционально)
    /// </summary>
    /// </summary>
    public partial class CustomsDeclaration
    {
        /// <summary>
        /// ??? Сертификаты, сопровождающие отправление. (Опционально)
        /// </summary>
        [JsonProperty("certificate-number", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// Код валюты. "RUB" or "USD" or ...
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Список почтовых вложений. Массив
        /// </summary>
        [JsonProperty("customs-entries", NullValueHandling = NullValueHandling.Ignore)]
        public CustomsEntry[] CustomsEntries { get; set; }

        /// <summary>
        /// Категория вложения. "GIFT"(подарок), "DOCUMENT"(документ), "SALE_OF_GOODS"(Продажа товара)
        /// , "COMMERCIAL_SAMPLE"(Коммерческий образец), "OTHER"(Прочее)
        /// </summary>
        [JsonProperty("entries-type", NullValueHandling = NullValueHandling.Ignore)]
        public string EntriesType { get; set; }

        /// <summary>
        /// ??? Счет (номер счета-фактуры). (Опционально)
        /// </summary>
        [JsonProperty("invoice-number", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// ??? Лицензии, сопровождающие отправление. (Опционально)
        /// </summary>
        [JsonProperty("license-number", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// Приложенные документы: сертификат. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("with-certificate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithCertificate { get; set; }

        /// <summary>
        /// Приложенные документы: счет-фактура. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("with-invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithInvoice { get; set; }

        /// <summary>
        /// Приложенные документы: лицензия. Логические: true или false (Опционально)
        /// </summary>
        [JsonProperty("with-license", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithLicense { get; set; }
    }

    /// <summary>
    /// Экземпляр почтового вложения.
    /// </summary>
    public partial class CustomsEntry
    {
        /// <summary>
        /// Количество.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }

        /// <summary>
        /// Код страны происхождения. (Опционально)
        /// </summary>
        [JsonProperty("country-code", NullValueHandling = NullValueHandling.Ignore)]
        public long? CountryCode { get; set; }

        /// <summary>
        /// Наименование товара.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Код ТНВЭД
        /// </summary>
        [JsonProperty("tnved-code", NullValueHandling = NullValueHandling.Ignore)]
        public string TnvedCode { get; set; }

        /// <summary>
        /// Цена за единицу товара в копейках (вкл. НДС). (Опционально)
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        /// <summary>
        /// Вес товара (в граммах). (Опционально)
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public long? Weight { get; set; }
    }

    /// <summary>
    /// Линейные размеры. (Опционально)
    /// </summary>
    public partial class Dimension
    {
        /// <summary>
        /// Линейная высота (сантиметры). (Опционально)
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        /// <summary>
        /// Линейная длина (сантиметры). (Опционально)
        /// </summary>
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public long? Length { get; set; }

        /// <summary>
        /// Линейная ширина (сантиметры). (Опционально)
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }
    }

    /// <summary>
    /// Товарное вложение РПО. (Опционально)
    /// </summary>
    public partial class Goods
    {
        /// <summary>
        /// Список товарных вложений. Массив
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Item[] Items { get; set; }
    }

    /// <summary>
    /// Экземпляр Товарного вложения.
    /// </summary>
    public partial class Item
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Объявленная ценность (копейки). (Опционально)
        /// </summary>
        [JsonProperty("insr-value", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsrValue { get; set; }

        /// <summary>
        /// Количество товара
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Quantity { get; set; }

        /// <summary>
        /// Цена за единицу товара в копейках (вкл. НДС). (Опционально)
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        /// <summary>
        /// Ставка НДС: Без НДС(-1), 0, 10, 110, 20, 120. (Опционально)
        /// </summary>
        [JsonProperty("vat-rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? VatRate { get; set; }
    }

    public partial class OrderRequest
    {
        /// <summary>
        /// Из JSON в Объект (Десериализация)
        /// </summary>
        /// <param name="json">строка JSON</param>
        /// <returns></returns>
        public static OrderRequest[] FromJson(string json) => JsonConvert.DeserializeObject<OrderRequest[]>(json, Request.OrderRequest.Converter.Settings);
    }

    public static class Serialize
    {
        /// <summary>
        /// Из Объекта в JSON (Сериализация)
        /// </summary>
        /// <param name="self">Массив элементов запроса</param>
        /// <returns></returns>
        public static string ToJson(this OrderRequest[] self) => JsonConvert.SerializeObject(self, Request.OrderRequest.Converter.Settings);
    }

    /// <summary>
    /// Класс содержащий объект JsonSerializerSettings
    /// </summary>
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
