
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class DB_MSTR : UdonSharpBehaviour
    {
        [SerializeField] private MeshRenderer OBJ_001;
        [SerializeField] private Material Mat_001;
        [SerializeField] private Material Mat_002;

        public override void OnPlayerJoined(VRCPlayerApi player)
        {
            if (Networking.IsMaster)
                OBJ_001.material = Mat_002;
            else
                OBJ_001.material = Mat_001;
        }
    }
}