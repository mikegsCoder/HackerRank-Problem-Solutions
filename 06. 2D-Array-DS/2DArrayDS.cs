// 2D Array - DS
class Solution
{
    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        var xPattern = new[] { 0, 1, 2, 1, 0, 1, 2 };
        var yPattern = new[] { 0, 0, 0, 1, 2, 2, 2 };

        Func<int, int, int> calculateHourglass = (int x, int y) => {
            var sum = 0;

            for (var i = 0; i < yPattern.Length; i++)
            {
                sum += arr[y + yPattern[i]][x + xPattern[i]];
            }

            return sum;
        };

        var maxSum = int.MinValue;

        for (var y = 0; y < arr.Length - 2; y++)
        {
            for (var x = 0; x < arr[y].Length - 2; x++)
            {
                var temp = calculateHourglass(x, y);

                if (temp > maxSum) maxSum = temp;
            }
        }

        return maxSum;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
