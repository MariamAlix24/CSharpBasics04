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
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region Question3
            printWelcomeMessage();
            #endregion
            #region Question4
            printBookTitle("Clean Code");
            #endregion
            #region Question5
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);// Output: 400 Because int is a value type.when we pass it to the method ,c# sends a copy of the variable pages,not the original one.
            #endregion
            #region Question6
            double[] Prices = { 25.5, 40.0 };
            ApplyDiscount(Prices);
            Console.WriteLine(Prices[0]); // Output: 20.5Because arrays are reference types. When we pass the Prices array to the ApplyDiscount method, we are passing a reference to the original array. Therefore, any changes made to the array inside the method will affect the original array.
            #endregion
        }
        //Question3
        static void printWelcomeMessage()
        {
            Console.WriteLine("Welcome to the library!");
        }
        //Question4
        static void printBookTitle(string title)
        {
            Console.WriteLine("Book Title:" + title);
        }
        //Question5
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        //Question6
        static void ApplyDiscount(double[] Prices)
        {
            Prices[0] -= 5;
        }
    }
}