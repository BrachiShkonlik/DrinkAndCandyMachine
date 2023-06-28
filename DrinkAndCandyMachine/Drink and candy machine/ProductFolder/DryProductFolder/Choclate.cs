
using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;
using DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.DretProductFolder;
namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.DryProductFolder;
public class Choclate : DryProduct
{
    protected static int Amount { get; set; } = 7;
    public Choclate() 
    {
        this.Name = base.Name + " choclate.";
        this.Price = base.Price + 2; 
        base.CheckAmount(Amount);
    }
    public override IMemento Save()
    {
        Amount--;      
        return base.Save();
    }
}

