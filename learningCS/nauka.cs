using System.IO.Compression;

internal class Program
{

    public static void PrintTable(List<int> lst)
    {
        Console.WriteLine(string.Join(", ", lst));
    }

    public static void ExamineAge()
    {
        Console.Write("Podaj swoje imię: ");
        string imie = Console.ReadLine()!;

        Console.Write("Podaj rok swojego urodzenia: ");
        string rokTekst = Console.ReadLine()!;

        int rokUrodzenia = int.Parse(rokTekst);
        int obecnyRok = 2026;

        int wiek = obecnyRok - rokUrodzenia;

        Console.WriteLine($"\nCześć, {imie}. Masz około {wiek} lat.");

        if (wiek >= 18)
        {
            Console.WriteLine("Jesteś osobą pełnoletnią!");
        }
        else
        {
            int lataDoPelnoletniosci = 18 - wiek;
            Console.WriteLine($"Jesteś osobą niepełnoletnią. Brakuje ci {lataDoPelnoletniosci} lat do pełnoletności.");
        }
    }

    public static void Menu()
    {
        Console.Write("1.Sprawdzic czy jestes pelnoletni\n2.Zobaczyc jak działają listy\nCo chcesz zrobić: ");
        string Ans = Console.ReadLine()!;

            if (Ans == "1")
        {
            ExamineAge();
        }
            else if (Ans == "2")
        {
            var numbers = new List<int> { 1, 2, 10, 12, 20, 31 };
            PrintTable(numbers);

            numbers.Add(5);
            PrintTable(numbers);
            
            numbers.Remove(3);
            PrintTable(numbers);

            numbers[1] = 10;
            PrintTable(numbers);

            var anotherList = new List<int>(numbers);
            
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            
            Console.WriteLine($"\n{numbers.Count}");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            
            Console.WriteLine();
            numbers.Clear();

        }

    }

    private static void Main(string[] args)
    {
        Menu();
    }
}