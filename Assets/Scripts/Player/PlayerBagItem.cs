namespace Assets.Scripts.Player
{
    using Assets.Scripts.Core.Item;
    using UnityEditor.Animations;
    using UnityEngine;
    
    public class PlayerBagItem : Item
    {
        [SerializeField] private PlayerItemEquipGateway _equipGateway;
      

        public void EquipItem()
        {
            EquipGateway.EquipItem(ItemData);
        }

        public void UnequipItem()
        {
            EquipGateway.UnequipItem(ItemData);
        }

        void Start()
        {
            SetPrice();
        }

        protected override void SetPrice()
        {
            _itemPriceTMP.text = GetNumberString(ItemData.ShopkeeperBuyPrice);
        }
    }
}