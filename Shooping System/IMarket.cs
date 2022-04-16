using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooping_System
{
    internal interface IMarket
    {
        //Sifatnya semua harus abstract di Interface
        string Name { 
            get; 
            set;
        }
        string Company 
        { 
            get; 
            set;
        }
        string UniqueCode 
        { 
            get; 
            set; 
        }
        string TypeProduct 
        { 
            get; 
            set; 
        }
        long Price { 
            get; 
            set; 
        }
        int Discount 
        { get; 
            set;
        }

    }
}
