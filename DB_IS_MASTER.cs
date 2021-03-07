
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// =============================
// マスターであればなんかする、みたいなアレ
// =============================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class DB_MSTR : UdonSharpBehaviour
    {
        [SerializeField] private MeshRenderer OBJ_001 = null;
        [SerializeField] private Material Mat_001 = null;
        [SerializeField] private Material Mat_002 = null;

        public override void OnPlayerJoined(VRCPlayerApi player) //誰かが参加した時
        {
            if (Networking.IsMaster) //Masterであれば
                OBJ_001.material = Mat_002;
            else
                OBJ_001.material = Mat_001;
        }
    }
}