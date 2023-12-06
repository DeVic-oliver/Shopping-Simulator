namespace Assets.Scripts.Core.Item
{
    using UnityEngine;
    using Assets.Scripts.ScriptableObjects;
    using TMPro;
    using UnityEngine.UI;

    public abstract class Item : MonoBehaviour
    {
        
        public SCO_Item ItemData;

        [SerializeField] protected Image _itemRenderer;
        [SerializeField] protected TextMeshProUGUI _itemPriceTMP;


        public string GetNumberString(float number)
        {
            return number.ToString();
        }

        protected abstract void SetPrice();

        private void Awake()
        {
            _itemRenderer.sprite = ItemData.Sprite;
        }

    }
}