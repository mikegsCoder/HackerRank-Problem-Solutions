// Jumping on the Clouds
class Solution
{
    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        var jumps = 0;

        var max = c.Length;

        for (var i = 0; i < max - 1; i++)
        {
            if (i + 2 < max && c[i + 2] == 0) i++;

            if (c[i + 1] == 1) throw new ArgumentException();

            jumps++;
        }

        return jumps;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
        
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
