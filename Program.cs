int n=Convert.ToInt32(Console.ReadLine());
int i=0;

if (n>0)
{
    while (i<(n-2))
    {
        i=i+2;
        Console.Write($"{i}, ");
    } 
}
else Console.WriteLine($"{n} должно быть > 0  ");