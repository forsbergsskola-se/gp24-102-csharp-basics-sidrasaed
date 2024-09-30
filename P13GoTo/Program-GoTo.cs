//Exercises 13 - Go To

using System.Text;

Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");
Random random = new Random();
int myNumber = random.Next(1, 101);
Console.WriteLine("Write the number you want to pick: ");
GuessTheNumber:
int userNumber = Convert.ToInt32(Console.ReadLine());
if (myNumber > userNumber)
{
    Console.WriteLine("Nope! My number is Greater!");
    goto GuessTheNumber;
}
else if (myNumber < userNumber)
{
    Console.WriteLine("Nope! My number is Smaller!");
    goto GuessTheNumber;
}
else
{
    Console.WriteLine("That's the number! Well played!");
}

//P13_1Dollars
//Write a Program that asks how many Dollars the user wants. Then, the program proceeds to printing that many Dollar Symbols.

Console.WriteLine("How many Dollars the you wants");
int  dollars = Convert.ToInt32(Console.ReadLine());

string dollarstoprint = new string('$',dollars);

if (dollars > 0)
{
    Console.WriteLine("Here are the dollars you want "+dollarstoprint);
   
    
}
else
{
    Console.WriteLine("You don't have enough money!");
}

//13_2Triangle
//Write a program that prints an ASCII Triangle as big as the user desires. Use goto efficiently to write as little code as necessary.
Console.WriteLine("How many lines in the triangle you want to have: ");
int  triangleHeight = Convert.ToInt32(Console.ReadLine());

if (triangleHeight>0)
{
    for (int i = 1; i <= triangleHeight; i++) 
        Console.WriteLine(new string('*', i));
}
else
{
    Console.WriteLine("");
}

//P13_3Pattern
// Write a program that prints the following pretty ASCII pattern of the size that the user desires.
// Use goto efficiently to write as little code as necessary.

//using System.ComponentModel.Design;

Console.WriteLine("Write the desired size of the pattern");
int patternSize = int.Parse(Console.ReadLine());
int a = 0;
startNewRow:
if (a >= patternSize)
{ goto
        endRow;
    
}

for (int j = 0; j < patternSize; j++) 
        if (j % 2 == 0) 
        {
            Console.Write("#");
        }
        else 
        { 
            Console.Write("-");
        }

Console.WriteLine();
a++;
goto startNewRow;

endRow:
Console.WriteLine();
 
   