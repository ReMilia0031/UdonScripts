
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// ========================================
// MeshColliderを無効化してるアレ 量がヤバい
// ========================================

//SW_UP, SW_DWの行はダンボールハウスでのスイッチ操作のため使用。 流用するなら削除するなり

namespace Kotonozaka_Ind
{
    public class SW_COMP : UdonSharpBehaviour
    {
        [SerializeField] private MeshCollider OBJ_001 = null;
        [SerializeField] private MeshCollider OBJ_002 = null;
        [SerializeField] private MeshCollider OBJ_003 = null;
        [SerializeField] private MeshCollider OBJ_004 = null;
        [SerializeField] private MeshCollider OBJ_005 = null;
        [SerializeField] private BoxCollider OBJ_006 = null;
        [SerializeField] private BoxCollider OBJ_007 = null;
        [SerializeField] private MeshCollider OBJ_008 = null;
        [SerializeField] private MeshCollider OBJ_009 = null;
        [SerializeField] private MeshCollider OBJ_010 = null;
        [SerializeField] private MeshCollider OBJ_011 = null;
        [SerializeField] private MeshCollider OBJ_012 = null;
        [SerializeField] private MeshCollider OBJ_013 = null;
        [SerializeField] private MeshCollider OBJ_014 = null;
        [SerializeField] private MeshCollider OBJ_015 = null;
        [SerializeField] private MeshCollider OBJ_016 = null;
        [SerializeField] private MeshCollider OBJ_017 = null;
        [SerializeField] private MeshCollider OBJ_018 = null;
        [SerializeField] private MeshCollider OBJ_019 = null;
        [SerializeField] private MeshCollider OBJ_020 = null;
        [SerializeField] private BoxCollider OBJ_021 = null;
        [SerializeField] private BoxCollider OBJ_022 = null;
        [SerializeField] private MeshCollider TBL_001 = null;
        [SerializeField] private MeshCollider TBL_002 = null;
        [SerializeField] private MeshCollider TBL_003 = null;
        [SerializeField] private MeshCollider TBL_004 = null;
        [SerializeField] private MeshCollider TBL_005 = null;
        [SerializeField] private MeshCollider TBL_006 = null;
        [SerializeField] private MeshCollider TBL_007 = null;
        [SerializeField] private MeshCollider TBL_008 = null;
        [SerializeField] private MeshCollider TBL_009 = null;
        [SerializeField] private MeshCollider TBL_010 = null;

        [SerializeField] private GameObject SW_UP = null;
        [SerializeField] private GameObject SW_DW = null;

        public override void Interact()
        {
            OBJ_001.enabled = !OBJ_001.enabled;
            OBJ_002.enabled = !OBJ_002.enabled;
            OBJ_003.enabled = !OBJ_003.enabled;
            OBJ_004.enabled = !OBJ_004.enabled;
            OBJ_005.enabled = !OBJ_005.enabled;
            OBJ_006.enabled = !OBJ_006.enabled;
            OBJ_007.enabled = !OBJ_007.enabled;
            OBJ_008.enabled = !OBJ_008.enabled;
            OBJ_009.enabled = !OBJ_009.enabled;
            OBJ_010.enabled = !OBJ_010.enabled;
            OBJ_011.enabled = !OBJ_011.enabled;
            OBJ_012.enabled = !OBJ_012.enabled;
            OBJ_013.enabled = !OBJ_013.enabled;
            OBJ_014.enabled = !OBJ_014.enabled;
            OBJ_015.enabled = !OBJ_015.enabled;
            OBJ_016.enabled = !OBJ_016.enabled;
            OBJ_017.enabled = !OBJ_017.enabled;
            OBJ_018.enabled = !OBJ_018.enabled;
            OBJ_019.enabled = !OBJ_019.enabled;
            OBJ_020.enabled = !OBJ_020.enabled;
            OBJ_021.enabled = !OBJ_021.enabled;
            OBJ_022.enabled = !OBJ_022.enabled;
            TBL_001.enabled = !TBL_001.enabled;
            TBL_002.enabled = !TBL_002.enabled;
            TBL_003.enabled = !TBL_003.enabled;
            TBL_004.enabled = !TBL_004.enabled;
            TBL_005.enabled = !TBL_005.enabled;
            TBL_006.enabled = !TBL_006.enabled;
            TBL_007.enabled = !TBL_007.enabled;
            TBL_008.enabled = !TBL_008.enabled;
            TBL_009.enabled = !TBL_009.enabled;
            TBL_010.enabled = !TBL_010.enabled;

            SW_UP.SetActive(!SW_UP.activeSelf);
            SW_DW.SetActive(!SW_DW.activeSelf);

        }
    }
}