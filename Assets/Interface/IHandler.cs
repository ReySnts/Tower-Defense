namespace Patterns.ChainOfResponsibility
{
    public interface IHandler<TRequest, THandle>
    {
        public abstract IHandler<TRequest, THandle> Chain(IHandler<TRequest, THandle> handler);

        public abstract void Handle(TRequest request, THandle handle);
    }
}