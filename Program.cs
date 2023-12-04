// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World, I AM HERE!");

int i;
for (i = 1; i <= 20; i++)
{
    Console.WriteLine("{0}", i);
}

Console.WriteLine("we are after loop, we executed {0} loops", i);

for (i = 0; i <= 20; i++)
{
    if ((i % 2) == 1)
    {
        Console.WriteLine("{0} is odd number", i);
    }
    else
    {
        Console.WriteLine("{0} is even number", i);
    }
    if ((i % 3) == 0)
    {
        Console.WriteLine("     {0} is multiply of 3",i);
    }

}

int j = 20;

while (j > 0)
{
    Console.WriteLine("{0}", j);
    j--;
}

int k = 25;

do
{
    Console.WriteLine("{0}", k);
    k--;
} while (k >= -10);

int x = 16;

switch (x) {
    case 1:
        Console.WriteLine("the selection is 1");
        break;
    case 2:
        Console.WriteLine("the selection is 2");
        break;
    case 3:
        Console.WriteLine("the selection is 3");
        break;
    case 4:
        Console.WriteLine("the selection is 4");
        break;
    case 5:
        Console.WriteLine("the selection is 5");
        break;
    case 6:
        Console.WriteLine("the selection is 6");
        break;
    case 7:
        Console.WriteLine("the selection is 7");
        break;
    case 8:
        Console.WriteLine("the selection is 8");
        break;
    case 9:
        Console.WriteLine("the selection is 9");
        break;
    case 10:
        Console.WriteLine("the selection is 10");
        break;
    default:
        Console.WriteLine("Something else found: {0}",x);
        break;
}


int n = int.Parse(Console.ReadLine());
for (int row = 1; row <=n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write(col + " ");
    }
    Console.WriteLine();
    
}

//int i;
for (i = 1; i <= 25; i++)
{
    Console.WriteLine("{0}", i);
}
