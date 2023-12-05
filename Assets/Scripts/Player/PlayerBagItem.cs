namespace Assets.Scripts.Player
{
    using Assets.Scripts.Core.Item;
    using UnityEditor.Animations;
    using UnityEngine;
    
    public class PlayerBagItem : Item
    {
        [SerializeField] private PlayerItemEquipGateway _equipGateway;
      
        private bool _isEquipped;


        public void ToggleEquipment()
        {
            if(!_isEquipped) 
            { 
                _isEquipped = true;
                _equipGateway.EquipItem(ItemData);
            }
            else
            {
                _isEquipped = false;
                _equipGateway.UnequipItem(ItemData);
            }
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