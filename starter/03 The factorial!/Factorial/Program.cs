// See https://aka.ms/new-console-template for more information
//function to calculate factorial
Console.WriteLine(Factorial(4));


static int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}