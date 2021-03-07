
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// =========================
// Unityレイヤー切り替え用スクリプト
// 使用例:鏡操作切替のアレ
// =========================

// SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class LAYER_TGL : UdonSharpBehaviour
    {
        [SerializeField] private GameObject LAYOBJ_001 = null;

        [SerializeField] private GameObject SW_UP = null;
        [SerializeField] private GameObject SW_DW = null;

        public override void Interact() //インタラクトがあったら
        {
            if (LAYOBJ_001.layer == 11) //Unityでのレイヤー11番(Enviroment)だったら5番(UI)に切替
                LAYOBJ_001.layer = 5;

            else if (LAYOBJ_001.layer == 5) //5だったら11
                LAYOBJ_001.layer = 11;

            SW_UP.SetActive(!SW_UP.activeSelf);
            SW_DW.SetActive(!SW_DW.activeSelf);

        }
    }
}