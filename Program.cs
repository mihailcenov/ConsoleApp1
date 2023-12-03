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
