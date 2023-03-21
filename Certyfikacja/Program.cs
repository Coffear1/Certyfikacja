
using Certyfikacja;

Console.WriteLine("Witamy w Klasyfikacji Skoków Narciarskich");
Console.WriteLine("=========================================");
Console.WriteLine("Wyniki konkursu Pucharu Świata w lotach");
Console.WriteLine();

var skiJumper = new SkiJumpingInMemory("Adam", "Małysz", "Polska");

while (true)
{
    Console.WriteLine("Podaj kolejną odległość skoku ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        skiJumper.AddScore(input);

    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

