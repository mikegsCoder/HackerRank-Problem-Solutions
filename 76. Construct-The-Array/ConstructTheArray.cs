// Construct the Array:
class Solution
{
    // Complete the countArray function below.
    static long countArray(int n, int k, int x)
    {
        var picked = x == 1 ? 1L : 0L;
        var notPicked = x == 1 ? 0L : 1L;

        for (var index = 1; index < n; index++)
        {
            var newPicked = notPicked;

            notPicked = (picked * (k - 1) % 1_000_000_007 + notPicked * (k - 2) % 1_000_000_007) % 1_000_000_007;
            picked = newPicked;
        }

        return picked;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nkx = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nkx[0]);

        int k = Convert.ToInt32(nkx[1]);

        int x = Convert.ToInt32(nkx[2]);

        long answer = countArray(n, k, x);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
