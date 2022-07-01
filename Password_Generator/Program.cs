// See https://aka.ms/new-console-template for more information


using Password_Generator;

UserInput input = new UserInput();
Randomizer randomizer = new Randomizer();

int baseNumber = input.GetUserInput();
char[] passwordGen = randomizer.MakeRandomPassword(baseNumber);
string password = new string(passwordGen);
Console.WriteLine(password);

