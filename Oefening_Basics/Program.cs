// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geef je naam in");
//string naam = Console.ReadLine();
//Console.Clear();
//Console.WriteLine("Geef je leeftijd in");
//int leeftijd = int.Parse(Console.ReadLine());
//Console.Clear();
//Console.WriteLine("Geef je stad in");
//string stad = Console.ReadLine();
//Console.Clear();

DisplayNameAgeCity(stad: "Zemst", naam: "Bart",leeftijd: 39);

void DisplayNameAgeCity(string naam , int leeftijd , string stad) 
{
    Console.WriteLine($"Welkom {naam} met leeftijd {leeftijd} uit {stad}");
}


