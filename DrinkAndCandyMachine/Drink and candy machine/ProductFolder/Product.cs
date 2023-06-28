

using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;

namespace DrinkAndCandyMachine.Drink_and_candy_machine;

public abstract class Product
{
    public int Price { get; set; }
    public string Name { get; set; }
   
    public Product()
    {
        Name = "Product: ";
        Price = 5;
    }
    public virtual IMemento Save()
    {
        return new ProductMemento(this.Price, this.Name);
    }
}

