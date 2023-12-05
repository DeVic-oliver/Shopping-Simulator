namespace Assets.Scripts.Player
{
    using UnityEngine;
    
    public class PlayerMovementAnimator : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _movement;
        [SerializeField] private Animator _animator;


        void Update()
        {
            if(_animator.runtimeAnimatorController != null)
            {
                _animator.SetBool("isMoving", _movement.IsMoving);
                _animator.SetFloat("moveX", _movement.HorizontalAxisValue);
                _animator.SetFloat("moveY", _movement.VerticalAxisValue);
            }
        }
    }
}