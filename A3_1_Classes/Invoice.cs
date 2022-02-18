using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_1_Classes
{
    class Invoice
    {
        public string Item { get; set; }
        public decimal price { get; set; }
        public int Num {get; set;}

        public Invoice(string itemName, decimal itemPrice, int itemNum)
        {
            Item = itemName;
            price = itemPrice;
            Num = itemNum;
        }
       
      //  public int
      
        
        
        
        
        
        /*public int Num
        {
            get
            {
                return num;
            }
            private set
            {
                return Num;
            }
        }

        */
    }
}
// https://www.geeksforgeeks.org/c-sharp-class-and-object/#:~:text=A%20class%20is%20a%20user,derived%20classes%20and%20base%20classes. Extreamly helpful website.
// https://youtu.be/ghCbURMWBD8