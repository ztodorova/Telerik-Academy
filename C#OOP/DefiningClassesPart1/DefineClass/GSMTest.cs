using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class GSMTest
    {
        public void Create4GSMs()
        {
            GSM samsungMini = new GSM("Samsung S3 Mini", "Samsung");
            GSM samsung = new GSM("Samsung S3", "Samsung");
            GSM iPhone6 = new GSM("IPhone 6", "Apple");
            GSM[] arrayGSM = { samsungMini, samsung, iPhone6 };
       
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayGSM[i].ToString());
            }

            Console.WriteLine(GSM.IPhone4S);


        }
    }
}
