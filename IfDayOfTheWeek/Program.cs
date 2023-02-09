

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);


if (weekDay == 0)
{
    Console.WriteLine("Täna on Pühapäev!");
}

else if (weekDay == 1)
{
    Console.WriteLine("Täna on Esmaspäev!");
}

else if (weekDay == 2)
{
    Console.WriteLine("Täna on Teisipäev!");
}

else if (weekDay == 3)
{
    Console.WriteLine("Täna on kolmapäev");
}

else if (weekDay == 4)
{
    Console.WriteLine("Täna on neljapäev");

}
else if (weekDay == 5)
{
    Console.WriteLine("Täna on Reede");
}

else
{
    Console.WriteLine("Täna on Laupäev");
}

Console.WriteLine("Head päeva!");