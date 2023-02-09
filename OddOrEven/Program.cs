Console.WriteLine(" Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

// kas kasutaja sisestatud arv on paaris või paaritu

int result = userNum % 2;


if(result != 0) // != ei ole võrdne
{
    Console.WriteLine("User number is Odd");
}

 else
{
    Console.WriteLine("User number is even");
}

