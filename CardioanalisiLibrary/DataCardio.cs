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
            else if (freq >= 60 && freq <= 100) return "Normale";
            else if (freq > 100) return "Tachicardia";
            else if (freq <= 0) return "Errore";
            else return "Errore";
        }

        public static double CalorieBruciate(int a, int p, int f, int t, string ses, int ris)
        {
            if (f <= 0 || p <= 0 || a <= 0 || t <= 0) return -1;
            else if (ses == "M") return Math.Round(((a * 0.2017) + (p * 0.199) + (f * 0.6309) - 55.0969) * t / 4.184);
            else if (ses == "F") return Math.Round(((a * 0.074) + (p * 0.126) + (f * 0.4472) - 20.4022) * t / 4.184);
            else return -1;
        }

        public static double SpesaEnergetica(int km, int p, string coc, double ris)
        {
            if (km <= 0 || p <= 0 || coc != "camminata" || coc != "corsa") return -1;
            else if (coc == "corsa") return 0.9 * km * p;
            else return 0.5 * km * p;
        }
    
    }
}
