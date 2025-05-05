using UnityEngine;

namespace Patterns.State
{
    public abstract class AbstractMachineState : MonoBehaviour
    {
        [SerializeField] private AbstractState stateCurrent;

        private void Start() => stateCurrent.Enter();

        public void TransitionTo(AbstractState stateNext)
        {
            stateCurrent.Exit();
            stateCurrent = stateNext;
            stateNext.Enter();
        }

        private void Update() => stateCurrent.DoUpdate();
    }
}