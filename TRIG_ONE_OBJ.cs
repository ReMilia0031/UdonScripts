
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class TRIG_ONE_OBJ : UdonSharpBehaviour
    {
        [SerializeField] private GameObject OBJ_001;

        public override void Interact()
        {
            OBJ_001.SetActive(!OBJ_001.activeSelf);
        }
    }
}