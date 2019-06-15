using System.Collections.Generic;
using UnityEngine;

namespace Sena
{
    public class BigParty : MonoBehaviour
    {
            typeof(RoR2.RoR2Application).SetField("maxPlayers", 16);
            UnityEngine.Networking.NetworkManager.singleton.maxConnections = 16;
        }
        private void OnDisable()
        {
            typeof(RoR2.RoR2Application).SetField("maxPlayers", 4);
            UnityEngine.Networking.NetworkManager.singleton.maxConnections = 4;
        }
    }
}
