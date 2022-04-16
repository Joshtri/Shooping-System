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
            Shooping kasir1 = new Shooping();
        Belanjaa:
            Console.WriteLine("\tMau beli apa ? Silahkan pilih menu\n");
            Console.WriteLine("1. Makanan\n");
            Console.WriteLine("2. Langsung pesan");

            nextopsi:
            Console.WriteLine("Input : ");
            var inputing = int.Parse(Console.ReadLine());
            if (inputing == 1)
            {
                Console.WriteLine("1. Cek Harga");
                var inputes = int.Parse(Console.ReadLine());
                if (inputes == 1)
                {
                    Foods.JustCheckInShop();
                    goto nextopsi;
                }
            }
            else if (inputing == 2)
            {
                Console.Write("Jumlah uang anda : ");
                double Money = double.Parse(Console.ReadLine());

                Console.Write("Berapa jumlah pesanan anda :");
                double JumlhPesanan = double.Parse(Console.ReadLine());

                Shooping.Shoppy(Money, JumlhPesanan);
            }
           

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


            ShowerTools shwr1 = new ShowerTools("Sikat Gigi", "PT. Gigi Sehat", "9000", "Kebutuhan Diri", 6500, 10);
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

          
            
                switch (Select)
                {
                    case 1:
                        goto MenuFoods;
                        
                    case 2:
                         goto MenuDrink;
                       
                    case 3:
                        goto MenuShowerTools;
                        
                    //case 4:
                    //    KitchenTools.MenuKitchenTools();
                    //    break;
                    case 5:
                    goto Belanjaa;

                    default:
                        break;
                }
        MenuFoods:
            Console.WriteLine("Daftar Perintah :\n");
            Console.WriteLine("1. Melihat Rincian Makanan");
            Console.WriteLine("2. Melihat Nama Makanan");
            Console.WriteLine("3. Melihat Harga Makanan");
            Console.WriteLine("4. Melihat Diskon");
            Console.WriteLine("9. Kembali ke Menu Utama\n");


            Console.Write("Input Menu pada List Makanan: ");
            var SelectFoodMenu = int.Parse(Console.ReadLine());
            if (SelectFoodMenu == 1 || SelectFoodMenu == 2 || SelectFoodMenu == 3 || SelectFoodMenu == 4) 
            { 
            switch (SelectFoodMenu)
            {
                case 1:
                    Foods.DisplayData();
                    goto MainMenuSystem;
                case 2:

                    Foods.DisplayName();
                    goto MainMenuSystem;
                case 3:
               
                    Console.Write("Masukkan kode untuk mengecek harga : ");
                    string inputcode = Console.In.ReadLine();
                    Foods.CheckPrice(inputcode);
                    goto MainMenuSystem;

                case 4:

                    Foods.DisplayDiscount();
                    goto MainMenuSystem;

                case 9:
                    Main();
                    break;
                default:
                    break;
            }
            }
            else
            {
                Console.WriteLine("Masukkan Inputan yang benar ");
                goto MainMenuSystem;
            }

        MenuDrink:
            Console.WriteLine("Daftar Perintah :\n");
            Console.WriteLine("1. Melihat Rincian Minuman");
            Console.WriteLine("2. Melihat Nama Minuman");
            Console.WriteLine("3. Melihat Harga Minuman");
            Console.WriteLine("4. Melihat Diskon");
            Console.WriteLine("9. Kembali ke Menu Utama\n");


            Console.Write("Input Menu pada List Minuman: ");
            var SelectDrinkMenu = int.Parse(Console.ReadLine());


            switch (SelectDrinkMenu)
            {

                case 1:
                    Drinks.DisplayData();
                    goto MainMenuSystem;
                case 2:
                    Drinks.DisplayName();
                    goto MainMenuSystem;
                case 3:
                    Console.Write("Masukkan kode untuk mengecek harga : ");
                    string inputcode = Console.In.ReadLine();

                    Drinks.CheckPrice(inputcode);
                    goto MainMenuSystem;
                case 4:
                    //var drunkies = new Drinks();
                    Drinks.DisplayDiscount();
                    goto MainMenuSystem;

                case 9:
                    Main();
                    break;
                default:
                    break;

            }

        MenuShowerTools:
            Console.WriteLine("Daftar Perintah :\n");
            Console.WriteLine("1. Melihat Rincian Alat kebersihan");
            Console.WriteLine("2. Melihat Nama Alat kebersihan");
            Console.WriteLine("3. Melihat Harga Alat kebersihan");
            Console.WriteLine("4. Melihat Diskon");
            Console.WriteLine("9. Kembali ke Menu Utama\n");


            Console.Write("Input Menu pada List Alat Kebersihan: ");
            var SelectShowerToolsMenu = int.Parse(Console.ReadLine());
            if (SelectShowerToolsMenu == 1 || SelectShowerToolsMenu == 2 || SelectShowerToolsMenu == 3 || SelectShowerToolsMenu == 4 || SelectShowerToolsMenu == 9)
            {
                switch (SelectShowerToolsMenu)
                {
                    case 1:
                        ShowerTools.DisplayData();
                        goto MainMenuSystem;
                    case 2:

                        ShowerTools.DisplayName();
                        goto MainMenuSystem;
                    case 3:
                   
                        Console.Write("Masukkan kode untuk mengecek harga : ");
                        string inputcode = Console.In.ReadLine();
                        ShowerTools.CheckPrice(inputcode);

                        goto MainMenuSystem;

                    case 4:

                        ShowerTools.DisplayDiscount();
                        goto MainMenuSystem;

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


