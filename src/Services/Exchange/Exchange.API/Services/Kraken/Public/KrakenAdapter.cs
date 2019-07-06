using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exchange.API.Model;
using Exchange.API.Services.Kraken.Internal;
using Infrastructure;

namespace Exchange.API.Services.Kraken.Public
{
    public class KrakenAdapter : IExchangeAdapter
    {
        private readonly IHttpClientHandler _httpClientHandler;

        public KrakenAdapter(IHttpClientHandler httpClientHandler)
        {
            _httpClientHandler = httpClientHandler;
        }

        public string Name => "Kraken";

        private const string ApiUrl = "https://api.kraken.com/0/";
        private readonly string PuplicApiUrl = $"{ApiUrl}/public/";

        public Task<IAsset> GetAssets()
        {
            var assets = _httpClientHandler.GetAsync<AssetInfo>(PuplicApiUrl);

            //use mapper for map to Global asset type


            throw new NotImplementedException();
        }

        public Task<IAssetPair> GetPairs()
        {
            throw new NotImplementedException();
        }
    }
}
