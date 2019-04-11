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
        [DataRow(20, 180)]
        [DataRow(53, 132.3)]
        [DataRow(62, 142.2)]

        public void TestMethodBatMax(int eta, int ris)
        {
            double att = CardioanalisiLibrary.DataCardio.BatMax(eta, ris);

            Assert.AreEqual(att, ris);
        }

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


    }
}
