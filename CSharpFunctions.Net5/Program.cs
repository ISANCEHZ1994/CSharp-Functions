using System;

namespace CSharpFunctions.Net5
{
    internal class Program
    {
        // NOTE: you know the majority of this because you have worked with Java (8)

        static void Main(string[] args)
        {
            // WriteSomething();
            // WriteSomethingSpecifc("Above is the string that the user inputed");
            // Console.WriteLine("");
            Console.WriteLine(Add(10, 5));
            Console.WriteLine(Add( Add(25, 25), Add(25, 25) ));            
            Console.WriteLine(Multiply(100 , 5));
            Console.WriteLine(Multiply( Add( 1, 1), Add( 1, 1) ));
            Console.WriteLine("");
            // Calculate();
            TryCatchExample();

        }

        // <====================== [ Void and Static Methods ] ===================================>
        // In general, static means “associated with the class, not an instance”
        public static void WriteSomething()
        {
            Console.WriteLine("I am SUMMONED from a method..");
            Console.Read(); 
        }

        public static void WriteSomethingSpecifc(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }
        // <======================================================================================>

        // <================== [ Return Value and Parameter Methods ] ============================>
        public static int Add(int param1, int param2)
        {
            return param1 + param2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }        
        // <======================================================================================>

        public static void Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input  = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;

            Console.WriteLine("The result should be: {0}",result);  
        }

        public static void TryCatchExample()
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                // throw;
                Console.WriteLine("Format Exception: Please enter the correct type new time");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow Exception: The number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNul Exception: The value was empty(null)");
            }
            finally
            {
                Console.WriteLine(); 
            }
            
            Console.ReadKey();
        }


    }
}
