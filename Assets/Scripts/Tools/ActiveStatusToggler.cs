namespace Assets.Scripts.Tools
{
    using UnityEngine;
    
    public class ActiveStatusToggler : MonoBehaviour
    {
        [SerializeField] private KeyCode _actionKey;
        [SerializeField] private GameObject _gameObjectToToggle;

        void Update()
        {
            if (Input.GetKeyDown(_actionKey))
                ToggleGameObjectActiveStatus();
        }

        private void ToggleGameObjectActiveStatus()
        {
            bool newActiveStatus = !_gameObjectToToggle.activeSelf;
            _gameObjectToToggle.SetActive(newActiveStatus);
        }
    }
}