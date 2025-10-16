static int fibonacci(int n)
{
    if (n <= 1) return n;
    return fibonacci(n - 1) + fibonacci(n - 2);
}

int n = Convert.ToInt32(Console.ReadLine()) ;

int ans = fibonacci(n);
Console.WriteLine(ans);