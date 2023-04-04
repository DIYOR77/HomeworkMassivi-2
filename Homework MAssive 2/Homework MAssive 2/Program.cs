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

            Console.Write(" Nechanchi ustundagi elementnlar ko'payasi va yig'indisi kerak: ");
            string k = Console.ReadLine();
            bool isnumber3 = int.TryParse(k, out int number3);

            int[,] arr = new int[number1, number2];

            int yigindi = 0;
            int kopaytma = 1;

            if (isnumber1 && isnumber2 && isnumber3)
            {
                for (int i = 0; i < number1; i++)
                {
                    for (int j = 0; j < number2; j++)
                    {
                        arr[i, j] = random.Next(1, 9);
                        Console.Write(" " + arr[i, j]);
                        if (j == number3 - 1)
                        {
                            yigindi += arr[i, j];
                            kopaytma *= arr[i, j];
                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"{" " + number3}{"-ustun ko'paymasi: "}{kopaytma}{"   yigindisi: "}{yigindi}");
            }
            else
            {
                if (!isnumber1) Console.WriteLine(" Qatorni kiritishda hatolik bor !");
                if (!isnumber2) Console.WriteLine(" Ustunni kiritishda hatolik bor !");
                if (!isnumber3) Console.WriteLine(" 3 chi kiritgan soningizda xatolik bor !");
            }
            Main(args);
        }
    }
}