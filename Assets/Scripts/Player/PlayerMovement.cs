namespace Assets.Scripts.Player
{
    using UnityEngine;

    public class PlayerMovement : MonoBehaviour
    {

        [SerializeField] private Rigidbody2D _playerMainRigidbody;
        [SerializeField] private float _speed = 15f;

        private Vector2 _position;


        void Update()
        {
            SetPositionByAxis();
        }

        private void SetPositionByAxis()
        {
            float x = GetMovespeedTimesDeltaTime() * Input.GetAxis("Horizontal");
            float y = GetMovespeedTimesDeltaTime() * Input.GetAxis("Vertical");
            _position = transform.position + new Vector3(x, y, 0);
        }

        private float GetMovespeedTimesDeltaTime()
        {
            return _speed * Time.deltaTime;
        }

        private void FixedUpdate()
        {
            _playerMainRigidbody.MovePosition(_position);
        }
    }
}
