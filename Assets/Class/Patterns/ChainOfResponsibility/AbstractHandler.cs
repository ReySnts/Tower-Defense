using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public abstract class AbstractHandler<TRequest, THandle> : MonoBehaviour
    {
        protected AbstractHandler<TRequest, THandle> handlerNext;

        public AbstractHandler<TRequest, THandle> Chain(AbstractHandler<TRequest, THandle> handlerNext)
        {
            this.handlerNext = handlerNext;
            return handlerNext;
        }

        public virtual void Handle(TRequest request, THandle handle) => handlerNext?.Handle(request, handle);
    }
}