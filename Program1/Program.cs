namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region star1
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 9; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);

            Console.Clear();
            #endregion

            #region star2
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);

            Console.Clear();
            #endregion

            #region star3
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 9; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);

            Console.Clear();

            #endregion

            #region star4
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();
            #endregion

            #region star5
            for(int i = 1; i<=5; i++)
            {
                for(int j = 1; j<= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= (2*i)-1;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();
            #endregion

            #region star6
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}