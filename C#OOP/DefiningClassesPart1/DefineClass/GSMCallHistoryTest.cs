using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
   public class GSMCallHistoryTest
    {
        public void CallHistoryTest()
        {
            GSM peshoGSM = new GSM("Nokia", "Nokia");
            Call firstCall = new Call(DateTime.Now, "0888080808", 3000);
            Call secondCall = new Call(DateTime.Now,"0888080808", 3500);
            Call thirdCall = new Call(DateTime.Now, "0888080808", 2000);
            peshoGSM.AddCall(firstCall);
            peshoGSM.AddCall(secondCall);
            peshoGSM.AddCall(thirdCall);

            Console.WriteLine(peshoGSM.CallHistoryInfo());
            
            decimal price = 0.37M;

            Console.WriteLine("Total price: {0:F2}",peshoGSM.CalculateTotalPriceOfCalls(price));

            int longest=0;
            Call longestCall = new Call(DateTime.Now,"0888888888",0);

            for (int i = 0; i < peshoGSM.CallHistory.Count; i++)
            {
                if (peshoGSM.CallHistory[i].Duration > longest)
                {
                    longest = peshoGSM.CallHistory[i].Duration;
                    longestCall = peshoGSM.CallHistory[i];
                }
            }

            peshoGSM.DeleteCall(longestCall);

            Console.WriteLine("Total price after longest call has been removed: {0:F2}", peshoGSM.CalculateTotalPriceOfCalls(price));

            peshoGSM.ClearCalls();

            peshoGSM.CallHistoryInfo();
            
        }

    }
}
