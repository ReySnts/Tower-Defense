using UnityEngine;

namespace Patterns.State
{
    [RequireComponent(requiredComponent: typeof(AbstractMachineState))]

    public abstract class AbstractState : MonoBehaviour
    {
        protected AbstractMachineState machineState;

        public abstract void Enter();

        public abstract void DoUpdate();

        public abstract void Exit();

        protected virtual void Start() => machineState = GetComponent<AbstractMachineState>();
    }
}