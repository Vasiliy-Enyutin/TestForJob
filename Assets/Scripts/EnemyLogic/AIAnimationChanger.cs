using Pathfinding;
using UnityEngine;

namespace EnemyLogic
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(AIPath))]
    public class AIAnimationChanger : MonoBehaviour
    {
        private Animator _animator;
        private AIPath _path;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _path = GetComponent<AIPath>();
        }

        private void Update()
        {
            _animator.SetBool("IsReachedDestination", _path.reachedDestination);
            SetAnimatorValues();
        }

        private void SetAnimatorValues()
        {
            Vector2 moveDirection = _path.steeringTarget - transform.position;
            
            _animator.SetFloat("Horizontal", moveDirection.x);
            _animator.SetFloat("Vertical", moveDirection.y);
        }
    }
}
