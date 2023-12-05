namespace Assets.Scripts.ScriptableObjects
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "SCO_Item", menuName = "Assets/Item", order = 0)]
    public class SCO_Item : ScriptableObject
    {
        public Sprite Sprite;
        public Color Color;
        public int Quantity;
        public float Value;
    }
}