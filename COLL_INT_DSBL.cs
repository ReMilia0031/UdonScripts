
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class COL_TGL : UdonSharpBehaviour
    {
        [SerializeField] private GameObject OBJ_001;

        public override void OnPlayerTriggerExit(VRCPlayerApi player)
        {
            if (player == Networking.LocalPlayer)
            {
                OBJ_001.SetActive(false);
            }

        }
    }
}