using System.Runtime.Intrinsics.Arm;
using System.Threading;

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

            #region LINQ - Aggregate Operators

            #region Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(Result);


            #endregion

            #region Return a list of customers and how many orders each has.

            //var Result = ListGenerator.CustomersList.Select(c => new
            //{
            //    c.CustomerID,
            //    OrderCount = c.Orders.Count()
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Return a list of categories and how many products each has

            //var Result = ListGenerator.ProductsList
            //    .GroupBy(p => p.Category)               // group products by category
            //    .Select(g => new
            //    {
            //        Category = g.Key,                   // category name
            //        Count = g.Count()                   // number of products in that category
            //    })
            //    .ToList();

            //Console.WriteLine("Category -> Product Count:");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product Count: {item.Count}");
            //}


            #endregion

            #region Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);
            #endregion

            #region  Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //int totalChars = ListGenerator.DictionaryWords.Sum(w => w.Length);
            //Console.WriteLine(totalChars);


            #endregion

            #region Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //int shortestLength = ListGenerator.DictionaryWords.Min(w => w.Length);
            //Console.WriteLine(shortestLength);

            #endregion

            #region Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int totalChars = ListGenerator.DictionaryWords.Max(w => w.Length);
            //Console.WriteLine(totalChars);
            #endregion

            #region Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //double averageLength = ListGenerator.DictionaryWords.Average(w => w.Length);
            //Console.WriteLine(averageLength);

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region Sort a list of products by name

            //var Result = ListGenerator.ProductsList.OrderBy(p => p.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(s => s, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Sort a list of products by units in stock from highest to lowest.

            //var Result = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.OrderBy(s => s.Length).ThenBy(s => s);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(s => s.Length).ThenBy(s => s, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = ListGenerator.ProductsList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(s => s.Length).ThenByDescending(s => s, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
           
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.Where(s => s.Length > 1 && s[1] == 'i').Reverse();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion
        }
    }
}
