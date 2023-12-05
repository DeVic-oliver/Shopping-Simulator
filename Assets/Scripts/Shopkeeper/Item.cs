namespace Assets.Scripts.Shopkeeper
{
    using UnityEngine;
    using Assets.Scripts.ScriptableObjects;
    using TMPro;
    using UnityEngine.UI;

    public class Item : MonoBehaviour
    {
        
        public SCO_Item ItemData;

        [SerializeField] private Image _itemRenderer;
        [SerializeField] private TextMeshProUGUI _itemQuantityTMP;
        [SerializeField] private TextMeshProUGUI _itemValueTMP;



        void Start()
        {
            _itemRenderer.sprite = ItemData.Sprite;
            _itemQuantityTMP.text = GetNumberString(ItemData.Quantity);
            _itemValueTMP.text = GetNumberString(ItemData.Value);
        }

        private string GetNumberString(float number)
        {
            return number.ToString();
        }

        void Update()
        {

        }
    }
}