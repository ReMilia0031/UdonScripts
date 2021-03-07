
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// =============================
// Amimationの数値(Int)操作するアレ
// 使用例：ナイトモード明るさ変更してるアレ
// =============================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class ANIM_CALC : UdonSharpBehaviour
    {
        [SerializeField] private Animator ANIM_001 = null;
        [SerializeField] private Animator ANIM_002 = null;
        [SerializeField] private string ANIM_001_VAR = null;
        [SerializeField] private string ANIM_002_VAR = null;
        [SerializeField] private bool ANIM_PLUS = false;

        public override void Interact() //インタラクトがあったら
        {
            var ANIM_INT1_VAR = ANIM_001.GetInteger(ANIM_001_VAR);
            var ANIM_INT2_VAR = ANIM_002.GetInteger(ANIM_002_VAR);
			
            if (ANIM_PLUS == true) //bool値[ANIM_PLUS]がtrueだったら。 二つ書くのめんどくさいからまとめた
            {
                if (ANIM_INT1_VAR != 7) //アニメーション変数(1)のInt値が7じゃなかったら。 SDK2ワールドは無限に数値を操作することができた
                {
                    ANIM_001.SetInteger(ANIM_001_VAR, ANIM_INT1_VAR + 1); // アニメーション変数(1)に1を加算。 実際の動作としてはナイトモードの明るさが上がる
                    ANIM_002.SetInteger(ANIM_002_VAR, ANIM_INT2_VAR - 45); // アニメーション変数(2)から45を減算。 ノブの角度変えてるアレ
                }
            }
            else if (ANIM_PLUS == false) //bool値[ANIM_PLUS]がfalseだったら。
            {
                if (ANIM_INT1_VAR != 0) //アニメーション変数(1)のInt値が0じゃなかったら。 
                {
                    ANIM_001.SetInteger(ANIM_001_VAR, ANIM_INT1_VAR - 1); // アニメーション変数(1)から1を減算。 実際の動作としてはナイトモードの明るさが下がる
                    ANIM_002.SetInteger(ANIM_002_VAR, ANIM_INT2_VAR + 45); // アニメーション変数(2)に45を加算。 ノブの角度変えてるアレ
                }
            }
        }
    }
}
