
using System.Net;

var tokenTelegramBot = "7007749580:AAGDMQUSMm_5ckWNj36S4FSVAkwgpm4n-vQ";

//https://api.telegram.org/bot(API Token)/sendMessage?chat_id={{telegram_id}}&text=ваш текст.
var apiUrl = "https://api.telegram.org";

var destID = "743563080";
var text = "😐";

var httpClient = new HttpClient();
using HttpResponseMessage response = await httpClient.GetAsync($"https://api.telegram.org/bot{tokenTelegramBot}/getUpdates");
    
var jsonResponse = await response.Content.ReadAsStringAsync();
Console.WriteLine($"{jsonResponse}\n");



string urlString = $"https://api.telegram.org/bot{tokenTelegramBot}/sendMessage?chat_id={destID}&text={text}";
var request = new HttpRequestMessage(HttpMethod.Post,urlString);
await httpClient.SendAsync(request);
