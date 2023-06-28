
using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;

namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ColdDrinkFolder;
public class CupOfJuice : ColdDrink
{
    protected static int Amount { get; set; } = 7;
    public CupOfJuice()
    {
        this.Name = base.Name + " juice.";
        this.Price = base.Price + 2; 
        base.CheckAmount(Amount);
    }
    public override IMemento Save()
    {
        Amount--;
        return base.Save();
    }
}

