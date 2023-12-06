namespace Assets.Scripts.Shopkeeper
{
    using Assets.Scripts.Player;
    using UnityEngine;
    using UnityEngine.Events;

    public class Shop : MonoBehaviour
    {
        public UnityEvent OnSuccessSell;
        public UnityEvent OnFailSell;

        [SerializeField] private PlayerBag _playerBag;


        public void SellToPlayer(ShopkeeperItem item)
        {
            if(PlayerBag.PlayerMoney >= item.ItemData.ShopkeeperSellPrice)
            {
                _playerBag.DecreasePlayerMoneyByItemSellPrice(item.ItemData.ShopkeeperSellPrice);
                _playerBag.InsertItemIntoBag(item.ItemData);
                OnSuccessSell?.Invoke();
            }
            else
            {
                OnFailSell?.Invoke();
            }
        }
    }
}