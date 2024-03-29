﻿using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Request.OrderRequest;
using Response.CreateOrderResult;
using Response.FindOrderResult;
using Response.Batch;
using Response.NormalizedAddress;
using Request.AddressRequest;
using Request.FioRequest;
using Response.NormalizedFio;
using Response.NormalizedPhone;
using Request.PhoneRequest;
using Request.DeleteOrderRequest;
using Response.DeleteOrderResult;

namespace OtpravkaPochtaRu
{
    /// <summary>
    /// Клиент для Api "Отправка Почта России"
    /// </summary>
    public class OtpravkaClient
    {
        /// <summary>
        /// Ключ авторизации(X-User-Authorization). Формат: "Basic [key]"
        /// </summary>
        string _UserAuthorization;
        /// <summary>
        /// Токен авторизации(Authorization). Формат: "AccessToken [key]"
        /// </summary>
        string _Token;
        /// <summary>
        /// Базовый Url Api "Отправка ПочтаРосии"
        /// </summary>
        readonly string _BaseUrl;
        /// <summary>
        /// Прокси для отправки запроса. = new WebProxy(string Host, int Port);
        /// </summary>
        IWebProxy _Proxy;

        /// <summary>
        /// Конструктор клиента к Api Отправка ПочтаРоссии
        /// </summary>
        /// <param name="UserAuthorization">Ключ авторизации(X-User-Authorization). Формат: "Basic [key]"</param>
        /// <param name="Token">Токен авторизации(Authorization). Формат: "AccessToken [key]"</param>
        /// <param name="BaseUrl">Базовый Url Api "Отправка ПочтаРосии"</param>
        /// <param name="Proxy">Прокси для отправки запроса. = new WebProxy(string Host, int Port)</param>
        public OtpravkaClient(string UserAuthorization, string Token, string BaseUrl = "https://otpravka-api.pochta.ru", IWebProxy Proxy = null)
        {
            _UserAuthorization = UserAuthorization ?? throw new ArgumentNullException(nameof(UserAuthorization));
            _Token = Token ?? throw new ArgumentNullException(nameof(Token));
            _BaseUrl = BaseUrl ?? throw new ArgumentNullException(nameof(BaseUrl));
            _Proxy = Proxy;
        }

        /// <summary>
        /// Асинхронный GET Web-запрос
        /// </summary>
        /// <param name="url">Url запроса</param>
        /// <returns></returns>
        public async Task<string> AsyncGET(string url)
        {
            //генерация запроса
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            req.Timeout = 10000;
            if (this._Proxy != null)
            {
                req.Proxy = this._Proxy;
            }
            req.Headers.Add("Authorization", this._Token);  //указываем токен, полученный при регистрации
            req.Headers.Add("X-User-Authorization", this._UserAuthorization);  //указываем токен, полученный при регистрации
            req.ContentType = "application/json";
            req.Accept = "application/json";

            //получение ответа
            var res = req.GetResponse() as HttpWebResponse;
            var resStream = res.GetResponseStream();
            var sr = new StreamReader(resStream, Encoding.UTF8);
            var resString = await sr.ReadToEndAsync();

            return resString;
        }

        /// <summary>
        /// Асинхронный POST Web-запрос
        /// </summary>
        /// <param name="url">Url запроса</param>
        /// <param name="JsonString">Тело запроса</param>
        /// <returns></returns>
        public async Task<string> AsyncPOST(string url, string JsonString)
        {
            //генерация запроса
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            req.Method = "POST";
            req.Timeout = 10000;
            if (this._Proxy != null)
            {
                req.Proxy = this._Proxy;
            }
            req.Headers.Add("Authorization", this._Token);  //указываем токен, полученный при регистрации
            req.Headers.Add("X-User-Authorization", this._UserAuthorization);  //указываем токен, полученный при регистрации
            req.ContentType = "application/json";
            req.Accept = "application/json";

            //данные для отправки
            var sentData = Encoding.UTF8.GetBytes(JsonString);
            req.ContentLength = sentData.Length;
            Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);

            //получение ответа
            var res = req.GetResponse() as HttpWebResponse;
            var resStream = res.GetResponseStream();
            var sr = new StreamReader(resStream, Encoding.UTF8);
            var resString = await sr.ReadToEndAsync();

            return resString;
        }

