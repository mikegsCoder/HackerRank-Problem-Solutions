// Max Min
class Solution
{
    // Complete the maxMin function below.
    static int maxMin(int k, int[] arr)
    {
        Array.Sort(arr);

        var min = int.MaxValue;

        for (var index = 0; index < arr.Length - k + 1; index++)
            min = Math.Min(min, arr[index + k - 1] - arr[index]);

        return min;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int k = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine());
            arr[i] = arrItem;
        }

        int result = maxMin(k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
