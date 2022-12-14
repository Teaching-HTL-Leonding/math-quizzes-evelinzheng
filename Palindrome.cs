System.Console.WriteLine("Enter a positive number");
int number = int.Parse(Console.ReadLine()!);

int entered_number = number;
int modulo_rest;
int summe = 0;

while(number > 0)
{
    modulo_rest = number  % 10;
    summe = (summe * 10) + modulo_rest;
    number /= 10;
}

if(entered_number == summe)
{
    System.Console.WriteLine("Palindrome");
}
else
{
    System.Console.WriteLine("No Palindrome");
}
