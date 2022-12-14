Console.WriteLine("Enter a number");
double first_number = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter a number");
double second_number = double.Parse(Console.ReadLine()!);

System.Console.WriteLine("The result is: ");
double result = double.Parse(Console.ReadLine()!);

if (first_number + second_number == result) 
{
    System.Console.WriteLine("The operator is: + ");
}
else if (first_number - second_number == result) 
{
    System.Console.WriteLine("The operator is: - ");
}
else if (first_number * second_number == result)
{
    System.Console.WriteLine("The operator is: * ");
}
else if(first_number / second_number == (int)result)
{
    System.Console.WriteLine("The operator is: / ");
}
if (first_number % second_number == result)
{
    System.Console.WriteLine("The operator is : %");
}
else if( Math.Pow(first_number,second_number) == result)
{
    System.Console.WriteLine("The operator is : ");
}




