// Extra Long Factorials
class Solution
{
    // Complete the extraLongFactorials function below.
    static void extraLongFactorials(int n)
    {
        var result = System.Numerics.BigInteger.One;

        for (var index = 2; index <= n; index++)
            result *= index;

        Console.WriteLine(result);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        extraLongFactorials(n);
    }
}
