
Random random = new Random();
Console.WriteLine("Welcome to Nim!");
Console.WriteLine("|||||||||||||||||||||||| (24)");
int TotalNumberofmatches = 24;
Startover:
Console.WriteLine("How many matches do you want to draw?");
string userInput = Console.ReadLine();
int userdrawnmatches =Convert.ToInt32(userInput);


TotalNumberofmatches -= userdrawnmatches;

Console.WriteLine(new string('|', TotalNumberofmatches) + " (" + TotalNumberofmatches+ ")");

Console.WriteLine("Now its AI's turn");
chooseAgain:
int aiChoice = random.Next(1,4);
if (aiChoice > TotalNumberofmatches)
{
    goto chooseAgain;
}
else if (aiChoice == TotalNumberofmatches)
{
    Console.WriteLine("The AI did the last move. You win!");
    return ;
}
else
{
    Console.WriteLine(aiChoice);
    
    TotalNumberofmatches -= aiChoice;
    Console.WriteLine(new string('|', TotalNumberofmatches) + " (" + TotalNumberofmatches + ")");
}

if (TotalNumberofmatches> 1)
{
    goto Startover;
}
else if (TotalNumberofmatches==0)
{
    Console.WriteLine("You lost the game!");
}

else
{
    Console.WriteLine("You lost the game!");
}

