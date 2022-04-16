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
                Console.WriteLine($"Shower Tools : {fd1.Name}|Unique Code : {fd1.UniqueCode}| Price: {fd1.Price}| Type : {fd1.TypeProduct}| Company: {fd1.Company}| Expired Date: {fd1.Dt}");
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
       new public static void CheckPrice(string codes)
        {
            var food = ListShowerTools.Find(x => x.UniqueCode == codes);

            if (food != null)
            {
                for (int i = 0; i < ListShowerTools.Count; i++)
                {
                    var fd = ListShowerTools[i];
                    Console.WriteLine($"Shower Tools : {fd.Name} Price : {fd.Price}");
                }
            }
            else
            {
                Console.WriteLine("Masukkan Kode yang benar");
            }
        }



        public static void MenuShowerTools()
        {
        MenuShowerTools:
            Console.WriteLine("Daftar Perintah :\n");
            Console.WriteLine("1. Melihat Rincian Makanan");
            Console.WriteLine("2. Melihat Nama Makanan");
            Console.WriteLine("3. Melihat Harga Makanan");
            Console.WriteLine("4. Melihat Diskon");
            Console.WriteLine("9. Kembali ke Menu Utama\n");


            Console.Write("Input Menu pada List Makanan: ");
            var SelectFoodMenu = int.Parse(Console.ReadLine());
            if (SelectFoodMenu == 1 || SelectFoodMenu == 2 || SelectFoodMenu == 3 || SelectFoodMenu == 4 || SelectFoodMenu == 9)
            {
                switch (SelectFoodMenu)
                {
                    case 1:

                        DisplayData();
                        goto MenuShowerTools;
                    case 2:

                        DisplayName();
                        goto MenuShowerTools;
                    case 3:
                    tryagain:
                        Console.Write("Masukkan kode untuk mengecek harga : ");
                        string inputcode = Console.In.ReadLine();
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

                                Console.Write("Inputan kode anda kurang 4 digit, masukkan ulang.(Y/N) : ");
                                string answer = Console.In.ReadLine();
                                char chrcter = char.Parse(answer);
                                if (chrcter == 'Y')
                                {
                                    goto tryagain;
                                }
                                else if (chrcter == 'N')
                                {
                                    goto MenuShowerTools;
                                }
                            }
                            else
                            {

                            }
                        }
                        goto MenuShowerTools;
                    //if ()
                    //{

                    //}


                    case 4:

                        DisplayDiscount();
                        goto MenuShowerTools;

                    case 9:
                        Program.Main();
                        break;
                    default:
                        break;
                }
            }



        }
        //    private static List<ShowerTools> ListShower = new List<ShowerTools>();
        //    public ShowerTools(string name, string company, string cde, 
        //        string typeprdct, long price, int dsc) : base(name, company, cde, typeprdct, price, dsc) 
        //    {

        //        ListShower.Add(this);
        //    }

        //    public static void MenuShowerTools()
        //    {
        //        Console.WriteLine("Daftar Perintah :\n");
        //        Console.WriteLine("1. Melihat Rincian Makanan");
        //        Console.WriteLine("2. Melihat Nama Makanan");
        //        Console.WriteLine("3. Melihat Harga Makanan");
        //        Console.WriteLine("4. Melihat Diskon");
        //        Console.WriteLine("9. Kembali ke Menu Utama\n");
        //    }

    }
}
