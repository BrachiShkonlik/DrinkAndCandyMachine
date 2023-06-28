
using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;

namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ProductDecorator;

internal class HotDrinkWithCoffee : HotDrink
{
    protected HotDrink HotDrink;
    protected static int Amount { get; set; } = 200;    
    public HotDrinkWithCoffee(HotDrink hotDrink)
    {
        this.HotDrink = hotDrink;
        this.Name = hotDrink.Name + " coffee,";
        base.CheckAmount(Amount);
    }
    public override IMemento Save()
    {
        Amount--;
        return base.Save();
    }
}