namespace Assets.Scripts.Shopkeeper
{
    using System.Collections;
    using UnityEngine;
    
    public class ShopkeeperMessages : MonoBehaviour
    {
        [SerializeField] private GameObject _greetingsMessage;
        [SerializeField] private GameObject _successMessage;
        [SerializeField] private GameObject _failMessage;

        [SerializeField] private float _messageTime = 2.5f;

        private Coroutine _currentMessage;


        public void DisplayGreetingsMessage()
        {
            StartCoroutineIfItsAllowed(_greetingsMessage);
        }

        public void DisplaySuccessOnSellMessage()
        {
            StartCoroutineIfItsAllowed(_successMessage);
        }

        public void DisplayFailMessage()
        {
            StartCoroutineIfItsAllowed(_failMessage);
        }

        private void StartCoroutineIfItsAllowed(GameObject gameObj)
        {
            if (ShouldShowMessage())
                StartAndSetCoroutineWithGameObject(gameObj);
        }
        
        private bool ShouldShowMessage()
        {
            return (_currentMessage == null);
        }

        private void StartAndSetCoroutineWithGameObject(GameObject gameObj)
        {
            _currentMessage = StartCoroutine(DisplayGameObject(gameObj));
        }

        private IEnumerator DisplayGameObject(GameObject gameObj)
        {
            gameObj.SetActive(true);
            yield return new WaitForSeconds(_messageTime);
            gameObj.SetActive(false);
            _currentMessage = null;
        }

    }
}