// Sherlock and Anagrams
using System.Text;

class Solution
{
    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s)
    {
        var dict = new Dictionary<string, int>();

        for (var len = 1; len < s.Length; len++)
        {
            for (int index = 0; index <= s.Length - len; index++)
            {
                var key = getKey(s.Substring(index, len));

                if (dict.ContainsKey(key))
                    dict[key]++;
                else
                    dict[key] = 1;
            }
        }

        return dict.Where(x => x.Value > 1).Sum(x => x.Value * (x.Value - 1) / 2);
    }

    static string getKey(string value)
    {
        var sb = new StringBuilder(value.Length);

        foreach (var @char in value.ToCharArray().OrderBy(x => x))
            sb.Append(@char);

        return sb.ToString();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = sherlockAndAnagrams(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
