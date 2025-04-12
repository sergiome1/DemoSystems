using Assets.Scripts.HTTPs;
using System.Threading;
using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class HTTPManager : MonoBehaviour
    {
        private const string PostHellmasterData = "PostHellmasterData";

        private EnrichedHttpClient http;

        private static HTTPManager _instance;

        public static HTTPManager Instance
        {
            get
            {
                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            _instance = this;
        }

        public void HellmasterData<TRequest>(TRequest message, CancellationToken cancellationToken = default) where TRequest : struct, NetworkMessage
        {
            HellmasterDataRequest request = new HellmasterDataRequest();

            /*** Request params filled with proper info ***/

            _ = http.PostHellmasterData(PostHellmasterData, request, null, cancellationToken: cancellationToken);
        }
    }
}
