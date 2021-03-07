
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// =============================
// AmimationのVariableに対してBool値入れるアレ 適当実装
// 使用例：換気扇とかひな壇とか
// =============================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class FAN_PWR : UdonSharpBehaviour
    {
        [SerializeField] private Animator ANIM_001 = null;
        [SerializeField] private string ANIM_VAR = null;

        public override void Interact() 			// インタラクトがあったら
        {
            if (ANIM_001.GetBool(ANIM_VAR) == true)	// Animator変数がtrueだったら
                ANIM_001.SetBool(ANIM_VAR, false);	// 無効化
            else									// そうじゃなかったら
                ANIM_001.SetBool(ANIM_VAR, true);	// 有効化

        }
    }
}
