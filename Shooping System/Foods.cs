using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Shooping_System
{
  
    internal class Foods 
    {
        protected string Name {get; set;}
        protected string Company { get; set; }
        //protected int ExpiredDate;
        protected string UniqueCode { get; set; }
        protected string TypeProduct { get; set; }
        protected long Price { get; set; }
        public DateTime Dt = new DateTime();
        protected int Discount { get; set; }

        private static List<Foods> ListFood = new List<Foods>();
        
        public Foods(string nme, string cmpny/*, DateTime expdte*/, string code, string typeprdct, long price, int diskon)
        {
            Name = nme;
            Company = cmpny;
            //Dt = expdte;
            this.UniqueCode = code;
            TypeProduct = typeprdct;
            Price = price;
            Discount = diskon;

            ListFood.Add(this);
        }

        //default ctor
        //public Foods()
        //{

        //}

        //public void CheckPrice(string code)
        //{
        //    var food = ListFood.Find(x => x.UniqueCode == code);

        //    if (food != null)
        //    {
        //        Console.WriteLine("List Harga : ");
        //        foreach (var item in ListFood)
        //        {
        //            Console.WriteLine($"{item.Name} : Rp.{item.Price}");
        //        }
        //    }
        //}

        public static void DisplayData()
        {
            Console.WriteLine("======================================================================================================================");
            for (int i = 0; i < ListFood.Count; i++)
            {
               
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var fd1 = ListFood[i];
                Console.WriteLine($"Food : {fd1.Name}|Unique Code : {fd1.UniqueCode}| Price: {fd1.Price}| Type : {fd1.TypeProduct}| Company: {fd1.Company}| Expired Date: {fd1.Dt}");
                Console.ResetColor();
               
            }
            Console.WriteLine("======================================================================================================================");
        }
        public static void DisplayName()
        {
            for (int i = 0; i < ListFood.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var fd = ListFood[i];
                Console.WriteLine($"Food : {fd.Name}");
                Console.ResetColor();
            }
        }

        public static void DisplayDiscount()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < ListFood.Count; i++)
            {
                var fd = ListFood[i];
                Console.WriteLine($"Food : {fd.Name}|Unique Code : {fd.UniqueCode}| Price: {fd.Price}| Discount : {fd.Discount}");
                Console.ResetColor();
               
            }

        }
      
        public static void CheckPrice(string codes)
        {

            for (int i = 0; i < ListFood.Count; i++)
            {
                if (codes == ListFood[i].UniqueCode)
                {
                    Console.WriteLine($"Food : {ListFood[i].Name} price : {ListFood[i].Price}");
                }
               
            }
        }
        public static void FoodMenu()
        {
            MenuFoods:
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
                        goto MenuFoods;
                    case 2:
    
                        DisplayName();
                        goto MenuFoods;
                    case 3:
                        tryagain:
                        Console.Write("Masukkan kode untuk mengecek harga : ");
                        string inputcode = Console.In.ReadLine();

                        for (int i = 0; i < ListFood.Count; i++)
                        {
                            if (inputcode == ListFood[i].UniqueCode)
                            {
                                CheckPrice(inputcode);
                                //Console.WriteLine($"Food : {ListFood[i].Name} price : {ListFood[i].Price}");
                            }
                            else if (inputcode.Length != 4)
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
                                    goto MenuFoods;
                                }
                                else
                                {
                                    Console.WriteLine("Hanya bisa input karakter \"Y\" dan \"T\"");
                                }
                            }
                        }
                        goto MenuFoods;

                    case 4:
                     
                        DisplayDiscount();
                        goto MenuFoods;

                    case 9:
                        Program.Main();
                        break;
                    default:
                        break;
                }
            }
        }
        
    }
}
