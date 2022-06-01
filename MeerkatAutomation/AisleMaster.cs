using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeerkatAutomation
{
    public class AisleMaster
    {
        public static string[] AisleNames(string[] names)
        {
            int aisles = names.Length;
            string[] rackNames = new string[aisles * 2];
            int rackindex = 0;
            for (int i = 0; i < aisles; i++)
            {
                rackNames[rackindex] = names[i] + "_ODD";
                rackNames[rackindex + 1] = names[i] + "_EVEN";
                rackindex = rackindex + 2;
            }

            return rackNames;
        } 

     
    }
}
