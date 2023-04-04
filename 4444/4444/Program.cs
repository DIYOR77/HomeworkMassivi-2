namespace _4444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int yigindi = 0;

            int[][] arr = new int[random.Next(1,9)][];
       
            for(int i=0;i<arr.Length; i++)
            {
                arr[i]=new int[random.Next(1,9)];
            }

            for (int i=0;i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j]=random.Next(1,9);
                    Console.Write(" "+arr[i][j]);
                }
                Console.WriteLine();
            }

            int[]sum= new int[arr.Length];
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    yigindi += arr[i][j];
                }
                Console.Write($"{" "}{i + 1}{": "}{yigindi}");
                sum[i] = yigindi;
                Console.WriteLine();
            
            }
            for(int i=0;i < sum.Length; i++)
            {
                Console.Write(" " + [i]);
            }
            


        }
    }
}