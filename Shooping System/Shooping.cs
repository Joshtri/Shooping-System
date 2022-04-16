using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooping_System
{
    internal class Shooping
    {
        public double Money;
        private double Total;
        private double QuantityBuy;

        public Shooping(/*int money,int total, int queantity*/)
        {
            //Money = money;
            //Total = total;
            //QuantityBuy = queantity;
        }

        public static double TotalPay(double mny, /*double ttl,*/ double quantity)
        {
            return mny * quantity;
        }

        public static void Shoppy(double mny, double jmlhpesan)
        {
            var Bayar = TotalPay(mny,jmlhpesan);
            Console.WriteLine($"uang anda {mny}, jumlah pesanan {jmlhpesan} = {Bayar}");
        }
    }
}
