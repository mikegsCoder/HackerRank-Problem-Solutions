// Repeated String
class Solution
{
    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        var fullRepeatCount = n / s.Length;

        var countOriginalText = GetRepeatCount(s);

        int temp = Convert.ToInt32(n - fullRepeatCount * s.Length);

        var countInPartial = GetRepeatCount(s.Substring(0, temp));

        return countOriginalText * fullRepeatCount + countInPartial;
    }

    static int GetRepeatCount(string s) => s.ToCharArray().Count(x => x == 'a');

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
