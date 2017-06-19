using System;

namespace SampleConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Product of 10 and 20 is = {0}", ProdNumbers(10, 20));
        }
        
        public static int ProdNumbers(int n1,int n2)
        {
            return n1 * n2;
        }
        public static int DivideNumbers(int n1, int n2)
        {
            int result;
            try
            {
                result = n1 / n2;
            }
            catch
            {
                throw new DivideByZeroException();
            }
            return result;
        }
    }
}
