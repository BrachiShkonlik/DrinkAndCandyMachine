
namespace DrinkAndCandyMachine.Drink_and_candy_machine.Observer;
public class DrinkProvider : IProvider
{
    public void UpdateMessage(string productName) => MessageBox.Show($"{productName} goes to finish.");
}
