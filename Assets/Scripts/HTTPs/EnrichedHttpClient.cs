
using System.Collections.Generic;
using System.Threading;
using System;
using System.Threading.Tasks;
namespace Assets.Scripts.HTTPs
{
    public class EnrichedHttpClient
    {

        public async Task PostHellmasterData(string method, object payloadObject, Action callback, IDictionary<string, string> queryString = null, CancellationToken cancellationToken = default)
        {
            //Send to server
        }
    }
}
