
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class MIRROR_HL : UdonSharpBehaviour
    {
        [SerializeField] private GameObject mirror_HI;
        [SerializeField] private GameObject mirror_LO;

        [SerializeField] private GameObject SW_UP;
        [SerializeField] private GameObject SW_DW;

        public override void Interact()
        {
            mirror_HI.SetActive(!mirror_HI.activeSelf);
            mirror_LO.SetActive(!mirror_LO.activeSelf);
            SW_UP.SetActive(!SW_UP.activeSelf);
            SW_DW.SetActive(!SW_DW.activeSelf);
        }
    }
}