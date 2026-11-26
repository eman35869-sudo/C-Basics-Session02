using Assignment_session2.File1;
using System.Numerics;
using System.Timers;
namespace Assignment_session2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            All questions use the same theme: a Book with a Title and Pages. Try each one yourself before
            checking the answer
            
             */


            /*
             Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
              variable of type object. Print it
             */

            Console.WriteLine("Q01 ");
            Book obj = new Book() { Title = "ay haga", Pages = 300 };
            Console.WriteLine(obj.Pages);
            Console.WriteLine(obj.Title);
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            /*
             * 
             * Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
             itself), GetHashCode(), and GetType() on book.
             * */
            Console.WriteLine("Q02");
            Book obj_1 = new Book() { Title = "ay haga", Pages = 300 };
            Book obj_2 = new Book() { Title = "ay haga", Pages = 300 };
            Console.WriteLine(obj_1.ToString());
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj_1.Equals(obj_2));
            Console.WriteLine(obj_1.GetType());
            Console.WriteLine(obj_1.GetHashCode());
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            /*
             * Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
              int pages = "464";
             * */

            // int pages = "464";  ===>>>> compile_time error
            Console.WriteLine("Q03");
            Console.WriteLine("compile_time error example");
            int pages = 454;
            Console.WriteLine(pages);
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            /*
             * Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
              zero", and then prints "Done" in a finally block.
             * */
            Console.WriteLine("Q04");
            int x = 10, y = 0,z;
            try
            {
                z = x / y;
            }
            catch(DivideByZeroException ex) 
            {
                Console.WriteLine(" Cannot divide by zero ");
                //Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            /*Q05. Declare an int pages = 300; then store it in a double variable without using a cast*/
            Console.WriteLine("Q05");
            int pages_1 = 300;
            double pages_2 = pages_1;
            Console.WriteLine(pages_2);
            pages_2 = 500.40;
            pages_1 =(int) pages_2;
            Console.WriteLine(pages_1);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            /*
             * Q06. Declare a double price = 49.99; then convert it into an int using a cast.
             */
            Console.WriteLine("Q06");
            double price = 49.99;
            int price_1 = (int)price;
            Console.WriteLine(price_1);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            /*
             * Q07. Given string pagesText = "464";, convert it into an int using the Convert class
             * */
            Console.WriteLine("Q07");
            string pagesText = "464";
            int pagesText_1 = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesText_1);
            Console.WriteLine(pagesText_1 + 20);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            /*
             * Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
             use int.TryParse() to safely try converting it, and print "Invalid number" if it fails
             * */
            Console.WriteLine("Q08");
            string yearText = "2023";
            int yearText_1 = int.Parse(yearText);
            Console.WriteLine(yearText_1+1);
             string badText = "abc";
            bool b_1 = int.TryParse(badText, out int b_2);
            Console.WriteLine($"b_1={b_1} b_2= {b_2}" );
            if (b_1 == false)
            {
                Console.WriteLine("Invalid number");
            }
          
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            /*
             * Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
             to prove it's now a string.

             * 
             * */
            Console.WriteLine("Q09");
            int pages_33 = 464;
            Console.WriteLine(pages_33.ToString());
            Console.WriteLine(pages_33.ToString()+1);
            Console.WriteLine(pages_33.GetType());

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            /*
             Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
             variable, and print both
             */
            Console.WriteLine("Q10");
            int copies = 100;
            object obj_99 = copies;//boxing
            Console.WriteLine(obj_99);
            int x_3 = (int)obj_99;//undoxing
            Console.WriteLine(x_3);












        }
    }
}
