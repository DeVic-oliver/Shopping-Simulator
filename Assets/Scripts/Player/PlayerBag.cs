﻿namespace Assets.Scripts.Player
{
    using Assets.Scripts.ScriptableObjects;
    using TMPro;
    using UnityEngine;

    [RequireComponent(typeof(PlayerItemEquipGateway))]    
    public class PlayerBag : MonoBehaviour
    {
        public static float PlayerMoney { get; private set; }
        public static bool IsShopping { get; private set; }

        [SerializeField] private int _money = 200;
        [SerializeField] private GameObject _playerItemPrefab;


        [Header("UI Settings")]
        [SerializeField] private TextMeshProUGUI _playerMoney;
        [SerializeField] private GameObject _playerUIBagsObject;


        private PlayerItemEquipGateway _playerEquipGateway;
        private Dictionary<int, GameObject> _itemsInBag = new();

        
        public void SetIsShopping(bool value)
        {
            IsShopping = value;

            if(IsShopping)
            {
                IterateThroughItemsListThenSetSellEvent();
            }
            else
            {
                IterateThroughItemsListThenSetEquipEvent();
            }
        }

        private void IterateThroughItemsListThenSetSellEvent()
        {
            foreach (var item in _itemsInBag)
            {
                Button button = item.Value.GetComponent<Button>();
                PlayerBagItem bagItem = item.Value.GetComponent<PlayerBagItem>();
                button.onClick.RemoveAllListeners();
                button.onClick.AddListener(bagItem.SellItemToShopKeeper);
            }
        }

        private void IterateThroughItemsListThenSetEquipEvent()
        {
            foreach (var item in _itemsInBag)
            {
                Button button = item.Value.GetComponent<Button>();
                PlayerBagItem bagItem = item.Value.GetComponent<PlayerBagItem>();
                button.onClick.RemoveAllListeners();
                button.onClick.AddListener(bagItem.EquipItem);
            }
        }

        public void IncreasePlayerMoneyByItemSellPrice(float price)
        {
            PlayerMoney += price;
        }

        public void DecreasePlayerMoneyByItemSellPrice(float price)
        {
            PlayerMoney -= price;
        }

        public void InsertItemIntoBag(SCO_Item itemData)
        {
            InjectComponents(itemData);
            PopulateUIBagsWithObjects();
        }

        private void InjectComponents(SCO_Item itemData)
        {
            GetPlayerItemComponent().ItemData = itemData;
            GetPlayerItemComponent().EquipGateway = _playerEquipGateway;
        }

        private void PopulateUIBagsWithObjects()
        {
            GameObject obj = Instantiate(_playerItemPrefab, _playerUIBagsObject.transform);
            _itemsInBag.Add(obj.GetInstanceID(), obj);
        }

        private PlayerBagItem GetPlayerItemComponent()
        {
            return _playerItemPrefab.GetComponent<PlayerBagItem>();
        }

        private void Awake()
        {
            PlayerMoney = _money;
            _playerEquipGateway = GetComponent<PlayerItemEquipGateway>();
        }

        private void Update()
        {
            _playerMoney.text = PlayerMoney.ToString();
        }
    }
}