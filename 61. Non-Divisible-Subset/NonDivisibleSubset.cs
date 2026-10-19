// Non-Divisible Subset
class Result
{
     // Complete the 'nonDivisibleSubset' function below.
    public static int nonDivisibleSubset(int k, List<int> s)
    {
        var remainders = new int[k];
        int count = 0;

        s.ForEach(x => remainders[x % k]++);

        for (var j = 1; j <= (k / 2); j++)
        {
            if (j == k - j)
                count++;
            else
                count += Math.Max(remainders[j], remainders[k - j]);
        }

        if (remainders[0] > 0)
            count++;

        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        int result = Result.nonDivisibleSubset(k, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
