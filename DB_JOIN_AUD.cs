
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// =============================
// 誰かが参加した時に鳴るアレ
// =============================

namespace Kotonozaka_Ind
{
    public class JOIN_AUD : UdonSharpBehaviour
    {
        [SerializeField] private AudioSource SND_001 = null;

        public override void OnPlayerJoined(VRCPlayerApi player) //誰かがJoinした時
        {
            SND_001.Play(); //AudioSourceに対してPlay投げる
        }
    }
}
