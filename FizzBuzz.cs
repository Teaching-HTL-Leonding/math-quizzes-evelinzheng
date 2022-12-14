System.Console.Write("Enter number a: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.Write("Enter number b: ");
int b = int.Parse(Console.ReadLine()!);
System.Console.Write("Enter the limit number n: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    if (i % a== 0 && i%b == 0)
    {
        System.Console.WriteLine("FizzBuzz");
    }
    else if (i % a == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else if (i % b == 0)
    {
        System.Console.WriteLine("Buzz");
    }
    System.Console.WriteLine(i);
}