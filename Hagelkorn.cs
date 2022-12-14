System.Console.Write("Enter a number > 0: ");
int number = int.Parse(Console.ReadLine()!);

while(number != 1)
{
    if (number % 2 == 0)
    {
        number = number/2;
    }
    else
    {
       number = (3 * number) + 1;
    }
    System.Console.Write($"{number} ");
}
