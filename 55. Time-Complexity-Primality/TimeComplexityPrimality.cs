class Solution
{
    // Complete the primality function below.
    static string primality(int n)
    {
        if (n == 1) return "Not prime";
        if (n < 4) return "Prime";

        for (var index = 2; index <= Math.Sqrt(n); index++)
            if (n % index == 0)
                return "Not prime";

        return "Prime";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var temp = Console.ReadLine();

        int p = Convert.ToInt32(temp);

        for (int pItr = 0; pItr < p; pItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string result = primality(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
