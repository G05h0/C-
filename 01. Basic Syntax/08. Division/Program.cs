
int age = int.Parse(Console.ReadLine());

if (age % 10 == 0 && age % 2 == 0)
{
    Console.WriteLine("The number is divisible by 10");
}
else if (age % 7 == 0)
{
    Console.WriteLine("The number is divisible by 7");
}
else if (age % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
}
else if (age % 3 == 0)
{
    Console.WriteLine("The number is divisible by 3");
}
else if (age % 2 == 0)
{
    Console.WriteLine("The number is divisible by 2");
}
else
{
    Console.WriteLine("Not divisible");
}
