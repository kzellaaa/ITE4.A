using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace PROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mensclothes = { "Shirts", "Jeans", "Jackets", "T-shirts" };
            int[] menclothesprice = { 1300, 2500, 3800, 1200 };
            string[] womensclothes = { "Blouse", "Skirt", "Dress", "Top" };
            int[] womensclothesprice = { 1600, 1800, 5000, 1500 };
            string[] sizes = { "Small", "Medium", "Large" };
            string[] accessories = { "Belt", "Hat", "Sunglasses", "Watch" };
            int[] accessoriesprice = { 580, 800, 1400, 2500 };
            double totalprice = 0;
            int choice, item, size, quantity;

            Console.SetWindowSize(130, 50);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            do
            {
                Console.WriteLine("\t\t\t\tWelcome to Catalino & Calderon Fashion Botique");
                Console.WriteLine("\n\n\t\t\t\t\tAvailable Categories \n\t\t\t\t\t1. Men's Clothes \n\t\t\t\t\t2. Women's Clothes \n\t\t\t\t\t3. Accesories \n\t\t\t\t\t4. exit");
                Console.Write("\n\t\t\t\tChoose a category(1-4): ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n\nMen's Clothes");
                        for (int i = 0; i < mensclothes.Length; i++)
                        {
                            Console.WriteLine("\n{0}. {1} - P{2:n0}", i + 1, mensclothes[i], menclothesprice[i]);
                        }
                        Console.Write("\nSelect an item(1-4): ");
                        item = Convert.ToInt32(Console.ReadLine());
                        if (item > 0 && item <= mensclothes.Length)
                        {
                            Console.WriteLine("\n\nAvailable Sizes:");
                            for (int i = 0; i < sizes.Length; i++)
                            {
                                Console.WriteLine("\n{0}. {1}", i + 1, sizes[i]);
                            }
                            Console.Write("\nSelect a Size(1-3): ");
                            size = Convert.ToInt32(Console.ReadLine());
                            if (size > 0 && size <= sizes.Length)
                            {
                                Console.WriteLine($"\n\nYou Selected {sizes[size - 1]} size for {mensclothes[item - 1]}.");
                                Console.Write("\nEnter the Quantity: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                totalprice += menclothesprice[item - 1] * quantity;
                                Console.WriteLine($"\n\nYou Added {quantity} {sizes[size - 1]} {mensclothes[item - 1]} to your cart. Total Price: P{totalprice}");
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Size Selected.");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n\nWomen's Clothes");
                        for (int i = 0; i < womensclothes.Length; i++)
                        {
                            Console.WriteLine("\n{0}. {1} - P{2:n0}", i + 1, womensclothes[i], womensclothesprice[i]);
                        }
                        Console.Write("\nSelect an item(1-4): ");
                        item = Convert.ToInt32(Console.ReadLine());
                        if (item > 0 && item <= womensclothes.Length)
                        {
                            Console.WriteLine("\n\nAvailable Sizes:");
                            for (int i = 0; i < sizes.Length; i++)
                            {
                                Console.WriteLine("\n{0}. {1}", i + 1, sizes[i]);
                            }
                            Console.Write("\nSelect a Size(1-3): ");
                            size = Convert.ToInt32(Console.ReadLine());
                            if (size > 0 && size <= sizes.Length)
                            {
                                Console.WriteLine($"\n\nYou Selected {sizes[size - 1]} size for {womensclothes[item - 1]}.");
                                Console.Write("\nEnter the Quantity: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                totalprice += womensclothesprice[item - 1] * quantity;
                                Console.WriteLine($"\n\nYou Added {quantity} {sizes[size - 1]} {womensclothes[item - 1]} to your cart. Total Price: P{totalprice}");
                            }
                            else
                            {
                                Console.WriteLine("\n\nInvalid Size Selected.");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n\nAccessories");
                        for (int i = 0; i < accessories.Length; i++)
                        {
                            Console.WriteLine("\n{0}. {1} - P{2:n0}", i + 1, accessories[i], accessoriesprice[i]);
                        }
                        Console.Write("\nSelect an accessory(1-4): ");
                        item = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter the Quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        totalprice += accessoriesprice[item - 1] * quantity;
                        Console.WriteLine($"\n\nYou Added {quantity} {accessories[item - 1]} to your cart. Total Price: P{totalprice}");

                        break;
                }
            }
            while (false);
        }
    }
}

