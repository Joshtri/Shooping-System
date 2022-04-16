using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooping_System
{
    internal class Drinks 
    {
        protected string Name { get; set; }
        protected string Company { get; set; }
        //protected int ExpiredDate;
        protected string UniqueCode { get; set; }
        protected string TypeProduct { get; set; }
        protected long Price { get; set; }
        public DateTime Dt = new DateTime();
        protected int Discount { get; set; }

        private static List<Drinks> ListDrinks = new List<Drinks>();
        
        public Drinks(string nme, string cmpny/*, DateTime expdte*/, string code, string typeprdct, long price, int diskon)
        {
            Name = nme;
            Company = cmpny;
            //Dt = expdte;
            UniqueCode = code;
            TypeProduct = typeprdct;
            Price = price;
            Discount = diskon;

            ListDrinks.Add(this);
        }
      


        public static void DisplayData()
        {
            for (int i = 0; i < ListDrinks.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var fd1 = ListDrinks[i];
                Console.WriteLine($"Drink : {fd1.Name}|Unique Code : {fd1.UniqueCode}| Price: {fd1.Price}| Type : {fd1.TypeProduct}| Company: {fd1.Company}| Expired Date: {fd1.Dt}");
                Console.ResetColor();
            }
        }
        public static void DisplayName()
        {
            for (int i = 0; i < ListDrinks.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var fd = ListDrinks[i];
                Console.WriteLine($"Drink : {fd.Name}");
                Console.ResetColor();
            }
        }

        public static void DisplayDiscount()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < ListDrinks.Count; i++)
            {
                var fd = ListDrinks[i];
                Console.WriteLine($"Drink : {fd.Name}|Unique Code : {fd.UniqueCode}| Price: {fd.Price}| Discount : {fd.Discount}");
                Console.ResetColor();
            }

        }
        public static void CheckPrice(string inputcode)
        {
           
            int i = 0;
            List<Drinks> ListDrinks = new List<Drinks>();
            while (i < ListDrinks.Count)
            {
                do
                {
                    Console.WriteLine($"Food : {ListDrinks[i].Name} price : {ListDrinks[i].Price}");
                    i++;
                } while (inputcode == ListDrinks[i].UniqueCode);

                i++;
                if (inputcode.Length != 4)
                {
                repeating:
                    Console.Write("Inputan kode anda kurang 4 digit, masukkan ulang.(Y/N) : ");
                    string answer = Console.In.ReadLine();
                    char chrcter = char.Parse(answer);
                    if (chrcter == 'Y')
                    {
                        //goto tryagain;
                    }
                    else if (chrcter == 'N')
                    {
                        //goto MenuDrink;
                    }
                    else
                    {
                        Console.WriteLine("Hanya menerima tipe data karakter \"Y\" dan \"N\" ");
                        goto repeating;
                    }
                }

            }
        }
        
        //public static void MenuDrinks()
        //{
        //MenuDrink:
        //    Console.WriteLine("Daftar Perintah :\n");
        //    Console.WriteLine("1. Melihat Rincian Minuman");
        //    Console.WriteLine("2. Melihat Nama Minuman");
        //    Console.WriteLine("3. Melihat Harga Minuman");
        //    Console.WriteLine("4. Melihat Diskon");
        //    Console.WriteLine("9. Kembali ke Menu Utama\n");


        //    Console.Write("Input Menu pada List Minuman: ");
        //    var SelectDrinkMenu = int.Parse(Console.ReadLine());


        //    switch (SelectDrinkMenu)
        //    {

        //        case 1:
        //            Drinks.DisplayData();
        //            goto MenuDrink;
        //        case 2:
        //            Drinks.DisplayName();
        //            goto MenuDrink;
        //        case 3:
        //            Console.Write("Masukkan kode untuk mengecek harga : ");
        //            string inputcode = Console.In.ReadLine();

        //            Drinks.CheckPrice(inputcode);
        //            goto MenuDrink;


        //        case 4:
        //            //var drunkies = new Drinks();
        //            Drinks.DisplayDiscount();

        //            goto MenuDrink;

        //        case 9:
        //            Program.Main();
        //            break;
        //        default:
        //            break;

        //    }



        }


    }


        //    public int Discountt { get; set; }

        //    private static List<Drinks> DrinksList = new List<Drinks>();
        //    public Drinks(string nme, string cmpny, 
        //        long cdes, string typeprdctt,long prc, int dscnt) : base(nme,cmpny,cdes,typeprdctt,prc, dscnt)
        //    {

        //        DrinksList.Add(this);
        //    }
        //    //default ctor.
        //    public Drinks()
        //    {

        //        DrinksList.Add(this);
        //    }

        //    public static new void DisplayData()
        //    {
        //        for (int i = 0; i < DrinksList.Count; i++)
        //        {
        //            Console.ForegroundColor = ConsoleColor.DarkCyan;
        //            var drk = DrinksList[i];
        //            Console.WriteLine($"Drink : {drk.Name}|Unique Code : {drk.UniqueCode}| Price: {drk.Price}| Type : {drk.TypeProduct}| Company: {drk.Company}| Expired Date: {drk.Dt}");
        //            Console.ResetColor();
        //        }
        //    }
        //    public static new void DisplayName()
        //    {
        //        for (int i = 0; i < DrinksList.Count; i++)
        //        {
        //            Console.ForegroundColor = ConsoleColor.DarkCyan;
        //            var drk = DrinksList[i];
        //            Console.WriteLine($"Drink : {drk.Name}");
        //            Console.ResetColor();
        //        }
        //    } 
        //    new public void DisplayDiscount()
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkCyan;
        //        for (int i = 0; i < DrinksList.Count; i++)
        //        {
        //            var fd = DrinksList[i];
        //            Console.WriteLine($"Drink : {fd.Name}|Unique Code : {fd.UniqueCode}| Price: {fd.Price}| Discount : {fd.Discount}");
        //            Console.ResetColor();
        //        }
        //    }

        //    public new void CheckPrice(long D)
        //    {
        //        var drinks = DrinksList.Find(x => x.UniqueCode == s);

        //        if (drinks != null)
        //        {
        //            Console.WriteLine("List Harga : ");
        //            foreach (var item in DrinksList)
        //            {
        //                Console.WriteLine($"{item.Name} : Rp.{item.Price}");
        //            }
        //        }

        //    }


 
