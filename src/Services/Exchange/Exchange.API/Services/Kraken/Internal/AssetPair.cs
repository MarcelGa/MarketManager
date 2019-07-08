using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange.API.Services.Kraken.Internal
{
    internal class AssetPair
    {
        /// <summary>
        /// The name of the asset pair
        /// </summary>
        public String PairName { get; set; }
        /// <summary>
        /// The name of the base currency for the asset pair
        /// </summary>
        public String BaseName { get; set; }
        /// <summary>
        /// The name of the quote currency for the asset pair
        /// </summary>
        public String QuoteName { get; set; }
    }
}
