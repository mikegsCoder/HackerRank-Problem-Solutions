// Arrays: Left Rotation
class Solution
{
    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        var effective = a.Length - (d % a.Length);

        var result = new int[a.Length];

        for (int index = 0; index < a.Length; index++)
            result[(index + effective) % a.Length] = a[index];

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
