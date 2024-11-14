using System.Net.Http.Headers;
using Intersect.Server.ThirdParty.Models;
using Newtonsoft.Json;

namespace Intersect.Server.ThirdParty;

public static class SteamHelper
    {
        private static readonly string BaseUrl = "https://partner.steam-api.com/IInventoryService/";
        private static readonly string ApiKey = Options.Instance.Steam.SteamApiKey;
        private static readonly int AppId = Options.Instance.Steam.AppId;
        private static readonly HttpClient Client = CreateHttpClient();

        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-webapi-key", ApiKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            return client;
        }

        public static async Task<List<SteamInventoryItem>> GetSteamInventoryAsync(ulong steamId)
        {
            var url = $"{BaseUrl}GetInventory/v1/";
            var inputJson = $@"{{""appid"":{AppId}, ""steamid"":{steamId}}}";

            var request = new HttpRequestMessage(HttpMethod.Get, $"{url}?input_json={inputJson}");
            var response = await Client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var inventoryJson = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(inventoryJson))
                {
                    var inventoryResponse = JsonConvert.DeserializeObject<Dictionary<string, SteamInventoryResponse>>(inventoryJson);
                    return JsonConvert.DeserializeObject<List<SteamInventoryItem>>(inventoryResponse["response"].ItemJson);
                }
            }
            return null;
        }

        public static async Task<bool> ConsumeSteamItemAsync(ulong steamId, string itemId, int quantity)
        {
            var url = $"{BaseUrl}ConsumeItem/v1/";
            var consumeJson = $@"{{""appid"":{AppId}, ""steamid"":""{steamId}"", ""itemid"":""{itemId}"", ""quantity"":""{quantity}""}}";

            var request = new HttpRequestMessage(HttpMethod.Post, $"{url}?input_json={consumeJson}");
            var response = await Client.SendAsync(request);
            return response.IsSuccessStatusCode;
        }
    }