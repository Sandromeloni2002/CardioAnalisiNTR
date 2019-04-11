using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class DataCardio
    {
        public static double BatMax(int eta)
        {
            return (220 - eta) * 0.9;
        }

        public static double BatMin(int eta)
        {
            return (220 - eta) * 0.7;
        }
    }
}
