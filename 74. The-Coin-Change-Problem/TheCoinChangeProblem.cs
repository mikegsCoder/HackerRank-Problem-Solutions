// The Coin Change Problem:
class Result
{
    // Complete the 'getWays' function below.

    static List<long> Coins;
    static long?[,] Map;

    public static long getWays(int n, List<long> c)
    {
        c.Sort();
        Coins = c;
        Map = new long?[n, Coins.Count];

        return Count(n, Coins.Count - 1);
    }

    private static long Count(long target, int maxCointIndex)
    {
        if (target == 0) return 1;
        if (target < 0) return 0;
        if (maxCointIndex < 0) return 0;

        if (Map[target - 1, maxCointIndex].HasValue)
            return Map[target - 1, maxCointIndex].Value;

        var sum = Count(target, maxCointIndex - 1) +
            Count(target - Coins[maxCointIndex], maxCointIndex);

        Map[target - 1, maxCointIndex] = sum;

        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<long> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt64(cTemp)).ToList();

        long ways = Result.getWays(n, c);

        textWriter.WriteLine(ways);

        textWriter.Flush();
        textWriter.Close();
    }
}
