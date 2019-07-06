using Exchange.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange.API.Services
{
    interface IExchangeAdapter
    {
        string Name { get; }
                
        Task<IAsset> GetAssets();

        Task<IAssetPair> GetPairs();
    }
}
