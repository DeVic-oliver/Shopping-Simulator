namespace Assets.Scripts.Tools
{
    using UnityEngine;
    
    public class ActiveStatusToggler : MonoBehaviour
    {
        [SerializeField] protected KeyCode _actionKey;
        [SerializeField] protected GameObject _gameObjectToToggle;

        protected virtual void Update()
        {
            if (Input.GetKeyDown(_actionKey))
                ToggleGameObjectActiveStatus();
        }

        protected virtual void ToggleGameObjectActiveStatus()
        {
            bool newActiveStatus = !_gameObjectToToggle.activeSelf;
            _gameObjectToToggle.SetActive(newActiveStatus);
        }
    }
}