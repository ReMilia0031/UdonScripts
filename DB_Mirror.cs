
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// ========================================
// VRC_TriggerのActive Toggleするだけのスクリプト（2つ）
// ========================================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class DB_Mirror : UdonSharpBehaviour
    {
        [SerializeField] private GameObject mirror_obj = null;
        [SerializeField] private GameObject mirror_txt = null;

        public override void Interact()
        {
            mirror_obj.SetActive(!mirror_obj.activeSelf);
            mirror_txt.SetActive(!mirror_txt.activeSelf);
        }
    }
}