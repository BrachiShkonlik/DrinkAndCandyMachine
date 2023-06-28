
using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;

namespace DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ProductDecorator;

public class HotDrinkWithSugar : HotDrink
{
    protected HotDrink HotDrink;
    protected static int Amount { get; set; } = 100;
    public HotDrinkWithSugar(HotDrink hotDrink)
    {
        this.HotDrink = hotDrink;
        this.Name = hotDrink.Name + " sugar,"; 
        base.CheckAmount(Amount);
    }
    public override IMemento Save()
    {
        Amount--;
        return base.Save();
    }
}

