namespace IterativeStatements
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 0 and 100 to execute a loop:");

            try
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("You have selected the" + args + "series. The numbers between 0 and " + x.ToString() + "are: ");

                for (int i = 0; i <= x; i++)
                {
                    int even = 2 * i;
                    if (even > x)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(even.ToString() + " is an even number");
                    }

                    if ((x >= 1) && (x <= 100))
                    {
                        Console.WriteLine("Executing a For Loop");
                        Console.WriteLine("The For loop will iterate " + x.ToString() + " times");
                        {
                            Console.WriteLine("The value of the variable i is: " + i.ToString());
                        }
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey(true);

                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter a integer value and try again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);

            }
        }

    }
}