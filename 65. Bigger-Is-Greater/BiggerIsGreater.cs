// Bigger is Greater
class Solution
{
    // Complete the biggerIsGreater function below.
    static string biggerIsGreater(string w)
    {
        var list = new List<char>();

        for (var i = w.Length - 1; i >= 0; i--)
        {
            if (list.Any(x => x > w[i]))
            {
                var c = list.First(x => x > w[i]);
                list.Remove(c);
                list.Add(w[i]);

                var result = $"{w.Substring(0, i)}{c}";

                list.Sort();
                result += string.Concat(list);
                return result;
            }
            else
                list.Add(w[i]);
        }

        return "no answer";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
