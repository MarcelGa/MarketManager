namespace Exchange.API.Model
{
    public interface IAsset
    {
        string Id { get; }

        string Name { get; }

        AssetType Type { get; }
    }
}
