
using DrinkAndCandyMachine.Drink_and_candy_machine.Observer;

namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ProductDecorator;

public class HotDrink : Product
{
    readonly int minQty = 50;
    protected IProvider Provider { get; set; }
    public HotDrink()
    {
        Provider = new ProductProvider();
        this.Name = base.Name + ", hot drink that contains:";
        this.Price = base.Price + 3;    
    }
    protected void CheckAmount(int amount)
    {
        if (amount < minQty)
            Provider.UpdateMessage(Name);
    }
}

