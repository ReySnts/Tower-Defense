namespace Patterns.ChainOfResponsibility
{
    public abstract class AbstractHandler<TRequest, THandle>
    {
        protected TRequest request;

        protected AbstractHandler<TRequest, THandle> nextHandler;

        public AbstractHandler(TRequest request) => this.request = request;

        public AbstractHandler<TRequest, THandle> Chain(AbstractHandler<TRequest, THandle> newHandler)
        {
            var lastHandler = this;
            while (lastHandler.nextHandler != null) lastHandler = lastHandler.nextHandler;
            lastHandler.nextHandler = newHandler;
            return this;
        }

        public abstract void Handle(THandle handle);
    }
}