using Health;
using UnityEngine;

namespace Patterns.State
{
    public sealed class StateProjectileFollow : AbstractState
    {
        [SerializeField] private Transform target;

        [SerializeField] private float maxDistanceDelta;

        public override void Enter() => target = FindObjectOfType<HealthEnemy>().transform;

        public override void DoUpdate()
        {
            transform.LookAt(target);
            transform.Rotate(eulers: Vector3.right * 90f);
            transform.position = Vector3.MoveTowards(current: transform.position, target: target.position, maxDistanceDelta * Time.deltaTime);
        }

        public override void Exit() => target = null;
    }
}