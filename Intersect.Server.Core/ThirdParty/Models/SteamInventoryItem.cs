using Newtonsoft.Json;

namespace Intersect.Server.ThirdParty.Models;

public class SteamInventoryItem
{
    public string AccountId { get; set; }
    public string ItemId { get; set; }
    public int Quantity { get; set; }
    public string OriginalItemId { get; set; }
    public int ItemDefId { get; set; }
    public int AppId { get; set; }
    public string Acquired { get; set; }
    public string State { get; set; }
    public string Origin { get; set; }
}

public class SteamInventoryResponse
{
    [JsonProperty("item_json")]
    public string ItemJson { get; set; }
}