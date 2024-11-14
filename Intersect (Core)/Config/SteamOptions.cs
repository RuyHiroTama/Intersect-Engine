namespace Intersect.Config;

public partial class SteamOptions
{
    public Guid ItemId { get; set; } = Guid.Empty;
    public string SteamApiKey { get; set; } = "";
    public int AppId { get; set; } = 1736200;
    public int ItemDefId { get; set; } = 0;
}