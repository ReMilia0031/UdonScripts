
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// ========================================
// VRC_TriggerのActive Toggleするだけのスクリプト
// ========================================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class TRIG_ONE_OBJ : UdonSharpBehaviour
    {
        [SerializeField] private GameObject OBJ_001 = null;

        public override void Interact() //インタラクトがあったらオブジェクトに対してActiveトグル投げてるだけ
        {
            OBJ_001.SetActive(!OBJ_001.activeSelf);
        }
    }
}