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
            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Result = Arr.Where((digit, index) => digit.Length < index);
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            #endregion

            #endregion


        }
    }
}
