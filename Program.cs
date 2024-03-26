using System;

namespace ConversionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select Option of Conversion (1-4);" +
                "\n1. s-m (seconds - minutes) " +
                "\n2. m-h (minutes to hour) " +
                "\n3. h-d (hour to days) " +
                "\n4. d-mths (days to months)" +
                "\nSelect (1-4): ");
            String UserInput = Console.ReadLine();
            if (UserInput == "1") 
            {
                Console.Write("Enter the second/s to convert: ");
                double UserNum = Convert.ToInt32(Console.ReadLine());
                double min = 60;
                double Output;
                Output = UserNum / min;

                Console.WriteLine(UserNum + " second/s in minute/s is " + Output + " minute/s" );
            }
            else
            {
                if (UserInput == "2")
                {
                    //m-h
                    Console.Write("Enter the minute/s to convert: ");
                    double UserNum = Convert.ToInt32(Console.ReadLine());
                    double hour = 60;
                    double Output;
                    Output = UserNum / hour;

                    Console.WriteLine(UserNum + " minute/s in hour/s is " + Output + " hour/s");
                }
                else
                {
                    if (UserInput == "3") 
                    {
                        //h-d
                        Console.Write("Enter the hour/s to convert: ");
                        double UserNum = Convert.ToInt32(Console.ReadLine());
                        double days = 24;
                        double Output;
                        Output = UserNum / days;

                        Console.WriteLine(UserNum + " hour/s in day/s is " + Output + " day/s");
                    }
                    else
                    {
                        if (UserInput == "4")
                            {
                            // d-mths
                            Console.Write("Enter the day/s to convert: ");
                            double UserNum = Convert.ToInt32(Console.ReadLine());
                            double months = 30;
                            double Output;
                            Output = UserNum / months;

                            Console.WriteLine(UserNum + " day/s in month/s is " + Output + " months/s");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option, input ONLY 1-4.");
                            return;
                        }
                    }
                }
            }
        }
    }
}