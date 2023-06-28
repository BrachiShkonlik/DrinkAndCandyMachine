

using DrinkAndCandyMachine.Drink_and_candy_machine;

namespace DrinkAndCandyMachine.ChainOfResponsibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler? _nextHandler;
        public virtual Product? Handle(Product request)
        {
            if (this._nextHandler != null)
            {
                Product? tryRequest = this._nextHandler.Handle(request);
                if (tryRequest == null) return null;
                else request = tryRequest;
            }
            return request;            
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
