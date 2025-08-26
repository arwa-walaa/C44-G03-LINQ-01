using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSession1
{
    internal static class IntExtenstion
    {

        public static int Reverse(this int number)
        {
           int reverse = 0;
           int Reminder;
          while (number != 0)
          {
                Reminder = number % 10;
                reverse = (reverse * 10) + Reminder;
                number = number / 10;
          }
            return reverse;
        }
    }
}
