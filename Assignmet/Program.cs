namespace Assignmet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region Find all products that are out of stock.

            //var Result= ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where((digit, index) => digit.Length < index);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Element Operators

            #region Get first Product out of Stock

            //var Result = ListGenerator.ProductsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(Result);
            #endregion

            #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(Result);
            #endregion
            
            #region Retrieve the second number greater than 5 
            
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(n => n > 5).Skip(1).First();
            //Console.WriteLine(Result);



            #endregion


            #endregion

        }
    }
}
