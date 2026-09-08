// Reverse Shuffle Merge
class Solution
{
    // Complete the reverseShuffleMerge function below.
    static string reverseShuffleMerge(string s)
    {
        int a = 'a';
        var m = 'z' - a + 1;
        int[] frequency = Enumerable.Repeat(0, m).ToArray();
        
        foreach (var c in s.ToCharArray())
            frequency[c - a]++;

        var count = new int[m];

        for (var index = 0; index < frequency.Length; index++)
            count[index] = frequency[index] / 2;

        var top = -1;
        var stack = new int[s.Length];

        for (int n = s.Length; --n >= 0;)
        {
            int c = s[n] - a;
            frequency[c]--;

            if (count[c] < 1) continue;

            count[c]--;

            while (top >= 0 &&
                stack[top] > c &&
                frequency[stack[top]] > count[stack[top]])
            {
                count[stack[top--]]++; // Increment and then pop the stack
            }

            stack[++top] = c; // Push c on to the stack
        }

        return string.Concat(stack.Take(top + 1).Select(x => (char)(x + a)));
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = reverseShuffleMerge(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
