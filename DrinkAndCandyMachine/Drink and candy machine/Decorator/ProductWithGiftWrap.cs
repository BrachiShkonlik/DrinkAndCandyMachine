
namespace DrinkAndCandyMachine.Drink_and_candy_machine.Decorator;
public class ProductWithGiftWrap: Product
{
    protected Product product;
    public ProductWithGiftWrap(Product product)
    {
        this.product = product;
        this.Name = product.Name + ", has gift wrap";
    }  
}