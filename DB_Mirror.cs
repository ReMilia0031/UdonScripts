
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Kotonozaka_Ind
{
    public class DB_Mirror : UdonSharpBehaviour
    {
        [SerializeField] private GameObject mirror_obj;
        [SerializeField] private GameObject mirror_txt;

        public override void Interact()
        {
            mirror_obj.SetActive(!mirror_obj.activeSelf);
            mirror_txt.SetActive(!mirror_txt.activeSelf);
        }
    }
}