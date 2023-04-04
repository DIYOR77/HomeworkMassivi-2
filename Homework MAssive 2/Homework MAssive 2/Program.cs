namespace Homework_MAssive_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();
            Console.Write(" Massiv qatorini kiriting : ");
            string m = Console.ReadLine();
            bool isnumber1 = int.TryParse(m, out int number1);

            Console.Write(" Massiv ustunini ustun: ");
            string n = Console.ReadLine();
            bool isnumber2 = int.TryParse(n, out int number2);

            Console.Write(" K son kiriting: ");
            string k = Console.ReadLine();
            bool isnumber3 = int.TryParse(k, out int number3);

            int[,] arr = new int[number1, number2];

            if (isnumber1 && isnumber2 && isnumber3)
            {
                for (int i = 0; i < number1; i++)
                {
                    for (int j = 0; j < number2; j++)
                    {
                        arr[i, j] = random.Next(1, 9);
                        Console.Write(" " + arr[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < number1; i++)
                {
                    for (int j = 0; j < number2; j++)
                    {
                        if (arr[i, j] == number3)
                        {
                            arr[i, j + 1] = 0;
                        }
                        Console.Write(" " + arr[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                if (!isnumber1) Console.WriteLine(" Qatorni kiritishda hatolik bor !");
                else if (!isnumber2) Console.WriteLine(" Ustunni kiritishda hatolik bor !");
                else Console.WriteLine(" 3 chi kiritgan soningizda xatolik bor !");
            }
            Main(args);



        }
    }
}