using LINQSession1.Data;

namespace LINQSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Iplicity Type local Variable
            #region Var [Most Recomended]

            //var name = "Hello World";

            ////var x = null; invalid

            //name = null;

            ////name = 123; invalid
            //int x;
            ////var y;
            //var y=5;

            #region Dynamic

            //dynamic data = "Hello World";
            //data = 123;
            //data = true;
            //data = 20.20;

            //dynamic z;
            //dynamic t = null;

            //Console.WriteLine(data);


            #endregion



            #endregion


            #endregion

            #region Extension Methods
            //int number = 12345;
            ////Console.WriteLine( IntExtenstion.Reverse(number));
            //int y= number.Reverse();
            //Console.WriteLine(y);
            #endregion

            #region Anonymous Type

            //Employee employee = new Employee() { id = 1, name = "John", salary = 50000 };
            //object emp1 = new { id = 1, name = "John", salary = 50000 };

            // var emp1 = new { id = 1, Name = "John", salary = 50000 };
            // Console.WriteLine(emp1.GetType().Name);

            // var emp2 = new { id = emp1.id, Name = emp1.Name, salary = 60000 };
            // Console.WriteLine(emp2.GetType().Name);
            // var  emp3= new { Id = 10, Name = "Arwa", Salary = 70000 };

            // Console.WriteLine(emp3.GetType().Name);

            //var emp4= new { Id = 20, Name = "Sara", Salary = 80000 ,Age=25};
            // Console.WriteLine(emp4.GetType().Name);

            // Console.WriteLine(emp1);
            // Console.WriteLine(emp2);
            // Console.WriteLine(emp3);
            // Console.WriteLine(emp4);

            #endregion

            #region What is  LINQ
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> OddNumbesr=  Numbers.Where(n => n % 2 != 0).ToList();
            //foreach (var item in OddNumbesr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region LINQ Syntex


            #region Fluent Syntex
            //1. call Linq operator as satatic method
            //Enumerable
            //var OddNumbesr = Enumerable.Where(Numbers, n => n % 2 != 0);

            // foreach (var item in OddNumbesr)
            // {
            //     Console.WriteLine(item);
            // }

            //2.call Linq operator as Extention method
            //var OddNumbesr = Numbers.Where(n => n % 2 != 0);
            //foreach (var item in OddNumbesr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Query Syntex
            //sql like only
            //var OddNumbesr = from n in Numbers
            //                 where n % 2 != 0
            //                 select n;
            //foreach (var item in OddNumbesr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region LINQ Execution Ways
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Deferred Execution
            //var OddNumbesr = Numbers.Where(n => n % 2 != 0);
            // Numbers.AddRange(new List<int>() { 11, 12, 13, 14, 15 });
            //foreach (var item in OddNumbesr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Immediate Execution
            //var OddNumbesr = Numbers.Where(n => n % 2 != 0).ToList();
            //Numbers.AddRange(new List<int>() { 11, 12, 13, 14, 15 });
            //foreach (var item in OddNumbesr)
            //{
            //    Console.WriteLine(item);
            //}

            //casting ,Aggregate Operator,Elemnts Operators

            #endregion

            #endregion

            #region Data Setup
            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(ListGenerator.CustomerList[0]);


            #endregion

            #region Filteration Operator
            //where operator 
            //deferred execution
            #region Get Elment out of stock
            //fluent syntex

            //var outOfStockProducts = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0);
            //query syntex

            //outOfStockProducts = from p in ListGenerator.ProductList
            //                          where p.UnitsInStock == 0
            //                          select p;
            //foreach (var item in outOfStockProducts)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Get product in stock and in category "Meat"

            ////fluent syntex
            //var inStockMeatProducts = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");

            ////query syntex
            //inStockMeatProducts = from p in ListGenerator.ProductList
            //                      where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //                      select p;
            //foreach (var item in inStockMeatProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get from first 10 product ,products are out of stock

            //fluent syntex
            //indexd where
            // var outOfStockProducts = ListGenerator.ProductList.Where((p,I) => I<10 && p.UnitsInStock == 0);

            //foreach (var item in outOfStockProducts)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #endregion

            #region Ordring Operator 
            #region get products Ordered by Price ASC

            ////fluent syntex
            //var productsOrderedByPrice = ListGenerator.ProductList.OrderBy(p => p.UnitPrice);
            ////query syntex
            //productsOrderedByPrice= from p in ListGenerator.ProductList
            //                      orderby p.UnitPrice 
            //                      select p;

            //foreach (var item in productsOrderedByPrice)
            //    {
            //    Console.WriteLine(item);
            //}



            #endregion

            #region get products Ordered by Price DESC

            ////fluent syntex
            //var productsOrderedByPrice = ListGenerator.ProductList.OrderByDescending(p => p.UnitPrice);
            ////query syntex
            //productsOrderedByPrice = from p in ListGenerator.ProductList
            //                         orderby p.UnitPrice descending
            //                         select p;

            //foreach (var item in productsOrderedByPrice)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion
            #endregion
            #region get product ordered by price ASC and number of items in stock
            //fluent syntex
            //var productsOrderedByPrice = ListGenerator.ProductList.OrderBy(p => p.UnitPrice).ThenBy(p=> p.UnitsInStock);
            ////query syntex
            //productsOrderedByPrice = from p in ListGenerator.ProductList
            //                         orderby p.UnitPrice, p.UnitsInStock
            //                         select p;

            //foreach (var item in productsOrderedByPrice)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
