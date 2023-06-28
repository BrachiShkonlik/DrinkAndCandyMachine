
namespace DrinkAndCandyMachine.Drink_and_candy_machine;
public abstract class ReadAndWrite
{
    public abstract List<string> ReadFile(string path);
    public abstract void WriteFile(string line, string pathToCopy);

}

