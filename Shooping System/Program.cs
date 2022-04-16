using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Shooping_System
{
    internal class Program 
    {

        public static void Main()
        {
           

            // Data Khusus untuk tiap kelas.
            Foods fds1 = new Foods("Mie Sedap", "PT. Sarimas", "1222", "Foods", 3000, 5);
            Foods fds2 = new Foods("Biskuit Kelapa", "PT. Roma Kelapa", "1223", "Cemilan", 10000, 0);
            Foods fds3 = new Foods("Biskuit Cokelat", "PT. Roma Kelapa", "1224", "Cemilan", 10000, 0);
            Foods fds4 = new Foods("Kusuka", "PT. Suit", "1225", "Cemilan", 17000, 0);
            Foods fds5 = new Foods("Kacang Pilus", "PT. Garuda", "1226", "Cemilan", 13000, 0);
            Foods fds6 = new Foods("Roti Tawar", "Pabrik Suka Roti", "1227", "Cemilan", 20000, 0);



            Drinks dk1 = new Drinks("Teh Kotak", "PT. Kotak Indo","1333", "Drinks", 5000, 0);
            Drinks dk2 = new Drinks("Teh Pucuk", "PT. Teh Indo", "1334", "Drinks", 6000, 0);
            Drinks dk3 = new Drinks("Pocari Sweat", "Japan Company", "1335", "Drinks", 7000, 0);
            Drinks dk4 = new Drinks("Aqua 500ml", "PT. Aqua Golden Missipi", "1336", "Drinks", 5000, 0);
            Drinks dk5 = new Drinks("Aqua 1000ml", "PT. Aqua Golden Missipi", "1337", "Drinks", 8000, 0);
            Drinks dk6 = new Drinks("Aqua 1500ml", "PT. Aqua Golden Missipi", "1338", "Drinks", 10000, 0);
            Drinks dk7 = new Drinks("Aqua Galon", "PT. Aqua Golden Missipi", "1333", "Drinks", 40000, 0);


            ShowerTools shwr1 = new ShowerTools("Sikat Gigi", "PT. Gigi Sehat","9000", "Kebutuhan Diri",6500,10);
            ShowerTools shwr2 = new ShowerTools("Sabun", "PT. Lifeboy", "3000", "Kebutuhan Diri", 3500, 5);






        MainMenuSystem:
            Console.WriteLine("\t\tSelamat Datang di Tempat Belanja Dodit dengan Sistem Berbasis Console\n");
            Console.WriteLine("Jenis Menu :");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1. Makanan");
            Console.WriteLine("2. Minuman");
            Console.WriteLine("3. Alat Kebersihan");
            Console.WriteLine("4. Kebutuhan Dapur");
            Console.WriteLine("5. Ayo Berbelanja ( jangan \"liat barang doang\")\n");
            Console.ResetColor();

            Console.Write("\tMasukkan menu yang diinginkan : ");
            int Select = int.Parse(Console.ReadLine());

            if (Select == 1 || Select == 2 || Select == 3 || Select == 4)
            {
                switch (Select)
                {
                    case 1:
                        
                        Foods.FoodMenu();
                        break;
                    case 2:
                        Drinks.MenuDrinks();
                        break;
                    case 3:
                        ShowerTools.MenuShowerTools();
                        break;
                    //case 4:
                    //    KitchenTools.MenuKitchenTools();
                    //    break;
                    //case 5:
                    //    goto 

                    default:
                        break;
                }

            }

            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Input nomor yang benar");
                goto MainMenuSystem;
            }


        
        }
    }
   }


