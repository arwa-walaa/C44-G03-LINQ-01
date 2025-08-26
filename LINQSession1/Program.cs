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
            int number = 12345;
            //Console.WriteLine( IntExtenstion.Reverse(number));
            int y= number.Reverse();
            Console.WriteLine(y);
            #endregion
        }
    }
}