        /// <summary>
        /// Асинхронный PUT Web-запрос
        /// </summary>
        /// <param name="url">Url запроса</param>
        /// <param name="JsonString">Тело запроса</param>
        /// <returns></returns>
        public async Task<string> AsyncPUT(string url, string JsonString)
        {
            //генерация запроса
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            req.Method = "PUT";
            req.Timeout = 10000;
            if (this._Proxy != null)
            {
                req.Proxy = this._Proxy;
            }
            req.Headers.Add("Authorization", this._Token);  //указываем токен, полученный при регистрации
            req.Headers.Add("X-User-Authorization", this._UserAuthorization);  //указываем токен, полученный при регистрации
            req.ContentType = "application/json";
            req.Accept = "application/json";

            //данные для отправки
            var sentData = Encoding.UTF8.GetBytes(JsonString);
            req.ContentLength = sentData.Length;
            Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);

            //получение ответа
            var res = req.GetResponse() as HttpWebResponse;
            var resStream = res.GetResponseStream();
            var sr = new StreamReader(resStream, Encoding.UTF8);
            var resString = await sr.ReadToEndAsync();

            return resString;
        }

        /// <summary>
        /// Асинхронный DELETE Web-запрос
        /// </summary>
        /// <param name="url">Url запроса</param>
        /// <param name="JsonString">Тело запроса</param>
        /// <returns></returns>
        public async Task<string> AsyncDELETE(string url, string JsonString)
        {
            //генерация запроса
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            req.Method = "DELETE";
            req.Timeout = 10000;
            if (this._Proxy != null)
            {
                req.Proxy = this._Proxy;
            }
            req.Headers.Add("Authorization", this._Token);  //указываем токен, полученный при регистрации
            req.Headers.Add("X-User-Authorization", this._UserAuthorization);  //указываем токен, полученный при регистрации
            req.ContentType = "application/json";
            req.Accept = "application/json";

            //данные для отправки
            var sentData = Encoding.UTF8.GetBytes(JsonString);
            req.ContentLength = sentData.Length;
            Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);

            //получение ответа
            var res = req.GetResponse() as HttpWebResponse;
            var resStream = res.GetResponseStream();
            var sr = new StreamReader(resStream, Encoding.UTF8);
            var resString = await sr.ReadToEndAsync();

            return resString;
        }

        /// <summary>
        /// Создание заказа
        /// </summary>
        /// <param name="JsonOrderRequest">Запрос посредством Json</param>
        /// <returns></returns>
        public CreateOrderResult CreateOrder(string JsonOrderRequest)
        {
            if(string.IsNullOrWhiteSpace(JsonOrderRequest)) throw new NullReferenceException("string JsonOrderRequest is NnullOeEmpty.");
            var orderRequests = OrderRequest.FromJson(JsonOrderRequest);
            if (orderRequests.Length == 0) throw new NullReferenceException("Массив объекта 'Заказ' пуст.");

            // Url сервиса
            string url = $"{this._BaseUrl}/1.0/user/backlog";

            // Тело для запроса
            var JsonRequestBody = Request.OrderRequest.Serialize.ToJson(orderRequests);
            
            string requestResult =
                (Task.Run(async ()
                    => await AsyncPUT(url, JsonRequestBody)))
                    .Result;
            var result = CreateOrderResult.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Создание заказа
        /// </summary>
        /// <param name="orderRequest">Запрос через класс OrderRequest[] = {new OrderRequest{...}, ...}</param>
        /// <returns>Ответ с идентификаторами заказов</returns>
        public CreateOrderResult CreateOrder(OrderRequest[] orderRequest)
        {
            if (orderRequest.Length == 0) throw new NullReferenceException("Массив объекта 'Заказ' пуст.");

            // Url сервиса
            string url = $"{this._BaseUrl}/1.0/user/backlog";

            // Тело для запроса
            var JsonRequestBody = Request.OrderRequest.Serialize.ToJson(orderRequest);

            string requestResult =
                (Task.Run(async ()
                    => await AsyncPUT(url, JsonRequestBody)))
                    .Result;
            var result = CreateOrderResult.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Удаление заказа
        /// </summary>
        /// <param name="ordersArray">Массив Id удаляемых заказов</param>
        /// <returns></returns>
        public DeleteOrderResult DeleteOrder(long[] ordersArray)
        {
            if (ordersArray.Length == 0) throw new NullReferenceException("Массив с id удаляемых Заказов пуст.");

            // Url сервиса
            string url = $"{this._BaseUrl}/1.0/backlog";

            // Тело для запроса
            var JsonRequestBody = Request.DeleteOrderRequest.Serialize.ToJson(ordersArray);

            string requestResult =
                (Task.Run(async ()
                    => await AsyncPUT(url, JsonRequestBody)))
                    .Result;
            var result = DeleteOrderResult.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Поиск заказов по ШПИ
        /// </summary>
        /// <param name="Barcode">Штрихкод(ШПИ)</param>
        /// <returns>Массив FindOrderResult</returns>
        public FindOrderResult[] GetOrderByBarcode(string Barcode)
        {
            if(string.IsNullOrWhiteSpace(Barcode)) throw new NullReferenceException("string Barcode is NullOrEmpty");

            string url = $"{this._BaseUrl}/1.0/shipment/search?query={Barcode}";

            string requestResult =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var result = FindOrderResult.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Запрос данных о партиях в архиве
        /// </summary>
        /// <returns></returns>
        public Batch[] GetAllBatchesInArchive()
        {
            string url = $"{this._BaseUrl}/1.0/archive";

            string requestResult =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var result = Batch.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Запрос данных о партиях Не в архиве
        /// </summary>
        /// <returns></returns>
        public Batch[] GetAllBatchesNotInArchive()
        {
            string url = $"{this._BaseUrl}/1.0/batch";

            string requestResult =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var result = Batch.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Запрос данных о заказах в партии
        /// </summary>
        /// <param name="BatchName">Имя партии</param>
        /// <returns></returns>
        public FindOrderResult[] GetOrdersInBatch(string BatchName)
        {
            string url = $"{this._BaseUrl}/1.0/batch/{BatchName}/shipment";

            string requestResult =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var result = FindOrderResult.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Поиск партии по наименованию
        /// </summary>
        /// <param name="BatchName">Имя партии</param>
        /// <returns></returns>
        public Batch[] GetBatchByName(string BatchName)
        {
            string url = $"{this._BaseUrl}/1.0/batch/{BatchName}";

            string requestResult =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var result = Batch.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Поиск заказа в партии по внутреннему  Id (Должна существовать не Архивная партия)
        /// </summary>
        /// <param name="Id">Внутренний Id заказа</param>
        /// <returns></returns>
        public FindOrderResult GetOrderInBatchById(long Id)
        {
            string url = $"{this._BaseUrl}/1.0/shipment/{Id}";

            string requestResult =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var result = FindOrderResult.FromJsonSingl(requestResult);

            return result;
        }

        /// <summary>
        /// Поиск заказа по Идентификатору (Id)
        /// </summary>
        /// <param name="Id">Внутренний id заказа</param>
        /// <returns></returns>
        public FindOrderResult GetOrderById(long Id)
        {
            string url = $"{this._BaseUrl}/1.0/backlog/{Id}";

            string requestResult =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var result = FindOrderResult.FromJsonSingl(requestResult);

            return result;
        }

        /// <summary>
        /// Нормализация адреса
        /// </summary>
        /// <param name="addressRequest">Array AddressRequest class objects</param>
        /// <returns></returns>
        public NormalizedAddress[] NormalizedAddressRequest(AddressRequest[] addressRequest)
        {
            if (addressRequest.Length == 0) throw new NullReferenceException("Массив объекта 'AddressRequest' пуст.");

            // Url сервиса
            string url = $"{this._BaseUrl}/1.0/clean/address";

            // Тело для запроса
            var JsonRequestBody = Request.AddressRequest.Serialize.ToJson(addressRequest);

            string requestResult =
                (Task.Run(async ()
                    => await AsyncPOST(url, JsonRequestBody)))
                    .Result;
            var result = NormalizedAddress.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Нормализация ФИО
        /// </summary>
        /// <param name="fioRequest">Array FioRequest class objects</param>
        /// <returns></returns>
        public NormalizedFio[] NormalizedFioRequest(FioRequest[] fioRequest)
        {
            if (fioRequest.Length == 0) throw new NullReferenceException("Массив объекта 'AddressRequest' пуст.");

            // Url сервиса
            string url = $"{this._BaseUrl}/1.0/clean/physical";

            // Тело для запроса
            var JsonRequestBody = Request.FioRequest.Serialize.ToJson(fioRequest);

            string requestResult =
                (Task.Run(async ()
                    => await AsyncPOST(url, JsonRequestBody)))
                    .Result;
            var result = NormalizedFio.FromJson(requestResult);

            return result;
        }

        /// <summary>
        /// Нормализация телефонного номера
        /// </summary>
        /// <param name="PhoneRequest">Array PhoneRequest class objects</param>
        /// <returns></returns>
        public NormalizedPhone[] NormalizedPhoneRequest(PhoneRequest[] PhoneRequest)
        {
            if (PhoneRequest.Length == 0) throw new NullReferenceException("Массив объекта 'AddressRequest' пуст.");

            // Url сервиса
            string url = $"{this._BaseUrl}/1.0/clean/physical";

            // Тело для запроса
            var JsonRequestBody = Request.PhoneRequest.Serialize.ToJson(PhoneRequest);

            string requestResult =
                (Task.Run(async ()
                    => await AsyncPOST(url, JsonRequestBody)))
                    .Result;
            var result = NormalizedPhone.FromJson(requestResult);

            return result;
        }
    }
}
