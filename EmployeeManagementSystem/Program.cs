
namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Reverse String--");
            Console.WriteLine(ReverseString("Rohith"));


            static string ReverseString (string str)
            {
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);  
                return new string(chars);

            }
            //example of fizzbuzz
             Console.WriteLine("----FizzBuzz--");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


        }


       
      }
}
