// Minimum Absolute Difference in an Array
class Solution
{
    // Complete the minimumAbsoluteDifference function below.
    static int minimumAbsoluteDifference(int[] arr)
    {
        Array.Sort(arr);

        var result = int.MaxValue;

        for (int index = 1; index < arr.Length; index++)
        {
            var diff = arr[index] - arr[index - 1];

            if (diff == 0) return 0;
            if (result > diff) result = diff;
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int result = minimumAbsoluteDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
