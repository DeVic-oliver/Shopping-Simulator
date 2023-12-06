namespace Assets.Scripts.Player
{
    using Assets.Scripts.Tools;
    using UnityEngine;
    
    public class PlayerBagToggler : ActiveStatusToggler
    {
        protected override void Update()
        {
            if(Input.GetKeyDown(_actionKey) && !PlayerBag.IsShopping)
                ToggleGameObjectActiveStatus();
        }
    }
}