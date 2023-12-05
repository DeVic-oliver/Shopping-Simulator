namespace Assets.Scripts.Player
{
    using Assets.Scripts.Core.Enums;
    using Assets.Scripts.ScriptableObjects;
    using UnityEngine;

    public class PlayerItemEquipGateway : MonoBehaviour
    {
        [Header("Head params")]
        [SerializeField] private GameObject _head;
        [SerializeField] private Animator _headController;

        [Header("Outfit params")]
        [SerializeField] private GameObject _outfit;
        [SerializeField] private Animator _outfitController;


        public void EquipItem(SCO_Item ItemData)
        {
            if (IsItemHeadType(ItemData))
            {
                _headController.runtimeAnimatorController = ItemData.HeadAnimatorController;
                _head.SetActive(true);
            }
            else
            {
                _outfitController.runtimeAnimatorController = ItemData.OutfitAnimatorController;
                _outfit.SetActive(true);
            }
        }

        public void UnequipItem(SCO_Item ItemData)
        {
            if (IsItemHeadType(ItemData))
            {
                _headController.runtimeAnimatorController = null;
                _head.SetActive(false);
            }
            else
            {
                _outfitController = null;
                _outfit.SetActive(false);
            }
        }

        private bool IsItemHeadType(SCO_Item ItemData)
        {
            return (ItemData.Type == ItemType.Head);
        }
    }
}