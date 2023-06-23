namespace Program
{
    class Legendre
    {
        static void Legendr(int p, int n)
        {
            int sum = 0;
            for (int i = 1; i < n;i++)
            {
                
                double stage = Math.Pow(Convert.ToDouble(p), Convert.ToDouble(i));
                int nums = n / Convert.ToInt32(stage);
                if (stage < nums)
                {
                    sum += nums;
                }
            }
            Console.WriteLine(sum);
        }
        public static int Main()
        {
            Console.WriteLine("Введите p");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (p < 0 || n < 0)
            {
                Console.WriteLine("Числа отризательные");
                return 0;
            }
            else if (p > n)
            {
                Console.WriteLine("Результат 0");
                return 0;
            }
            Legendr(p, n);
            return 0;
        }
    }
}