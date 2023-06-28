
using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;

namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ColdDrinkFolder;

public class CupOfCola : ColdDrink
{
    protected static int Amount { get; set; } = 7;
    public CupOfCola() 
    {
        this.Name = base.Name + " cola.";
        this.Price = base.Price + 3;
        base.CheckAmount(Amount);
    }
    public override IMemento Save()
    {
        Amount--;
        return base.Save();
    }
}
