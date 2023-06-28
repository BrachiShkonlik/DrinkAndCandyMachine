

using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;
using DrinkAndCandyMachine.Drink_and_candy_machine.Observer;

namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.DretProductFolder;

public class DryProduct : Product
{
    readonly int minQty = 5;
    protected IProvider Provider { get; set; }
    public DryProduct()
    {
        Provider = new IngredianceProvider();
        this.Name = base.Name + "Dry product: ";
        this.Price = base.Price + 2;
    }
    protected void CheckAmount(int amount)
    {
        if (amount < minQty)
            Provider.UpdateMessage(Name);
    }
    
    
}

