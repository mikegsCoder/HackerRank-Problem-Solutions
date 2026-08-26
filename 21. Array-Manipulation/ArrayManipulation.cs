// Array Manipulation
class Solution
{
    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        var arr = new long[n + 1];

        for (var index = 0; index < arr.Length; index++)
        {
            arr[index] = 0;
        }

        long x = 0;
        long max = 0;

        foreach (var query in queries)
        {
            arr[query[0]] += query[2];
            if ((query[1] + 1) <= n) arr[query[1] + 1] -= query[2];
        }

        for (var index = 0; index < arr.Length; index++)
        {
            x += arr[index];
            if (max < x) max = x;
        }

        return max;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
