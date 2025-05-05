using System.Threading.Tasks;
using UnityEngine;

namespace Patterns.State
{
    public sealed class StateProjectileStop : AbstractState
    {
        [SerializeField] private AbstractState stateProjectileFollow;

        private bool condition = false;

        public override async void Enter()
        {
            condition = true;
            await Task.Delay(millisecondsDelay: 500);
            condition = false;
        }

        public override void DoUpdate()
        {
            if (!condition) machineState.TransitionTo(stateNext: stateProjectileFollow);
        }

        public override void Exit() { }
    }
}