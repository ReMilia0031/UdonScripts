
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class SW_col : UdonSharpBehaviour
    {
        [SerializeField] private GameObject OBJ_001;

        [SerializeField] private GameObject SW_UP;
        [SerializeField] private GameObject SW_DW;

        public override void Interact()
        {
            OBJ_001.SetActive(!OBJ_001.activeSelf);
            SW_UP.SetActive(!SW_UP.activeSelf);
            SW_DW.SetActive(!SW_DW.activeSelf);
        }
    }
}