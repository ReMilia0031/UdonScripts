
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// ========================================
// VRC_TriggerのActive Toggleするだけのスクリプト(壁操作パネル用)
// ========================================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class SW_col : UdonSharpBehaviour
    {
        [SerializeField] private GameObject OBJ_001 = null;

        [SerializeField] private GameObject SW_UP = null;
        [SerializeField] private GameObject SW_DW = null;

        public override void Interact() // インタラクトがあったら
        {
            OBJ_001.SetActive(!OBJ_001.activeSelf); // Active切替
            SW_UP.SetActive(!SW_UP.activeSelf);
            SW_DW.SetActive(!SW_DW.activeSelf);
        }
    }
}