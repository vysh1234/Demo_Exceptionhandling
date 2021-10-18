using System;

namespace Demo_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                //Console.WriteLine("Enter your fav num");
                //string No = Console.ReadLine();
                //INT32.Parse(No);

                //Console.WriteLine("No you entered {0}. valid integer 32",No);

                throw new StudentNotFoundException("student not found", "V Vaishu");
            }
            catch(StudentNotFoundException s)
            {
                Console.WriteLine("student not found exception"+s.StudentName);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("invalid integer",fe.Source);
                throw;

             
            }
            catch (OverflowException)
            {
                OverflowException a = new OverflowException();
                Console.WriteLine("value you entered is too big");
            }
            catch (Exception)
            {
                Console.WriteLine("some global exception has occured we are working on it..");
            }
            finally
            {
                Console.WriteLine("Hope this object oriented");
            }
            Console.WriteLine("Hello world!");
        }
    }
}
