
using DrinkAndCandyMachine.ChainOfResponsibility;
using DrinkAndCandyMachine.Drink_and_candy_machine.Memento;
using DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ProductDecorator;

namespace DrinkAndCandyMachine.Drink_and_candy_machine;

public class Machine
{
    private static List<IMemento> History{ get; set; } = new();
    private IHandler NextHandler { get; set; }
    public Machine()
    {
        NextHandler = new PaymentHandler();
    }
    
    public Product? StartProductmentProcedure(Type type, params  Type[] details)
    {
        object? instance = Activator.CreateInstance(type);
        if (type == typeof(HotDrink) && instance != null)
        {

            for (int i = 0; i < details.Length; i++)
            {
                if(instance != null)
                instance = Activator.CreateInstance(details[i], new object[] {instance});
            }                             
        }
        if (instance != null)
        {
            Product? product = (Product)instance;
            product = NextHandler.Handle(product);
            if(product != null)
            History.Add(product.Save());
            return product;
        }
        return null;
    }
    public static void SaveAsFile<T>( string path) where T : ReadAndWrite, new()
    {
        T instance = new();
        instance.WriteFile($"\n\t{DateTime.Now}\n", path);
        History.ForEach(p => instance.WriteFile(p.ToString(), path));
    }

}

