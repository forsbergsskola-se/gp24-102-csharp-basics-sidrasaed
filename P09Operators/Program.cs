//Final Exercise
Console.WriteLine("Give me a number of seconds");
string userinput = Console.ReadLine();
int Totalsecs = int.Parse(userinput);
int days = Totalsecs/(86400);
int remainingsecs = Totalsecs%(86400);
int hours = remainingsecs / (3600);
remainingsecs  %= (3600) ;
int minutes = remainingsecs / 60;
int seconds = remainingsecs % (60);

Console.WriteLine("Days: " + days);
Console.WriteLine("Hours: " + hours);
Console.WriteLine("Minutes: " + minutes);
Console.WriteLine("Seconds: " + seconds);
Console.WriteLine("D" + days +" "+ "H" + hours +" "+ "M" + minutes +" "+ "S" + seconds);

Console.WriteLine("$In total, that's {floatdays} Days.");
//P09_01SpeedConverter
Console.WriteLine("Write speed in Km/h");
string speed = Console.ReadLine();
double speedperhour = double.Parse(speed);
double Speedpersecond = speedperhour * 5/18;
Console.WriteLine("Speed in m/s " + Speedpersecond);

//P09_02MinutesToSeconds

Console.WriteLine("Please write time in minutes:");
int timeinminutes = int.Parse(Console.ReadLine());
int timeinseconds = timeinminutes * 60;
Console.WriteLine("Time in seconds: " + timeinseconds);

//P09_03Division

Console.WriteLine("Write any two numbers");
int number = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
double number3 = Convert.ToDouble(number);
double number4 = Convert.ToDouble(number2);


double number5 = number3 / number4;

Console.WriteLine("Division:"+ number5);

//P09_04Remainder

Console.WriteLine("Write any two numbers");
int numberx = int.Parse(Console.ReadLine());
int numbery = int.Parse(Console.ReadLine());
int remainder = numberx % numbery;
Console.WriteLine("Remainder:" + remainder);

//P09_05CircleArea
Console.WriteLine("Write the radius of the circle");
double radius = double.Parse(Console.ReadLine());
double radiussquare = radius * radius;
double pi = 3.14159;
double Areaofcircle = radiussquare*pi;
Console.WriteLine("Area of circle: " + Areaofcircle);

//P09_06Negation
Console.WriteLine("Write an integer number");
int integer = int.Parse(Console.ReadLine());
Console.WriteLine(-integer);

//P09_07Product

Console.WriteLine("Write any two numbers");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int multiplication = a * b;
Console.WriteLine("Multiplication:" + multiplication);

//P09_08BMI
Console.WriteLine("Write your weight in kg and height in meters");
double weight= double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double BMI = weight/(height*height);
Console.WriteLine("BMI: " + BMI);

//P09_09Hypotenuse
Console.WriteLine("Write Length of two sides of triangle to know the length of hypotenuse");
double SideA = double.Parse(Console.ReadLine());
double SideB = double.Parse(Console.ReadLine());
double hypotenuse = Math.Sqrt((SideA*SideA) +  (SideB*SideB));
Console.WriteLine("Hypotenuse:" + hypotenuse);


//P09_10SecondsToMinutes
Console.WriteLine("Write time in seconds");
int Seconds = int.Parse(Console.ReadLine());
int Min = Seconds / 60;
int secondsleft= Seconds % 60;
Console.WriteLine( "Minutes: " + Min + " Seconds: " + secondsleft );





