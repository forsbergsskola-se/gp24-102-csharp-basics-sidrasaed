//Final Exercise

Console.WriteLine("Please pass me a seed (integer)");
int seed = int.Parse(Console.ReadLine());
Random rand = new Random(seed);
int number = rand.Next(0,5);
Console.WriteLine($"You entered {number}");
int number2 = rand.Next(0,5);
Console.WriteLine($"You entered {number2}");
int number3 = rand.Next(0,5);
Console.WriteLine($"You entered {number3}");


double numbera = Convert.ToDouble(rand.NextDouble() * 0.5);
Console.WriteLine($"You entered {numbera}");
double numberb = Convert.ToDouble(rand.NextDouble() * 0.5);
Console.WriteLine($"You entered {numberb}");
double numberc = Convert.ToDouble(rand.NextDouble() * 0.5);
Console.WriteLine($"You entered {numberc}");

double numberx = (rand.NextDouble() * 0.5)+0.2;
Console.WriteLine($"You entered {numberx}");
double numbery = (rand.NextDouble() * 0.5)+0.2;
Console.WriteLine($"You entered {numbery}");
double numberz = (rand.NextDouble() * 0.5)+0.2;
Console.WriteLine($"You entered {numberz}");

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double chance = double.Parse(Console.ReadLine());
Random roll = new Random();

for (int i = 1; i <= 5; i++)
{
    double roll1 = roll.NextDouble();
    if (roll1 < chance)
    {
        Console.WriteLine("Crit");
    }
    else
    {
        Console.WriteLine("No Crit");
    }
}


//P12_1Random_Coordinates
//Develop a program that generates random X and Y coordinates for an enemy in a 2D game world with 100x100 coordinates.
//Display these coordinates to the user.

Random randomcord = new Random();

int coordinateX = randomcord.Next(0,100);
int coordinateY = randomcord.Next(0,100);

Console.WriteLine($"coordinate X: {coordinateX}"); 
Console.WriteLine($"coordinate Y: {coordinateY}");

//P12_2Random_Password
//Design a program that generates a random password with 6 characters, digits or symbols.

const String letter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+=-<>,./:;<=>?@[\\]^_`{|}~";
Random randompass = new Random();
char [] password = new char[6];
for (int i = 0; i <6; i++)
{
    password[i] = letter[randompass.Next(letter.Length)];
}
Console.WriteLine(password);

//P12_3Random_Item
//Write a program that simulates item drops in a game. Define five different items, and randomly select an item for the player to acquire.

string[] items = { "a", "b", "c", "d", "e" };
Random randoitems = new Random();
int itempicked = randoitems.Next(items.Length);
Console.WriteLine($"You have picked item  {items[itempicked]}");

//P12_4Random_Chance
//Write a program that has a 10% chance of showing a secret message.
//Otherwise it just displays a message saying to try again.

Random randchance = new Random();
double SecretMessage = randchance.NextDouble();
if (SecretMessage <= 0.1)
{
    Console.WriteLine("Secret Message!");
}
else
{
    Console.WriteLine("Try Again!");
}











