using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class DataCardio
    {
        //punto 1 calcolo i battimi massimi e minimi da mantenere in allenamento
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

        //punto 2 interpreto i valori dei battiti a riposo
        public static string Valori(int freq, string ris)
        {
            if (freq <= 0) return "Errore";
            if (freq < 60) return "Bradicardia";
            else if (freq >= 60 && freq <= 100) return "Normale";
            else if (freq > 100) return "Tachicardia";
            else return "Errore";
        }

        //punto 3 calcolo le calorie bruciatedurante un esercizio
        public static double CalorieBruciate(int a, int p, int f, int t, string ses, int ris)
        {
            if (f <= 0 || p <= 0 || a <= 0 || t <= 0) return -1;
            else if (ses == "M") return Math.Round(((a * 0.2017) + (p * 0.199) + (f * 0.6309) - 55.0969) * t / 4.184);
            else if (ses == "F") return Math.Round(((a * 0.074) + (p * 0.126) + (f * 0.4472) - 20.4022) * t / 4.184);
            else return -1;
        }

        //punto 4 calcolo la spesa energetica di quando si corre o cammina
        public static double SpesaEnergetica(int km, int p, string coc, double ris)
        {
            if (km <= 0 || p <= 0 || coc != "camminata" && coc != "corsa") return -1;
            else if (coc == "corsa") return 0.9 * km * p;
            else return 0.5 * km * p;
        }

        //punto 5A calcolo la media giornaliera dei battiti
        public static double MediaGiornalieraBattiti(List<int> ListaFrequenzaQuotidiano)
        {
            double media = 0;
            bool err = false;

            for (int i = 0; i < ListaFrequenzaQuotidiano.Count; i++)
            {
                media = media + ListaFrequenzaQuotidiano[i];

                if (ListaFrequenzaQuotidiano[i] <= 0) err = true;
            }
            media = media / ListaFrequenzaQuotidiano.Count;

            if (err == true) return -1;
            else return media;
        }

        //punto 5B calcolo il battito cardiaco a riposo
        public static string BattitoCardiacoRiposo(int freq, string ris)
        {
            if (freq <= 0) return "Errore";
            if (freq < 60) return "Bradicardia";
            else if (freq >= 60 && freq <= 100) return "Normale";
            else if (freq > 100) return "Tachicardia";
            else return "Errore";
        }

        //punto 5C calcolo la variabilita dei battiti
        //public static double VariabilitaBattito(List<double> TempoTraDueBattiti)
        //{            
        //}

        //punto 5D ordino i battiti durante la giornata
        public static List<int> OrdineCrescenteBattiti(List<int> ListaFrequenzaGiornata)
        {
            for (int i = 0; i < ListaFrequenzaGiornata.Count; i++)
            {
                if (ListaFrequenzaGiornata[i] <= 0 || ListaFrequenzaGiornata[i] > 220) ListaFrequenzaGiornata[i] = -1;
            }

            ListaFrequenzaGiornata.Sort();
            return ListaFrequenzaGiornata;
        }

    }
}
