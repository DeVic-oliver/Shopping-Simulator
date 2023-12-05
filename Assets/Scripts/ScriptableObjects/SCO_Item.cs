namespace Assets.Scripts.ScriptableObjects
{
    using Assets.Scripts.Core.Enums;
    using UnityEditor.Animations;
    using UnityEngine;

    [CreateAssetMenu(fileName = "SCO_Item", menuName = "Assets/Item", order = 0)]
    public class SCO_Item : ScriptableObject
    {
        public ItemType Type;
        public Sprite Sprite;

        [Header("Animator Controllers")]
        public AnimatorController HeadAnimatorController;
        public AnimatorController OutfitAnimatorController;

        [Tooltip("The price that Shopkeeper sells his items")]
        public float ShopkeeperSellPrice;

        [Tooltip("The price that Shopkeeper buys items from the player")]
        public float ShopkeeperBuyPrice;

    }
}