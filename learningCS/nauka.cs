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