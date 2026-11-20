// The Time in Words:
class Solution
{
    // Complete the timeInWords function below.
    static string timeInWords(int h, int m)
    {
        var numbers = new[] {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen",
            "twenty",
            "twenty one",
            "twenty two",
            "twenty three",
            "twenty four",
            "twenty five",
            "twenty six",
            "twenty seven",
            "twenty eight",
            "twenty nine"
        };

        if (m == 0) return $"{numbers[h]} o' clock";
        if (m == 30) return $"half past {numbers[h]}";

        var effectiveMinutes = m > 30 ? 60 - m : m;

        var minutes = numbers[effectiveMinutes];

        if (effectiveMinutes == 15)
            minutes = "quarter";
        else if (effectiveMinutes > 1)
            minutes += " minutes";
        else
            minutes += " minute";

        var linker = m > 30 ? "to" : "past";

        if (m > 30) h = (h + 1) % 24;

        return $"{minutes} {linker} {numbers[h]}";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine());

        int m = Convert.ToInt32(Console.ReadLine());

        string result = timeInWords(h, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
