using UnityEngine;

namespace Assets.Scripts.FSMs
{
        [RequireComponent(typeof(DemonAbilityFSM))]
        public class FSM : MonoBehaviour
        {
            private DemonAbilityFSM demonMenuAbilityFSM = null;
            public DemonAbilityFSM DemonMenuAbilityFSM { get { return demonMenuAbilityFSM; } }


            private static FSM _instance;

            public static FSM Instance { get { return _instance; } }

            private void Awake()
            {
                if (_instance != null)
                {
                    Destroy(gameObject);
                    return;
                }

                _instance = this;

                SetFSMs();

                DontDestroyOnLoad(gameObject);
            }

            private void SetFSMs()
            {
                demonMenuAbilityFSM = FindObjectOfType<DemonAbilityFSM>();
            }
        }
    }

