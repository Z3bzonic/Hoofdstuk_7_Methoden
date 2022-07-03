using Assignment_Extra__Oefening__Muziek_En_Methoden;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Songs song = new Songs();
MainMenu menu = new MainMenu();
SongSelect songSelect = new SongSelect();
double totaletijd = 0;

// Opmerking! om C af te vangen moet ik 3 keer drukken om B 2 keer , systeem check voor crtl+toets?
while (!Console.KeyAvailable) //Main
{
    menu.MainMenuDisplay();
    if (totaletijd != 0)
    {
        Console.WriteLine($"De song was afgelopen in {Math.Round(totaletijd, 0)} seconden");
    }
    while (!Console.KeyAvailable) // repeat default choice
    {
        song.RandomSong();
    }
    if (Console.ReadKey(true).Key == ConsoleKey.X) //exit catch
    {
        return;
    }
    else 
    {
        Console.Clear();
        totaletijd = songSelect.SelectSong(); // select song and return playtime after completion of the method
    }
} //Main
