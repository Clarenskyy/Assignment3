using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
//Code by Clarence Kieth M. Dela Cruz
//BSCPE 1-1
namespace ConversionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select Option of Conversion (1-4);" +
                "\n1. s-m (seconds to minutes) " +
                "\n2. m-h (minutes to hour) " +
                "\n3. h-d (hour to days) " +
                "\n4. d-mths (days to months)" +
                "\nSelect (1-4): ");
            String UserInput = Console.ReadLine();


                if (UserInput == "1")
                {
                    Console.Write("Enter the second/s to convert: ");
                    int UserNum = Convert.ToInt32(Console.ReadLine());
                    int min = 60;
                    int Output;
                    int output2;
                    Output = UserNum / min;
                    output2 = UserNum % min;
                

                    Console.WriteLine(UserNum + " second/s in minute/s is: " + Output + " minute/s and " + output2 + " second/s");
                }
                else
                {
                    if (UserInput == "2")
                    {
                        //m-h
                        Console.Write("Enter the minute/s to convert: ");
                        int UserNum = Convert.ToInt32(Console.ReadLine());
                        int hour = 60;
                        int Output;
                        int output2;
                        Output = UserNum / hour;
                        output2 = UserNum % hour; 
                    Console.WriteLine(UserNum + " minute/s in hour/s is: " + Output + " hour/s and " + output2 + " minute/s");
                    }
                    else
                    {
                        if (UserInput == "3")
                        {
                            //h-d
                            Console.Write("Enter the hour/s to convert: ");
                            int UserNum = Convert.ToInt32(Console.ReadLine());
                            int days = 24;
                            int Output;
                            int output2;
                            Output = UserNum / days;
                            output2 = UserNum % days;   

                            Console.WriteLine(UserNum + " hour/s in day/s is: " + Output + " day/s and " + output2 + " hour/s");
                        }
                        else
                        {
                            if (UserInput == "4")
                            {
                                // d-mths
                                Console.Write("Enter the day/s to convert: ");
                                int UserNum = Convert.ToInt32(Console.ReadLine());
                                int months = 30;
                                int Output;
                                int Output2;
                                Output2 = UserNum % months;
                                Output = UserNum / months;

                                Console.WriteLine(UserNum + " day/s in month/s is : " + Output + " months/s and " + Output2 + " day/s");
                        }
                        else
                        {
                            Console.WriteLine("Hold on there! Seems like your finger slipped.Try picking a number between 1 and 4.");
                                
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
