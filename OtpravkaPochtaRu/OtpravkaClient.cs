using System;
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

namespace OtpravkaPochtaRu
{
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
        /// Прокси для отправки запроса.
        /// </summary>
        IWebProxy _Proxy;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAuthorization"></param>
        /// <param name="Token"></param>
        /// <param name="BaseUrl"></param>
        /// <param name="Proxy">new WebProxy(string Host, int Port)</param>
        public OtpravkaClient(string UserAuthorization, string Token, string BaseUrl = "https://otpravka-api.pochta.ru", IWebProxy Proxy = null)
        {
            _UserAuthorization = UserAuthorization ?? throw new ArgumentNullException(nameof(UserAuthorization));
            _Token = Token ?? throw new ArgumentNullException(nameof(Token));
            _BaseUrl = BaseUrl ?? throw new ArgumentNullException(nameof(BaseUrl));
            _Proxy = Proxy;
        }

        public async Task<string> AsyncGET(string url)
        {
            //генерация запроса
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            req.Method = "GET";
            req.Timeout = 10000;
            if (this._Proxy != null)
            {
                req.Proxy = this._Proxy;
            }
            req.Headers.Add("Authorization", this._Token);  //указываем токен, полученный при регистрации
            req.Headers.Add("X-User-Authorization", this._UserAuthorization);  //указываем токен, полученный при регистрации
            req.ContentType = "application/json";
            req.Accept = "application/json";

            Stream sendStream = req.GetRequestStream();

            //получение ответа
            var res = req.GetResponse() as HttpWebResponse;
            var resStream = res.GetResponseStream();
            var sr = new StreamReader(resStream, Encoding.UTF8);
            var resString = await sr.ReadToEndAsync();


            return resString;
        }

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
        /// Создание заказа в "Отправка ПочтаРоссии"
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
            var RequestInJson = Request.OrderRequest.Serialize.ToJson(orderRequests);
            
            string result =
                (Task.Run(async ()
                    => await AsyncPOST(url, RequestInJson)))
                    .Result;
            var createOrderResult = CreateOrderResult.FromJson(result);

            return createOrderResult;
        }

        /// <summary>
        /// Создание заказа в "Отправка ПочтаРоссии"
        /// </summary>
        /// <param name="orderRequest">Запрос через класс OrderRequest[] = {new OrderRequest{...}, ...}</param>
        /// <returns>Ответ с идентификаторами заказов</returns>
        public CreateOrderResult CreateOrder(OrderRequest[] orderRequest)
        {
            if (orderRequest.Length == 0) throw new NullReferenceException("Массив объекта 'Заказ' пуст.");

            // Url сервиса
            string url = $"{this._BaseUrl}/1.0/user/backlog";

            // Тело для запроса
            var RequestInJson = Request.OrderRequest.Serialize.ToJson(orderRequest);

            string result =
                (Task.Run(async ()
                    => await AsyncPOST(url, RequestInJson)))
                    .Result;
            var createOrderResult = CreateOrderResult.FromJson(result);

            return createOrderResult;
        }

        /// <summary>
        /// Поиск заказов с ШПИ
        /// </summary>
        /// <param name="Barcode">Штрихкод(ШПИ)</param>
        /// <returns>Массив FindOrderResult</returns>
        public FindOrderResult[] GetOrderByBarcode(string Barcode)
        {
            if(string.IsNullOrWhiteSpace(Barcode)) throw new NullReferenceException("string Barcode is NullOrEmpty");

            string url = $"{this._BaseUrl}/1.0/shipment/search?query={Barcode}";

            string result =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var resultReturn = FindOrderResult.FromJson(result);

            return resultReturn;
        }

        /// <summary>
        /// Запрос данных о партиях в архиве
        /// </summary>
        /// <returns></returns>
        public Batch[] GetAllBatchesInArchive()
        {
            string url = $"{this._BaseUrl}/1.0/archive";

            string result =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var resultReturn = Batch.FromJson(result);

            return resultReturn;
        }

        /// <summary>
        /// Запрос данных о заказах в партии
        /// </summary>
        /// <param name="BatchName">Имя партии</param>
        /// <returns></returns>
        public FindOrderResult[] GetOrdersInBatch(string BatchName)
        {
            string url = $"{this._BaseUrl}/1.0/batch/{BatchName}/shipment";

            string result =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var resultReturn = FindOrderResult.FromJson(result);

            return resultReturn;
        }

        /// <summary>
        /// Поиск партий по наименованию
        /// </summary>
        /// <param name="BatchName">Имя партии</param>
        /// <returns></returns>
        public Batch GetBatchByName(string BatchName)
        {
            string url = $"{this._BaseUrl}/1.0/batch/{BatchName}";

            string result =
                (Task.Run(async ()
                    => await AsyncGET(url)))
                    .Result;
            var resultReturn = Batch.FromJson(result)[0];

            return resultReturn;
        }

        /// <summary>
        /// Нормализация адреса
        /// </summary>
        /// <param name="addressRequest">Массив NormalizedAddress'ов</param>
        /// <returns></returns>
        public NormalizedAddress[] NormalizedAddressRequest(AddressRequest[] addressRequest)
        {
            if (addressRequest.Length == 0) throw new NullReferenceException("Массив объекта 'AddressRequest' пуст.");

            // Url сервиса
            string url = $"{this._BaseUrl}/1.0/user/backlog";

            // Тело для запроса
            var RequestInJson = Request.AddressRequest.Serialize.ToJson(addressRequest);

            string result =
                (Task.Run(async ()
                    => await AsyncPOST(url, RequestInJson)))
                    .Result;
            var createOrderResult = NormalizedAddress.FromJson(result);

            return createOrderResult;
        }
    }
}
