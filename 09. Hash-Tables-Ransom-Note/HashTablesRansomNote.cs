// Hash Tables: Ransom Note
class Solution
{
    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        var dic = new SortedDictionary<string, int>();

        foreach (var group in magazine.GroupBy(x => x))
            dic.Add(group.Key, group.Count());

        foreach (var word in note.GroupBy(x => x))
        {
            if (!dic.TryGetValue(word.Key, out int count) || word.Count() > count)
            {
                Console.WriteLine("No");
                return;
            }
        }

        Console.WriteLine("Yes");
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
