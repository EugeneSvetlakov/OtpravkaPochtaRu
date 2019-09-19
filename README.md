# OtpravkaPochtaRu
Библиотека для работы с API Отправка Почты России (https://otpravka-api.pochta.ru)

На 2019-09-19 реализован не весь функционал и не отработаны все возможные ошибки. Думаю будут дополнения и правки.

Для работы с Api нужна регистрация на сервисе и наличие:
1) "Токен авторизации" (Token)
2) "Ключ авторизации" (UserAuthorization)
Оба доступны в личном кабинете.

В библиотеке Используется Newtonsoft.

Работа:

1) Создание клиента
OtpravkaClient otpravkaClient = new OtpravkaClient(string UserAuthorization, string Token);
Если нужно использовать Proxy:
OtpravkaClient otpravkaClient = new OtpravkaClient(string UserAuthorization, string Token, Proxy: new WebProxy("Host", Port));

2) Работа с сервисом:

2.1) Создание Заказа(Отправления)
otpravkaClient.CreateOrder(orders);

,где orders - OrderRequest[]
Результатом выполнение будет CreateOrderResult. Содержит "Массив ошибок"(опционально) и Массив с внутренними идентификаторами (Id) созданных заказов.

2.2) Получить информацию по заказу с запрошенным внутренним идентификатором (Id)
otpravkaClient.GetOrderById(long Id);

2.3) Удаление заказа
otpravkaClient.DeleteOrder(long[] ordersArray);

,где ordersArray - Массив внутренних идентификаторов существующих заказов.

2.4) Поиск заказа по "Номеру отслеживания" (он же ШПИ/ШтрихКод/Barcode)
otpravkaClient.GetOrderByBarcode(string Barcode);

2.5) Поиск заказа в партии по внутреннему идентификатору (Id) (Должна существовать не Архивная партия)
otpravkaClient.GetOrderInBatchById(long Id);

2.6) Запрос данных о партиях в архиве
otpravkaClient.GetAllBatchesInArchive();

2.7) Запрос данных о партиях Не в архиве
otpravkaClient.GetAllBatchesNotInArchive();

2.8) Поиск партии по наименованию
otpravkaClient.GetBatchByName(string BatchName);
BatchName это поле "batch-name" в возвращаемых результатах например GetAllBatchesInArchive и GetAllBatchesNotInArchive.

2.9) Запрос данных о заказах в партии по "имени партии"
otpravkaClient.GetOrdersInBatch(string BatchName);
BatchName это поле "batch-name" в возвращаемых результатах например GetAllBatchesInArchive и GetAllBatchesNotInArchive.

3) Дополнительный функционал в Api:

3.1) Нормализация адреса
otpravkaClient.NormalizedAddressRequest(AddressRequest[] addressRequest);

3.2) Нормализация ФИО
otpravkaClient.NormalizedFioRequest(FioRequest[] fioRequest);

3.3) Нормализация телефонного номера
otpravkaClient.NormalizedPhoneRequest(PhoneRequest[] PhoneRequest);
