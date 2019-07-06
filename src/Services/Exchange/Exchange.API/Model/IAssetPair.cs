using System.Collections.Generic;

namespace Exchange.API.Model
{
    public interface IAssetPair
    {
        string Id { get; }

        string Name { get; }

        IReadOnlyCollection<int> Intervals { get; }
    }
}
