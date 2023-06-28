
namespace DrinkAndCandyMachine.Drink_and_candy_machine.Decorator;
public class ProductWithBag : Product
{
    protected Product product;
    public ProductWithBag (Product product) 
    {
        this.product = product;
        this.Name = product.Name + ", has a bag";
    }
}