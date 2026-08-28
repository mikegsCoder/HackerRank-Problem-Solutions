// Alternating Characters 
class Solution
{
    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s)
    {
        var chr = 'z';
        var counter = 0;

        for (var index = 0; index < s.Length; index++)
        {
            if (s[index] == chr)
                counter++;

            chr = s[index];
        }

        return counter;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = alternatingCharacters(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
