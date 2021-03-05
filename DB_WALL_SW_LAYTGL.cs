
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class LAYER_TGL : UdonSharpBehaviour
    {
        [SerializeField] private GameObject LAYOBJ_001;

        [SerializeField] private GameObject SW_UP;
        [SerializeField] private GameObject SW_DW;

        public override void Interact()
        {
            if (LAYOBJ_001.layer == 11)
                LAYOBJ_001.layer = 5;

            else if (LAYOBJ_001.layer == 5)
                LAYOBJ_001.layer = 11;

            SW_UP.SetActive(!SW_UP.activeSelf);
            SW_DW.SetActive(!SW_DW.activeSelf);

        }
    }
}