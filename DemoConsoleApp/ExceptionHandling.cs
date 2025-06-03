using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    public class ExceptionHandling
    {

        public void ExceptionDemo(int[] arr)
        {
			try
			{
				for(int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
			}
			catch (IndexOutOfRangeException ex)
			{
                Console.WriteLine("An error occurred: " + ex.Message);
			}
            catch(ArgumentNullException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {

               Console.WriteLine("Finally block executed");
            }
        }

        public void TooYoungExceptionDemo(Employee person)
        {
            if(person.Age < 18)
            {
                throw new TooYoungException("Employee is too young to work.");
            }
            else
            {
                Console.WriteLine("Employee is old enough to work.");
            }
        }
    }
}
