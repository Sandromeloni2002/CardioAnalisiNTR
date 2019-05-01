using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        //test punto 1
        [TestMethod]
        [DataTestMethod]
        [DataRow(-1, -1)]
        [DataRow(0, -1)]
        [DataRow(121, -1)]
        [DataRow(20, 180)]
        [DataRow(53, 132.3)]
        [DataRow(62, 142.2)]

        public void TestMethodBatMax(int eta, int ris)
        {
            double att = CardioanalisiLibrary.DataCardio.BatMax(eta, ris);

            Assert.AreEqual(att, ris);
        }

        //test punto 1
        [TestMethod]
        [DataTestMethod]
        [DataRow(-1, -1)]
        [DataRow(0, -1)]
        [DataRow(121, -1)]
        [DataRow(20, 140)]
        [DataRow(53, 116.9)]
        [DataRow(62, 110.6)]

        public void TestMethodBatMin(int eta, int ris)
        {
            double att = CardioanalisiLibrary.DataCardio.BatMax(eta, ris);

            Assert.AreEqual(att, ris);
        }

        //test punto 2
        [TestMethod]
        [DataTestMethod]
        [DataRow(-1, "Errore")]
        [DataRow(0, "Errore")]
        [DataRow(20, "Bradicardia")]
        [DataRow(60, "Normale")]
        [DataRow(100, "Normale")]
        [DataRow(120, "Tachicardia")]

        public void TestMethodValori(int freq, string ris)
        {
            string att = CardioanalisiLibrary.DataCardio.Valori(freq, ris);

            Assert.AreEqual(att, ris);
        }

        //test punto 3
        [TestMethod]
        [DataTestMethod]
        [DataRow(0, 0, 0, 0, "M", -1)]
        [DataRow(20, 70, 80, 60, "M", 191)]
        [DataRow(20, 60, 70, 60, "F", 286)]

        public void TestMethodCalorieBruciate(int a, int p, int f, int t, string ses, int ris)
        {
            double att = CardioanalisiLibrary.DataCardio.CalorieBruciate(a, p, f, t, ses, ris);

            Assert.AreEqual(att, ris);
        }

        //test punto 4
        [TestMethod]
        [DataTestMethod]
        [DataRow(0, 0, "a", -1)]
        [DataRow(1, 60, "corsa", 54)]
        [DataRow(2, 60, "camminata", 60)]

        public void TestMethodSpesaEnergetica(int km, int p, string coc, double ris)
        {
            double att = CardioanalisiLibrary.DataCardio.SpesaEnergetica(km, p, coc, ris);

            Assert.AreEqual(att, ris);
        }

        //test punto 5A
        [TestMethod]

        public void TestMethodMediaGiornalieraBattiti1()
        {
            List<int> ListaFreq = new List<int>() { 0, 800, -20 };
            double risp = CardioanalisiLibrary.DataCardio.MediaGiornalieraBattiti(ListaFreq);

            Assert.AreEqual(-1, risp);
        }

        [TestMethod]

        public void TestMethodMediaGiornalieraBattiti2()
        {
            List<int> ListaFreq = new List<int>() { 100, 200, 150 };
            double risp = CardioanalisiLibrary.DataCardio.MediaGiornalieraBattiti(ListaFreq);

            Assert.AreEqual(150, risp);
        }

        //test punto 5B
        [TestMethod]
        [DataTestMethod]
        [DataRow(-1, "Errore")]
        [DataRow(0, "Errore")]
        [DataRow(20, "Bradicardia")]
        [DataRow(60, "Normale")]
        [DataRow(100, "Normale")]
        [DataRow(120, "Tachicardia")]

        public void TestMethodBattitoCardiacoRiposo(int freq, string ris)
        {
            string att = CardioanalisiLibrary.DataCardio.Valori(freq, ris);

            Assert.AreEqual(att, ris);
        }

        //test punto 5C

        //test punto 5D
        [TestMethod]

        public void TestMethodOrdineCrescenteBattiti()
        {
            List<int> ListaFreq = new List<int>() { 60, 100, 98, 73, 86, 50 };
            List<int> risp = CardioanalisiLibrary.DataCardio.OrdineCrescenteBattiti(ListaFreq);
            List<int> att = new List<int>() { 50, 60, 73, 86, 98, 100 };

            Assert.AreEqual(att, risp);
        }
    }
}
