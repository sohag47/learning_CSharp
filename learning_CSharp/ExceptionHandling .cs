using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    public class MyCustomException : Exception
    {
        public MyCustomException() : base("This is a custom exception.") { }

        public MyCustomException(string message) : base(message) { }

        public MyCustomException(string message, Exception innerException) : base(message, innerException) { }
    }
    public static class ExceptionHandling
    {
        public static void Show()
        {
            try
            {
                int a = 10;
                int b = 0;
                if (b == 0)
                {
                    throw new MyCustomException("Attempted to divide by zero using custom exception.");
                }
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
