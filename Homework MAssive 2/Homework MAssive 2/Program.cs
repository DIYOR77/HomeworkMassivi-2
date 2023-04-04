namespace Homework_MAssive_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write(" Massiv ulchamini kiriting ustun: ");
            string m = Console.ReadLine();
            bool isnumber1 = int.TryParse(m, out int number1);

            Console.Write(" Massiv ulchamini kiriting qator: ");
            string n = Console.ReadLine();
            bool isnumber2 = int.TryParse(n, out int number2);

            int[,] arr = new int[number1, number2];

            int max = 0;
            int min = 0;

            if (isnumber1 && isnumber2)
            {

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = random.Next(100);
                        Console.Write(" " + arr[i, j]);
                        if (j == 0 && i == 0) min = arr[0, 0];
                        if (max < arr[i, j]) max = arr[i, j];
                        if (min > arr[i, j]) min = arr[i, j];

                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"{" Max: "}{max}{"  Min: "}{min}");
            }
            else
            {
                if (!isnumber1)
                {
                    Console.WriteLine(" Ustunni  kiritganda hatolikka yo'l qo'ydingiz !");
                }
                else
                {
                    Console.WriteLine(" Qatorni  kiritganda hatolikka yo'l qo'ydingiz !");
                }
            }
            Main(args);
        }
    }
}