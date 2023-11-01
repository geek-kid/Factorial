using System.Runtime.CompilerServices;

int num;

Console.WriteLine("your num?");
try
{
    num = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Bad Input");
    return;
}
Console.WriteLine($"result: {calcfac(num)}");
Console.ReadKey();

static long calcfac(int num) {
    if (num == 0) return 1;
    return num * calcfac(num - 1);
}