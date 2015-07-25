using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace DefineClass
{
    public class DefineClassMain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Battery myBattery = new Battery("Bateria");
            Display myDisplay = new Display();
            GSM myGSM = new GSM("Nokia","Nokia", 100.23M, "Pesho",myBattery,myDisplay);
            string myGSMinfo = myGSM.ToString();
            Console.WriteLine(myGSMinfo);

            GSM mySecondGSM = GSM.IPhone4S;
            
            Console.WriteLine(mySecondGSM);

            GSMTest test = new GSMTest();
            test.Create4GSMs();

            
            GSMCallHistoryTest secondTest = new GSMCallHistoryTest();
            secondTest.CallHistoryTest();

        }
    }
}
