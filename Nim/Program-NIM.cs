Random random = new Random();
Console.WriteLine("Welcome to Nim!");
Console.WriteLine("|||||||||||||||||||||||| (24)");
int totalNumberofmatches = 24;

Startover:
userInputValidation:
Console.WriteLine("How many matches do you want to draw?");
string userInput = Console.ReadLine();
if (userInput =="" || userInput == "0")
{
    Console.WriteLine("Please enter the valid number");
    goto userInputValidation;
}

int userdrawnmatches = Convert.ToInt32(userInput);
if (userdrawnmatches >= totalNumberofmatches)
{
    Console.WriteLine("the number is too big than " + userdrawnmatches + ".");
    goto userInputValidation;

}

totalNumberofmatches -= userdrawnmatches;

Console.WriteLine(new string('|', totalNumberofmatches) + " (" + totalNumberofmatches + ")");

Console.WriteLine("Now its AI's turn");
chooseAgain:
int aiChoice = random.Next(1, 4);
if (aiChoice > totalNumberofmatches)
{
    goto chooseAgain;
}
else if (aiChoice == totalNumberofmatches)
{
    Console.WriteLine("The AI did the last move. You win!");
    return;
}
else
{
    Console.WriteLine(aiChoice);

    totalNumberofmatches -= aiChoice;
    Console.WriteLine(new string('|', totalNumberofmatches) + " (" + totalNumberofmatches + ")");
}

if (totalNumberofmatches > 1)
{
    goto Startover;
}
else if (totalNumberofmatches == 0)
{
    Console.WriteLine("You lost the game!");
}

else
{
    Console.WriteLine("You lost the game!");
}