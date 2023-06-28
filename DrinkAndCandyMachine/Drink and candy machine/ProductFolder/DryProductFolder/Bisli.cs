using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;
using DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.DretProductFolder;

namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.DryProductFolder;

public class Bisli : DryProduct
{
    protected static int Amount { get; set; } = 4;
    public Bisli() 
    {
        this.Name = base.Name + " bisli.";
        this.Price = base.Price + 1;
        base.CheckAmount(Amount);

    }
    public override IMemento Save()
    {
        Amount--;  
        return base.Save();
    }
}

