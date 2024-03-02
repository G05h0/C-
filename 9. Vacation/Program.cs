
int cntOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup =  Console.ReadLine();
string dayOfWeek = Console.ReadLine();

double totalPrice = 0;

double price = 0;

if (dayOfWeek == "Friday")
{

    if (typeOfGroup == "Students")
    {
        price = 8.45;

        totalPrice = price * cntOfPeople;
    }
    else if (typeOfGroup == "Business")
    {
        price = 10.90;

        totalPrice = price * cntOfPeople;
    }
    else if (typeOfGroup == "Regular")
    {
        price = 15;

        totalPrice = price * cntOfPeople;
    }

}
else if (dayOfWeek == "Saturday")
{
    if (typeOfGroup == "Students")
    {
        price = 9.80;

        totalPrice = price * cntOfPeople;
    }
    else if (typeOfGroup == "Business")
    {
        price = 15.60;

        totalPrice = price * cntOfPeople;
    }
    else if (typeOfGroup == "Regular")
    {
        price = 20;

        totalPrice = price * cntOfPeople;
    }
}
else if (dayOfWeek == "Sunday")
{
    if (typeOfGroup == "Students")
    {
        price = 10.46;

        totalPrice = price * cntOfPeople;
    }
    else if (typeOfGroup == "Business")
    {
        price = 16;

        totalPrice = price * cntOfPeople;
    }
    else if (typeOfGroup == "Regular")
    {
        price = 22.50;

        totalPrice = price * cntOfPeople;
    }
}

if (cntOfPeople >= 30 && typeOfGroup == "Students")
{
    totalPrice = totalPrice - (totalPrice * 0.15);
}

if (cntOfPeople >= 100 && typeOfGroup == "Business")
{
    double discount = price * (cntOfPeople - 10);
    price = price - discount;
}

if (cntOfPeople >= 10 && cntOfPeople <= 20 && typeOfGroup == "Regular")
{
    totalPrice = totalPrice - (totalPrice * 0.05);
}

Console.WriteLine($"Total price: {totalPrice:f2}");