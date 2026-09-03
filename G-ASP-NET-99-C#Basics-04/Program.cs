namespace G_ASP_NET_99_C_Basics_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion
            #region Question2
            int[,] shelfCopies =
            {
                {3,5 },
                {1,4},
            };
            Console.WriteLine(shelfCopies[1,0]);
            #endregion

        }
    }
}
