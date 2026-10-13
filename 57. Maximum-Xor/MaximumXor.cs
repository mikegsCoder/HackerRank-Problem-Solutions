// Maximum Xor
class Solution
{
    class Tree
    {
        Tree left;
        Tree right;

        public void Insert(Tree head, int n)
        {
            for (int i = 31; i >= 0; i--)
            {
                int value = (n >> i) & 1;
                if (value == 0)
                {
                    //move left
                    if (head.left == null)
                        head.left = new Tree();
                    head = head.left;
                }
                else
                {
                    //move right
                    if (head.right == null)
                        head.right = new Tree();
                    head = head.right;
                }
            }
        }

        public uint MaxXor(Tree head, int n)
        {
            uint max = 0;

            for (int i = 31; i >= 0; i--)
            {
                int value = (n >> i) & 1;

                if (value == 0)
                {
                    //move right
                    if (head.right != null)
                    {
                        max += (uint)Math.Pow(2, i);
                        head = head.right;
                    }
                    else
                        head = head.left;
                }
                else
                {
                    //move left
                    if (head.left != null)
                    {
                        max += (uint)Math.Pow(2, i);
                        head = head.left;
                    }
                    else
                        head = head.right;
                }
            }
            return max;
        }
    }

    static int[] maxXor(int[] arr, int[] queries)
    {
        int[] result = new int[queries.Length];
        Tree head = new Tree();

        for (int i = 0; i < arr.Length; i++)
        {
            head.Insert(head, arr[i]);
        }

        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = Convert.ToInt32(head.MaxXor(head, queries[i]));
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int m = Convert.ToInt32(Console.ReadLine());

        int[] queries = new int[m];

        for (int i = 0; i < m; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        int[] result = maxXor(arr, queries);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
