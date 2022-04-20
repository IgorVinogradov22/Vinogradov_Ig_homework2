int a;
int n = new Random ().Next (10 , 10000);
Console.WriteLine(n);


if (n < 100)
{
    Console.WriteLine ("третьей цифры нет");
}
if (n > 100 && n < 1000)
{
    a = n % 10;
    Console.WriteLine (a);
}

if (n > 1000 && n < 10000)
{
    a = n % 100;
    a = a / 10;
    Console.WriteLine (a);
}
