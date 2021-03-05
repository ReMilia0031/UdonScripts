
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class JOIN_AUD : UdonSharpBehaviour
    {
        [SerializeField] private AudioSource SND_001;
        public override void OnPlayerJoined(VRCPlayerApi player)
        {
            SND_001.Play();
        }
    }
}
