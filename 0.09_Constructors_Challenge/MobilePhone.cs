using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class MobilePhone
    {



        public MobilePhone(string make, string model, string owner)
        {

            this.Make = make;
            this.Model = model;
            this.Owner = Owner;
        }
        public int MobilePhoneID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public void PrintToScreen()
        {
            Console.WriteLine("I own an " + Make + " " + Model);
        }
        
    }
}
