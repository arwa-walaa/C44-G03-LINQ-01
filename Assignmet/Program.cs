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

            #region LINQ – Transformation Operators

            #region Return a sequence of just the names of a list of products.

            //var Result = ListGenerator.ProductsList.Select(p => p.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words.Select(s => new
            //{
            //    Upper = s.ToUpper(),
            //    Lower = s.ToLower()
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Result = ListGenerator.ProductsList.Select(p => new
            //{
            //   Name = p.ProductName,
            //   Category =  p.Category,
            //   Price = p.UnitPrice
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Select((num, index) => new
            //{
            //    Number = num,
            //    InPlace = (num == index)
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion

            #region  Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Result = numbersA.SelectMany(
            //    a => numbersB,
            //    (a, b) => new { A = a, B = b })
            //    .Where(pair => pair.A < pair.B);

            //Console.WriteLine("pairs where a < b :");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}

            #endregion

            #region Select all orders where the order total is less than 500.00.

            //var Result = ListGenerator.CustomersList
            //    .SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderID, o.Total })
            //    .Where(co => co.Total < 500.00M);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region  Select all orders where the order was made in 1998 or later.

            var Result = ListGenerator.CustomersList
                .SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderID, o.OrderDate })
                .Where(co => co.OrderDate.Year >= 1998);
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            #endregion

            #endregion
        }
    }
}
