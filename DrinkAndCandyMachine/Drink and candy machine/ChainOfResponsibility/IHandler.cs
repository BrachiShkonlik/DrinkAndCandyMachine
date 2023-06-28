

using DrinkAndCandyMachine.Drink_and_candy_machine;

namespace DrinkAndCandyMachine.ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Product? Handle(Product request);
        
    }
}
