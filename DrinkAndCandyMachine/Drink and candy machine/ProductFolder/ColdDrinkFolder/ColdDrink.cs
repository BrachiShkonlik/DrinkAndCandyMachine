

using DrinkAndCandyMachine.Drink_and_candy_machine.Observer;

namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ColdDrinkFolder;

public class ColdDrink : Product
{
    readonly int minQty = 5;
    protected IProvider Provider { get; set; }
    public ColdDrink() 
    {
        this.Name = base.Name + "Cold drink: ";
        this.Price = base.Price + 1;
        Provider = new DrinkProvider(); 
    
}
    protected void CheckAmount(int amount)
    {
        if (amount < minQty)
            Provider.UpdateMessage(Name);
    }
}
