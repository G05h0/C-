
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int forthNumber = int.Parse(Console.ReadLine());

int firstOperation = firstNumber + secondNumber;
int secondOperation = firstOperation / thirdNumber;
int thirdOperation = secondOperation * forthNumber;

Console.WriteLine(thirdOperation);