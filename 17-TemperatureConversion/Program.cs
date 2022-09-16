using System;

namespace _17_TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = MenuSystem();

            if (choice == "1")
            {
                double celcius = ConvertCelciusToFahrenheit();
                Console.WriteLine($"{celcius.ToString("F2")} fahrenheit");

            }
            else if (choice == "2")
            {
                double fahrenheit = ConvertFahrenheitToCelcius();
                Console.WriteLine($"{fahrenheit.ToString("F2")} celcius");

            }
            else
            {
                Console.WriteLine("Please Choose option 1 or 2");
            }


            Console.ReadLine();

        }

        static double ConvertCelciusToFahrenheit()
        {
            double celcius = GetDouble();
            return celcius = (celcius * 9 / 5) + 32;

        }

        static double ConvertFahrenheitToCelcius()
        {
            double fahrenheit = GetDouble();
            return fahrenheit = ((fahrenheit - 32) * 5 / 9);

        }
        static double GetDouble()
        {
            Console.WriteLine("enter your number to convert");
            return double.Parse(Console.ReadLine());
        }


        static string MenuSystem()
        {
            Console.WriteLine("Please Choose on of The Following:  ");
            Console.WriteLine("1. Celcius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celcius");
            return Console.ReadLine();
        }



    

    static void Pseudocode()
        {
            // Below is the pseudocode for this task to guide you
            // You may choose to implement this in a different way if you wish
            /* 
                BEGIN Main
                    choice = MainMenu()
                    IF choice = 1 THEN
                        result = CelciusToFahrenheit()
                        PRINT result
                    ELSE IF choice = 2 THEN
                        result = FahrenheitToCelcius()
                        PRINT result
                    ELSE
                        PRINT "Invalid Choice!"
                    END IF
                END Main
                

                BEGIN CelciusToFahrenheit
                    float c = GetTemperature("Celcius")
                    float f = (c * 9/5) + 32
                    RETURN f
                END CelciusToFahrenheit 


                BEGIN FahrenheitToCelcius
                    float f = GetTemperature("Celcius")
                    float c = (f − 32) x 5/9
                    RETURN c
                END FahrenheitToCelcius
                

                BEGIN GetTemperature(unit)
                    PRINT "Enter temperature in " unit
                    INPUT temp
                    RETURN temp
                END GetTemperature
             */

        }
    }
}
