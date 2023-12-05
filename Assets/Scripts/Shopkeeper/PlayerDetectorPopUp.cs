namespace Assets.Scripts.Shopkeeper
{
    using UnityEngine;
    using UnityEngine.Events;

    public class PlayerDetectorPopUp : MonoBehaviour
    {
        public UnityEvent OnPlayerDetected;
        public UnityEvent OnPlayerInteraction;
        public UnityEvent OnPlayerOutDetection;

        [SerializeField] private KeyCode _interactionKey;

        private readonly string _playerTag = "Player";
        private bool _isPlayerNeaby;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (IsPlayerTag(collision))
            {
                _isPlayerNeaby = true;
                OnPlayerDetected?.Invoke();
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (IsPlayerTag(collision))
            {
                _isPlayerNeaby = false;
                OnPlayerOutDetection?.Invoke();
            }
        }

        private bool IsPlayerTag(Collider2D collision)
        {
            return collision.CompareTag(_playerTag);
        }

        private void Update()
        {
            if(_isPlayerNeaby && Input.GetKeyDown(_interactionKey))
                OnPlayerInteraction?.Invoke();
        }

    }
}