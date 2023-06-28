
namespace DrinkAndCandyMachine.Drink_and_candy_machine.Observer;
public class IngredianceProvider : IProvider
{
    public void UpdateMessage(string productName) => MessageBox.Show($"{productName} goes to finish.");
}
