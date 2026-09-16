// Max Array Sum 
class Solution
{
    // Complete the maxSubsetSum function below.
    static int maxSubsetSum(int[] arr)
    {
        var list = new List<int>();

        list.Add(arr[0]);
        list.Add(Math.Max(arr[0], arr[1]));

        foreach (var a in arr.Skip(2))
            list.Add(Math.Max(Math.Max(list[list.Count - 2] + a, a), list[list.Count - 1]));

        return list[list.Count - 1];
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int res = maxSubsetSum(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
