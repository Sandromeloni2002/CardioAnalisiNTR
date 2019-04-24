using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(-1,-1)]
        [DataRow(0,-1)]
        [DataRow(121,-1)]
        [DataRow(20, 180.0)]
        [DataRow(53, 132.3)]
        [DataRow(62, 142.2)]

        public void TestMethodBatMax(int eta, double ris)
        {
            double att = CardioanalisiLibrary.DataCardio.BatMax(eta, ris);

            Assert.AreEqual(att, ris);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-1, -1)]
        [DataRow(0, -1)]
        [DataRow(121, -1)]
        [DataRow(20, 140.0)]
        [DataRow(53, 116.9)]
        [DataRow(62, 110.6)]

        public void TestMethodBatMin(int eta, double ris)
        {
            double att = CardioanalisiLibrary.DataCardio.BatMax(eta, ris);

            Assert.AreEqual(att, ris);
        }

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

        [TestMethod]
        [DataTestMethod]
        [DataRow(1, 60, "corsa", 54)]
        [DataRow(2, 50, "camminata", 50)]
        [DataRow(0, 0, "corsa", -1)]

        public void TestMethodSpesaEnergetica(int km, int p, string coc, int ris)
        {
            double att = CardioanalisiLibrary.DataCardio.SpesaEnergetica(km, p, coc, ris);

            Assert.AreEqual(att, ris);
        }
    }
}
