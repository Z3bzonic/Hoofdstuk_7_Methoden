// See https://aka.ms/new-console-template for more information
//Methode Kwadraat die het kwadraat van een ingevoerd getal berekend ( het getal geef je mee als parameter).
//Methode BerekenStraal die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft (de diameter geef je mee als parameter).
//Idem voor omtrek en oppervlakte.
//Methode die het grootste van 2 getallen teruggeeft (beide getallen geef je mee als parameter).
//Methode IsEven die bepaald of een getal even of oneven is (geeft een bool terug die true is indien even).
//Methode IsArmstrong die bepaald of een getal een Armstrong getal is.
//Methode ToonOEvenNummers die alle oneven getallen van 1 tot n toont waarbij n als parameter wordt meegegeven.
//Methode ToonArmstrongNummers die alle Armstrong nummers tot n toont.

//int input = KwadraatBerekening(int.Parse(Console.ReadLine()));
//Console.WriteLine($"Kwadraat van input {input}");
//input = BerekenStraal(int.Parse(Console.ReadLine()));
//Console.WriteLine($"Straal van input {input}");
//input = BerekenOmtrek(int.Parse(Console.ReadLine()));
//Console.WriteLine($"Omtrek van vierkant op basis van één zijde {input}");
//string inputd = ControleerGrootsteGetal(Console.ReadLine(), Console.ReadLine());
//Console.WriteLine($"Grootste van twee cijfers is {inputd}");
//bool input = ControleEvenGetal(int.Parse(Console.ReadLine()));
//Console.WriteLine($"It's {input} that the number is even.");
ToonOnevenNummers(int.Parse(Console.ReadLine()));

int KwadraatBerekening(int input) 
{
    return (int)Math.Pow(input, 2);
}

int BerekenStraal(int input)
{
    return input / 2;
}

int BerekenOmtrek(int input)
{
    return input * 4;
}

string ControleerGrootsteGetal(string input, string input2)
{
    int toStringInput = int.Parse(input);
    int toStringInput2 = int.Parse(input2);
    string grootste = "";
    if (toStringInput > toStringInput2)
    {
        grootste = input;
    }
    else
    {
        grootste = input2;
    }
    return grootste;
}
bool ControleEvenGetal(int input)
{
    bool even = false;
    if (input % 2 == 0) 
    { 
        even = true; 
    }
    return even;
}
//int ControleArmstrongNummer(int input)
//{

//}
void ToonOnevenNummers(int input)
{
    for (int i = 0; i < input; i++)
    {
        if (i%2 != 0)
        {
            Console.Write($"{i} ");
        }
    }
}
//int ToonArmstrongNummers(int input)
//{

//}