class Solution
{
    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        var temp = new List<int>();
        var pairsCount = 0;

        foreach (var num in ar)
        {
            if (temp.Contains(num))
            {
                temp.Remove(num);
                pairsCount++;
            }
            else
            {
                temp.Add(num);
            }
        }

        return pairsCount;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
