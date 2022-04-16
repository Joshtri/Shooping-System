using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooping_System
{
    internal class ShowerTools : Foods
    {
        private static List<ShowerTools> ListShowerTools = new List<ShowerTools>();
        public ShowerTools(string nme, string cmpny, string code, string typeprdc, long price, int disc)
            : base(nme, cmpny, code, typeprdc, price, disc)
        {
            ListShowerTools.Add(this);
        }

        new public static void DisplayData()
        {
            Console.WriteLine("======================================================================================================================");
            for (int i = 0; i < ListShowerTools.Count; i++)
            {

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var fd1 = ListShowerTools[i];
                Console.WriteLine($"Shower Tools : {fd1.Name}|Unique Code : {fd1.UniqueCode}| Price: {fd1.Price}| Type : {fd1.TypeProduct}| Company: {fd1.Company}| Expired Date: {fd1.dt}");

                Console.ResetColor();


            }
            Console.WriteLine("======================================================================================================================");
        }
        new public static void DisplayName()
        {
            for (int i = 0; i < ListShowerTools.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var fd = ListShowerTools[i];
                Console.WriteLine($"Shower Tools : {fd.Name}");
                Console.ResetColor();
            }
        }

        new public static void DisplayDiscount()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < ListShowerTools.Count; i++)
            {
                var fd = ListShowerTools[i];
                Console.WriteLine($"Shower Tools : {fd.Name}|Unique Code : {fd.UniqueCode}| Price: {fd.Price}| Discount : {fd.Discount}");
                Console.ResetColor();

            }

        }
        new public static void CheckPrice(string inputcode)
        {
            int i = 0;
            while (i < ListShowerTools.Count)
            {
                do
                {
                    Console.WriteLine($"Food : {ListShowerTools[i].Name} price : {ListShowerTools[i].Price}");
                    i++;
                } while (inputcode == ListShowerTools[i].UniqueCode);

                i++;
                if (inputcode.Length != 4)
                {
                repeating:
                    Console.Write("Inputan kode anda kurang 4 digit, masukkan ulang.(Y/N) : ");
                    string answer = Console.In.ReadLine();
                    char chrcter = char.Parse(answer);
                    if (chrcter == 'Y')
                    {

                    }
                    else if (chrcter == 'N')
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Hanya menerima tipe data karakter \"Y\" dan \"N\" ");
                        goto repeating;
                    }
                }
            }



        //public static void MenuShowerTools()
        //{
        



        }

    }
}
