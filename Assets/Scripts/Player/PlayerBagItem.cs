namespace Assets.Scripts.Player
{
    using Assets.Scripts.Core.Item;
    
    public class PlayerBagItem : Item
    {
        public PlayerItemEquipGateway EquipGateway;
        public PlayerBag ThePlayerBag;


        public void SellItemToShopKeeper()
        {
            ThePlayerBag.DeleteItemFromList(gameObject.GetInstanceID());
            ThePlayerBag.IncreasePlayerMoneyByItemSellPrice(ItemData.ShopkeeperBuyPrice);
            Destroy(gameObject);
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