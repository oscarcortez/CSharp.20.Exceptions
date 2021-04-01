using System;

namespace Models
{
    public class DivNumbers
    {
        int result;
        public DivNumbers()
        {
            result = 0;
        }

        public void Division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Exception caught: {e}");                
            }
            finally
            {
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
