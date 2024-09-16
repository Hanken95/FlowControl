using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public enum PriceGroup
    {
        Child = 0,
        Elder = 0,
        Youth = 80,
        Retiree = 90,
        Standard = 120
    }
    public enum PriceGroupMaxAge
    {
        ChildMaxAge = 4,
        YouthMaxAge = 19,
        StandardMaxAge = 64,
        RetireeMaxAge = 100,
    }

    public static class CinemaTools
    {
        public static string MovieTicketPriceCalculator()
        {
            int age = AgeInputHandler();
            Console.Clear();
            if (age <= (int)PriceGroupMaxAge.ChildMaxAge)
            {
                return $"Child price: {(int)PriceGroup.Child}kr";
            }
            else if (age > (int)PriceGroupMaxAge.RetireeMaxAge)
            {
                return $"Elder price: {(int)PriceGroup.Elder}kr";
            }
            if (age <= (int)PriceGroupMaxAge.YouthMaxAge)
            {
                return $"Youth price: {(int)PriceGroup.Youth}kr";
            }
            else if (age > (int)PriceGroupMaxAge.StandardMaxAge)
            {
                return $"Retiree price: {(int)PriceGroup.Retiree}kr";
            }
            else
            {
                return $"Standard price: {(int)PriceGroup.Standard}kr";
            }
        }

        public static string MovieTicketPriceCalculatorForGroup()
        {
            Console.Clear();


            int amountOfPeople = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of people that are gonna attend");
                if (int.TryParse(Console.ReadLine(), out amountOfPeople))
                {
                    if (amountOfPeople > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Cannot be less than 1 person");
                        Console.WriteLine("Press a key to restart age input");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong input. Press a key to restart age input");
                    Console.ReadKey();
                }
            }


            int totalPrice = 0;
            foreach (int age in AgesOfGroupInputHandler(amountOfPeople))
            {
                if (age <= (int)PriceGroupMaxAge.ChildMaxAge)
                {
                    totalPrice += (int)PriceGroup.Child;
                }
                else if (age > (int)PriceGroupMaxAge.RetireeMaxAge)
                {
                    totalPrice += (int)PriceGroup.Elder;
                }
                else if (age <= (int)PriceGroupMaxAge.YouthMaxAge)
                {
                    totalPrice += (int)PriceGroup.Youth;
                }
                else if (age > (int)PriceGroupMaxAge.StandardMaxAge)
                {
                    totalPrice += (int)PriceGroup.Retiree;
                }
                else
                {
                    totalPrice += (int)PriceGroup.Standard;
                }
            }

            Console.Clear();

            return $"Number of people: {amountOfPeople}" +
                $"\nTotal price for everyone: {totalPrice}";
        }

        private static int AgeInputHandler()
        {
            int age = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the age of the person");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (age >= 0 && age < 150)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Age can only be from 0 to 150");
                        Console.WriteLine("Press a key to restart age input");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong input. Press a key to restart age input");
                    Console.ReadKey();
                }
            }

            return age;
        }
        
        private static List<int> AgesOfGroupInputHandler(int numberOfPeople)
        {
            List<int> ages = new List<int>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                int age;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Enter the age of person number {i + 1}");
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        if (age >= 0 && age < 150)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Age can only be between 0 and 150");
                            Console.WriteLine("Press a key to restart age input");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Wrong input. Press a key to restart age input");
                        Console.ReadKey();
                    }
                }
                ages.Add(age);
            }

            return ages;
        }
    }
}
