namespace Assets.Scripts.Player
{
    using Assets.Scripts.Core.Item;
    
    public class PlayerBagItem : Item
    {
        public PlayerItemEquipGateway EquipGateway;
        public PlayerBag ThePlayerBag;


        public void SellItemToShopKeeper()
        {

        }

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