
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// =========================
// ミラー切り替え用スクリプト
// 使用例:鏡 HI LO切替
// =========================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class MIRROR_HL : UdonSharpBehaviour
    {
        [SerializeField] private GameObject mirror_HI = null;
        [SerializeField] private GameObject mirror_LO = null;

        [SerializeField] private GameObject SW_UP = null;
        [SerializeField] private GameObject SW_DW = null;

        public override void Interact() // インタラクトがあったら二つのオブジェクトに対してActive切替投げてるだけ
        {
            mirror_HI.SetActive(!mirror_HI.activeSelf);
            mirror_LO.SetActive(!mirror_LO.activeSelf);
            SW_UP.SetActive(!SW_UP.activeSelf);
            SW_DW.SetActive(!SW_DW.activeSelf);
        }
    }
}