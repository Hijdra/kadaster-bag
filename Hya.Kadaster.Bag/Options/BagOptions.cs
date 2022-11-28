namespace Hya.Kadaster.Bag.Options;

public class BagOptions
{
    public const string DefaultSection = nameof(BagOptions);
    public string ApiKey { get; set; }
    public bool IsLive { get; set; }
}