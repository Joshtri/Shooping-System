using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooping_System
{
    internal class ShowerTools : IMarket
    {
        protected string name;
        protected string company;
        //protected int ExpiredDate;
        protected string uniqueCode;
        protected string typeProduct;
        protected long price;
        public DateTime dt = new DateTime();
        protected int discount;
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

        private static List<ShowerTools> ListShowerTools = new List<ShowerTools>();

        public ShowerTools(string nme, string cmpny/*, DateTime expdte*/, string code, string typeprdct, long price, int diskon)
        {
            Name = nme;
            Company = cmpny;
            //Dt = expdte;
            UniqueCode = code;
            TypeProduct = typeprdct;
            Price = price;
            Discount = diskon;

            ListShowerTools.Add(this);
            //ListFood.Add(this);
        }


         public static void DisplayData()
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
         public static void DisplayName()
        {
            for (int i = 0; i < ListShowerTools.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var fd = ListShowerTools[i];
                Console.WriteLine($"Shower Tools : {fd.Name}");
                Console.ResetColor();
            }
        }

         public static void DisplayDiscount()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < ListShowerTools.Count; i++)
            {
                var fd = ListShowerTools[i];
                Console.WriteLine($"Shower Tools : {fd.Name}|Unique Code : {fd.UniqueCode}| Price: {fd.Price}| Discount : {fd.Discount}");
                Console.ResetColor();

            }

        }
         public static void CheckPrice(string inputcode)
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
