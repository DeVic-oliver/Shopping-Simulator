namespace Assets.Scripts.Player
{
    using UnityEngine;

    public class PlayerMovement : MonoBehaviour
    {
        public float HorizontalAxisValue { get; private set; }
        public float VerticalAxisValue { get; private set;}
        public bool IsMoving { get; private set; }

        [SerializeField] private Rigidbody2D _playerMainRigidbody;
        [SerializeField] private float _speed = 15f;

        private Vector2 _position;


        private void Start()
        {
            _position = transform.position;
        }

        void Update()
        {
            HorizontalAxisValue = Input.GetAxis("Horizontal");
            VerticalAxisValue = Input.GetAxis("Vertical");
            
            SetIsMoving();
            
            SetPositionByAxis();
        }

        private void SetIsMoving()
        {
            IsMoving = (HorizontalAxisValue != 0 || VerticalAxisValue != 0);
        }

        private void SetPositionByAxis()
        {
            float x = GetMovespeedTimesDeltaTime() * HorizontalAxisValue;
            float y = GetMovespeedTimesDeltaTime() * VerticalAxisValue;
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
