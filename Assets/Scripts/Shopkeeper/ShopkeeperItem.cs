namespace Assets.Scripts.Shopkeeper
{
    using Assets.Scripts.Core.Item;
    
    public class ShopkeeperItem : Item
    {
        void Start()
        {
            SetPrice();
        }

        protected override void SetPrice()
        {
            _itemPriceTMP.text = GetNumberString(ItemData.ShopkeeperSellPrice);
        }

    }
}