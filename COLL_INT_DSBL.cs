
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// =============================
// コライダーによって対象を無効化するアレ
// 使用例：ダンボールから出たときにダンボール内部の鏡を無効化する部分
// =============================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class COL_TGL : UdonSharpBehaviour
    {
        [SerializeField] private GameObject OBJ_001 = null;

        public override void OnPlayerTriggerExit(VRCPlayerApi player) // Trigger付いたコライダーから出たら
        {
            if (player == Networking.LocalPlayer) // Local動作用。 コライダーから出た人が自分だったら
            {
                OBJ_001.SetActive(false); //無効化する
            }

        }
    }
}