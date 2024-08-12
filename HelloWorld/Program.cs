// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a the first number pls!");
// declare an first int variable
double myNumber = Convert.ToDouble(Console.ReadLine());
// print the myNumber variable
Console.WriteLine($"First number is {myNumber}");


Console.WriteLine("The second number pls!");
// declare the second int variable
double secondNumber = double.Parse(Console.ReadLine());
Console.WriteLine($"Second number is {secondNumber}");

//add the two number together
double total = myNumber + secondNumber;
Console.WriteLine($"Addition of the numbers {myNumber} and {secondNumber} gives {total}");




Console.ReadKey();

