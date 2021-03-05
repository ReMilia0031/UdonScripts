
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class SW_COMP : UdonSharpBehaviour
    {
        [SerializeField] private MeshCollider OBJ_001;
        [SerializeField] private MeshCollider OBJ_002;
        [SerializeField] private MeshCollider OBJ_003;
        [SerializeField] private MeshCollider OBJ_004;
        [SerializeField] private MeshCollider OBJ_005;
        [SerializeField] private BoxCollider OBJ_006;
        [SerializeField] private BoxCollider OBJ_007;
        [SerializeField] private MeshCollider OBJ_008;
        [SerializeField] private MeshCollider OBJ_009;
        [SerializeField] private MeshCollider OBJ_010;
        [SerializeField] private MeshCollider OBJ_011;
        [SerializeField] private MeshCollider OBJ_012;
        [SerializeField] private MeshCollider OBJ_013;
        [SerializeField] private MeshCollider OBJ_014;
        [SerializeField] private MeshCollider OBJ_015;
        [SerializeField] private MeshCollider OBJ_016;
        [SerializeField] private MeshCollider OBJ_017;
        [SerializeField] private MeshCollider OBJ_018;
        [SerializeField] private MeshCollider OBJ_019;
        [SerializeField] private MeshCollider OBJ_020;
        [SerializeField] private BoxCollider OBJ_021;
        [SerializeField] private BoxCollider OBJ_022;
        [SerializeField] private MeshCollider TBL_001;
        [SerializeField] private MeshCollider TBL_002;
        [SerializeField] private MeshCollider TBL_003;
        [SerializeField] private MeshCollider TBL_004;
        [SerializeField] private MeshCollider TBL_005;
        [SerializeField] private MeshCollider TBL_006;
        [SerializeField] private MeshCollider TBL_007;
        [SerializeField] private MeshCollider TBL_008;
        [SerializeField] private MeshCollider TBL_009;
        [SerializeField] private MeshCollider TBL_010;

        [SerializeField] private GameObject SW_UP;
        [SerializeField] private GameObject SW_DW;

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