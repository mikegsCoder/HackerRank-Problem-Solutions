// Pairs
class Solution
{
    // Complete the pairs function below.
    static int pairs(int k, int[] arr)
    {
        Array.Sort(arr);

        var sum = 0;

        for (var index = 0; index < arr.Length; index++)
        {
            var current = arr[index];

            if (Array.BinarySearch(arr, current + k) > -1)
                sum++;
        }

        return sum;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int result = pairs(k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
