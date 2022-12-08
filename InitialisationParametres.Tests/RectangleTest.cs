using InitialisationOarametres;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InitialisationParametres.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        [TestCategory("Initialisation Paramètres")]
        public void Surface_Test()
        {
            // Arrange 
            Rectangle rec = new Rectangle();

            rec.Hauteur = 20;
            rec.Largeur = 30;
            double attendu = 600;

            // Act
            double obtenu = rec.Surface();

            Assert.AreEqual(attendu, obtenu);
        }
    }
}
