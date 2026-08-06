// Counting Valleys
class Solution
{
    // Complete the countingValleys function below.
    static int countingValleys(int n, string steps)
    {
        var valleys = 0;
        var deltas = new[] { 1, -1 };
        var directions = new[] { 'U', 'D' };
        var current = 0;

        foreach (var s in steps.ToCharArray())
        {
            if (!directions.Contains(s)) throw new ArgumentException();

            var effective = Array.IndexOf(directions, s);

            var temp = current;

            current += deltas[effective];

            if (current == 0 && temp < 0) valleys++;
        }

        return valleys;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
