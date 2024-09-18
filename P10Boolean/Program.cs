Console.WriteLine("Write your age" );
var age = Convert.ToInt32(Console.ReadLine());
bool isChild=(age<=12);
bool isteenager = (age >=13 && age<=19);
bool isAdult = (age >= 19);
Console.WriteLine("You are a child: "+ isChild);
Console.WriteLine("You are a teenager: "+ isteenager);
Console.WriteLine("You are an adult" + isAdult);
