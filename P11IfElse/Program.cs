using System.ComponentModel.Design;

Console.WriteLine("Write your age");
var age = Convert.ToInt32(Console.ReadLine());
bool ischild = age <=13;
bool isteenager = age >=13 && age <= 19;
bool isadult = age >= 19;
if (ischild)  
Console.WriteLine("You are a Child", ischild);
if (isteenager)
Console.WriteLine("You are a Teenager", isteenager);
if (isadult)
Console.WriteLine("You are an Adult" , isadult);
Console.WriteLine("Give me another integer.");
int Numberx = Convert.ToInt32(Console.ReadLine());


int GreaterNumber2;
if (age > Numberx)
{
    GreaterNumber2 = age;
}
else
{
    GreaterNumber2 = Numberx;
}
Console.WriteLine(GreaterNumber2);

if (GreaterNumber2 % 2 == 0)
    Console.WriteLine("The greater number is even");
else 
    Console.WriteLine("The greater number is odd");

//P11_1Grades
Console.WriteLine("Write your grade percentage");
double grade = double.Parse(Console.ReadLine());
if (grade >= 90 && grade <= 100)
{
    Console.WriteLine("A");
}
else if (grade >= 80 && grade <= 89)
{
Console.WriteLine("B");
}
else if (grade >= 70 && grade <= 79)
{
    Console.WriteLine("C");
}
else if (grade >= 60 && grade <= 69)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}

//P11_2MinMax

Console.WriteLine("Write any three numbers");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

if (x > y && x > z)
{
    Console.WriteLine("Maximum Number: "+x);
}

if (y > z && y > x)
{
    Console.WriteLine("Maximum Number: "+y);
}

if (z > x && z > y)
{
    Console.WriteLine("Maximum Number: "+z);
}

if (x < y && x < z)
{
    Console.WriteLine("Minimum Number: "+x);
}

if (y < z && y < x)
{
    Console.WriteLine("Minimum Number: "+y);
}

if (z < x && z < y)
{
    Console.WriteLine("Minimum Number: "+z);
}

//P11_3Characters
Console.WriteLine("Enter any single character");
char character = char.Parse(Console.ReadLine());

if (char.IsDigit(character))
{
    Console.WriteLine("It's a digit");
}


else if   (character == 'a' || character == 'A' || character == 'e' || character == 'E' || character == 'i' || character == 'I' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
{
    Console.WriteLine("It's a vowel");
}
else 
{
    Console.WriteLine("It's a consonant");
}
//P11_4Calculator

Console.WriteLine("Enter the first number");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choose an operation ");
char operation = char.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
double number2 = Convert.ToDouble(Console.ReadLine());

if (operation == '+')

{
    Console.WriteLine("Sum of the numbers is " + (number1 + number2));
}

else if (operation == '-')
{
    Console.WriteLine("Subtraction of the numbers is " + (number1 - number2));
}
else if (operation == '*')
{
    Console.WriteLine("Multiplication of the numbers is " + (number1 * number2));
}
else if (operation == '/')
{
    Console.WriteLine("Division of the numbers is " + (number1 / number2));
}
else
{
    Console.WriteLine("Not a valid operation2");
}
//P11_5EvenOrOdd

Console.WriteLine("Enter an integer");
int integer1 = Convert.ToInt32(Console.ReadLine());
int modulo = integer1 % 2;
if (modulo== '0')
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}