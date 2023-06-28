
using System.Text;
namespace DrinkAndCandyMachine.Drink_and_candy_machine;
public class Txt : ReadAndWrite
{
    public override List<string> ReadFile(string path) => File.ReadAllLines(path, Encoding.UTF8).ToList();
    public override void WriteFile(string line, string pathToCopy) => File.AppendAllText(pathToCopy, line);
}

