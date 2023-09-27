System.Console.WriteLine("Введіть число:");

string input;
int i = 0;
while (true)
{
    input = Console.ReadLine();

    if (int.TryParse(input, out i))
    {
        break;
    }
    else
    {
        System.Console.WriteLine("це не число");
    }
}

// comment

System.Console.WriteLine(i);


