using System.Collections.Generic;
using UnityEngine;

namespace Sena
{
    public class BigParty : MonoBehaviour
    {
        List<UnityEngine.GameObject> Locks = new List<GameObject>();
        private void OnEnable()
        {
            typeof(RoR2.RoR2Application).SetField("maxPlayers", 16);
            typeof(RoR2.RoR2Application).SetField("hardMaxPlayers", 16);
            typeof(RoR2.RoR2Application).SetField("maxLocalPlayers", 16);
            UnityEngine.Networking.NetworkManager.singleton.maxConnections = 16;
        }
        private void OnDisable()
        {
            typeof(RoR2.RoR2Application).SetField("maxPlayers", 4);
            typeof(RoR2.RoR2Application).SetField("hardMaxPlayers", 4);
            typeof(RoR2.RoR2Application).SetField("maxLocalPlayers", 4);
            UnityEngine.Networking.NetworkManager.singleton.maxConnections = 4;
        }
    }
}
