// See https://aka.ms/new-console-template for more information

using Assignment_Film_Default;

UserInput userInput = new UserInput();
DisplayRuntime runtime = new DisplayRuntime();

string title = userInput.GetTile();
int playTime = userInput.GetPlayTime();
MovieCategory genre = userInput.GetGenre();

if (playTime == 0)
{
    runtime.FilmRuntime(title, genre);
}
else
{
    runtime.FilmRuntime(title, genre, playTime);
}

