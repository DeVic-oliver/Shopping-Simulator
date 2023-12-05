namespace Assets.Scripts.Shopkeeper
{
    using UnityEngine;
    
    public class PlayerDetectorPopUp : MonoBehaviour
    {
        private readonly string _playerTag = "Player";


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (IsPlayerTag(collision))
                Debug.Log("Hello! Wanna buy something!?");
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (IsPlayerTag(collision))
                Debug.Log("Bye! Come back soon!");
        }

        private bool IsPlayerTag(Collider2D collision)
        {
            return collision.CompareTag(_playerTag);
        }

    }
}