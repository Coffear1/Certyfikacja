
using Certyfikacja;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w Klasyfikacji Skoków Narciarskich");
Console.WriteLine("=========================================");
Console.WriteLine("Wyniki konkursu Pucharu Świata w lotach");
Console.WriteLine();

var skiJumper = new SkiJumpingInFile(string.Empty, string.Empty, string.Empty);
skiJumper.ScoreAdded += SkiJumperScoreAdded;

void SkiJumperScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("Bardzo daleki skok");
}

var name = skiJumper.Name;
var surname = skiJumper.Surname;
var nationality = skiJumper.Nationality;

int counter1 = 0;
while (true)
{


    Console.WriteLine("Podaj imię, nazwisko oraz narodowość skoczka");
    Console.WriteLine();
    name = Console.ReadLine();
    surname = Console.ReadLine();
    nationality = Console.ReadLine();

    int counter = 0;
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Podaj kolejną odległość skoku ");
        var input = Console.ReadLine();
        try
        {
            skiJumper.AddScore(input);

        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
        counter++;
        if (counter == 2)
        {
            break;
        }

    }
    counter1++;
    if(counter1 == 2)
    {
        break;
    }
}
    Console.WriteLine();
    Console.WriteLine("=================================================================");
    var statistics = skiJumper.GetStatistics();
    Console.WriteLine("=====STATYSTYKI=====");
    Console.WriteLine($"Najlepszy skok w konkursie lotów:{statistics.Max}m{skiJumper.Name + skiJumper.Surname}");
    Console.WriteLine($"Najgorszy skok w konkursie lotów:{statistics.Min}m");
    Console.WriteLine($"Średnia skoków w konkursie lotów:{statistics.Average:N2}m");
    Console.WriteLine($"Średnia ocena skoku:{statistics.AverageLetter}");








