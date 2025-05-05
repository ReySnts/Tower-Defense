using System.Threading.Tasks;
using UnityEngine;

namespace Patterns.State
{
    [RequireComponent(requiredComponent: typeof(Rigidbody))]

    public sealed class StateProjectileLaunch : AbstractState
    {
        [SerializeField] private AbstractState stateProjectileRotate;

        [SerializeField] private float speed;

        private Rigidbody rigidBody;

        private bool condition = false;

        protected override void Start()
        {
            base.Start();
            rigidBody = GetComponent<Rigidbody>();
        }

        public override async void Enter()
        {
            transform.Rotate(eulers: Vector3.right * -90f);
            condition = true;
            await Task.Delay(millisecondsDelay: 1000);
            condition = false;
        }

        public override void DoUpdate()
        {
            if (condition) rigidBody.velocity = speed * Time.fixedDeltaTime * Vector3.up;
            else machineState.TransitionTo(stateNext: stateProjectileRotate);
        }

        public override void Exit() => rigidBody.velocity = Vector3.zero;
    }
}