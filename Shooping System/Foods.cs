using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Shooping_System
{
  
    internal class Foods : IMarket
    {
        protected string name;
        protected string company;
        //protected int ExpiredDate;
        protected string uniqueCode ;
        protected string typeProduct ;
        protected long price ;
        public DateTime dt = new DateTime();
        protected int discount ;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
        public string UniqueCode
        {
            get
            {
                return uniqueCode;
            }
            set
            {
                uniqueCode = value;
            }
        }
        public string TypeProduct
        {
            get
            {
                return typeProduct;
            }
            set
            {
                typeProduct = value;
            }
        }
        public long Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }


        private static List<Foods> ListFood = new List<Foods>();
        
        
        public Foods(string nme, string cmpny/*, DateTime expdte*/, string code, string typeprdct, long price, int diskon)
        {
            Name = nme;
            Company = cmpny;
            //Dt = expdte;
            UniqueCode = code;
            TypeProduct = typeprdct;
            Price = price;
            Discount = diskon;

            ListFood.Add(this);
            //ListFood.Add(this);
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
                    Console.WriteLine($"Food : {fd1.Name}|Unique Code : {fd1.UniqueCode}| Price: {fd1.Price}| Type : {fd1.TypeProduct}| Company: {fd1.Company}| Expired Date: {fd1.dt}");
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
        public static void JustCheckInShop()
        {
            for (int i = 0; i < ListFood.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var fd = ListFood[i];
                Console.WriteLine($"Food : {fd.Name} | Price {fd.Price}");
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

        public static void CheckPrice(string inputcode)
        {

            for (int i = 0; i < ListFood.Count; i++)
            {
                if (inputcode == ListFood[i].UniqueCode)
                {
                    Foods.CheckPrice(inputcode);
                    //Console.WriteLine($"Food : {ListFood[i].Name} price : {ListFood[i].Price}");
                }
                else if (inputcode.Length != 4)
                {
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
                        Console.WriteLine("Hanya bisa input karakter \"Y\" dan \"T\"");
                    }
                }
            }

        }
        //public static void FoodMenu()
        //{
        //MenuFoods:
        //    Console.WriteLine("Daftar Perintah :\n");
        //    Console.WriteLine("1. Melihat Rincian Makanan");
        //    Console.WriteLine("2. Melihat Nama Makanan");
        //    Console.WriteLine("3. Melihat Harga Makanan");
        //    Console.WriteLine("4. Melihat Diskon");
        //    Console.WriteLine("9. Kembali ke Menu Utama\n");


        //    Console.Write("Input Menu pada List Makanan: ");
        //    var SelectFoodMenu = int.Parse(Console.ReadLine());

        //    switch (SelectFoodMenu)
        //    {
        //        case 1:

        //            DisplayData();
        //            Program.Main();
        //            break;
        //        case 2:

        //            DisplayName();
        //            Program.Main();
        //            break;
        //        case 3:

        //            Console.Write("Masukkan kode untuk mengecek harga : ");
        //            string inputcode = Console.In.ReadLine();
        //            CheckPrice(inputcode);
        //            Program.Main();
        //            break;

        //        case 4:

        //            Foods.DisplayDiscount();
        //            Program.Main();
        //            break;

        //        case 9:
        //            Program.Main();
        //            break;
        //        default:
        //            break;
        //    }
        }

    }

