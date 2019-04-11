using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class DataCardio
    {
        public static double BatMax(int eta, int ris)
        {
            if (eta <= 0 || eta > 120) return -1;
            else return (220 - eta) * 0.9;
        }

        public static double BatMin(int eta, int ris)
        {
            if (eta <= 0 || eta > 120) return -1;
            else return (220 - eta) * 0.7;
        }

        public static string Valori(int freq, string ris)
        {
            if (freq < 60) return "Bradicardia";
            if (freq >= 60 || freq <= 100) return "Normale";
            if (freq > 100) return "Tachicardia";
            if (freq <= 0) return "E";
        }
            

    }
}
