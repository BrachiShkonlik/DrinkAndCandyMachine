
namespace DrinkAndCandyMachine.Drink_and_candy_machine.Memento;
public class ProductMemento : IMemento
{
    public int Price { get; set; }
    public string Name { get; set; }
    public ProductMemento(int price, string name)
    {
        Price = price;
        Name = name;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}.";
    }
}
