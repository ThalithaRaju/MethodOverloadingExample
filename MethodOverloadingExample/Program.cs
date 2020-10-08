using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample
{
    class Program
    {
        public int Add( int a, int b)
            {
            int sum = a + b;
            return sum;
            }
        public int Add(int a,int b,int c)
        {
            int sum = a + b + c;
            return sum;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
           int sum1= obj.Add(10, 20);
           int sum2= obj.Add(12, 34, 45);
            Console.WriteLine("First sum="+sum1);
            Console.WriteLine("Three number sum=" +sum2);
            Console.ReadKey();
        }
    }
}
