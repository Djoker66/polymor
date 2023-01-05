using System;

namespace Polymor_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nb1 = new Notebook { Name = "Lenovo", Price = 3000, Ram = 2, Storage = 1000 };
            var nb2 = new Notebook { Name = "HP", Price = 2000, Ram = 2, Storage = 300 };
            var nb3 = new Notebook { Name = "Mac", Price = 5000, Ram = 4, Storage = 2000 };
            var nb4 = new Notebook { Name = "Asus", Price = 1000, Ram = 6, Storage = 500 };

            var ph1 = new Phone { Name = "OnePlus", Price = 1000, Camera = 15, SimCount = 2 };
            var ph2 = new Phone { Name = "Nokia", Price = 300, Camera = 10, SimCount = 1 };
            var ph3 = new Phone { Name = "Samsung", Price = 2000, Camera = 20, SimCount = 2 };
            var ph4 = new Phone { Name = "Xiaomi", Price = 500, Camera = 8, SimCount = 1 };

            Product[] products = { nb1, nb2, nb3, nb4, ph1, ph2, ph3, ph4 };

            string select;

            do
            {
                Console.WriteLine("\nMenu\n");

                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Telefonlara bax");
                Console.WriteLine("4. Notebooklarin sayina bax");
                Console.WriteLine("5. Telefonlarin sayina bax");
                Console.WriteLine("6. Notebooklarin ortalama qiymetine bax");
                Console.WriteLine("7. Telefonlarin ortalama qiymetine bax");
                Console.WriteLine("0. Cix\n");

                select = Console.ReadLine();

                switch (select)
                {
                    case "1":
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine("Name - " + products[i].Name + "; " + " Price - " + products[i].Price);
                        }
                    break;
                    case "2":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                var notebooks = products[i] as Notebook;
                                Console.WriteLine("Name - " + notebooks.Name + "; Price - " + notebooks.Price + 
                                    "; Ram - " + notebooks.Ram + "; Storage - " + notebooks.Storage);
                            }
                        }
                    break; 
                    case "3":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                            {
                                var phones = products[i] as Phone;
                                Console.WriteLine("Name - " + phones.Name + "; Price - " + phones.Price +
                                    "; Camera - " + phones.Camera + "; SimCount - " + phones.SimCount);
                            }
                        }
                    break;
                    case "4":
                        int notecount = 0;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                notecount++;
                            }
                        }
                        Console.WriteLine("Notebook sayi: " + notecount);
                    break;
                    case"5":
                        int phonecount = 0;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                            {
                                phonecount++;
                            }
                        }
                        Console.WriteLine("Phone sayi: " + phonecount);
                    break;
                    case "6":
                        int nbcount = 0;
                        double nbPrice = 0;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                nbPrice = nb1.Price + nb2.Price + nb3.Price + nb4.Price;
                                nbcount++;
                            }
                        }
                        Console.WriteLine("Notebooklarin ortalama qiymeti: " + nbPrice/nbcount);
                    break;
                    case "7":
                        int phcount = 0;
                        double phPrice = 0;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                            {
                                phPrice = ph1.Price + ph2.Price + ph3.Price + ph4.Price;
                                phcount++;
                            }
                        }
                        Console.WriteLine("Telefonlarin ortalama qiymeti: " + phPrice / phcount);
                        break;
                    case "0":
                        Console.WriteLine("Cixdiq");
                    break;
                    default:
                        Console.WriteLine("Yanliw secim etdiniz");
                    break;
                }

            } while (select!="0");

        }
    }
}
