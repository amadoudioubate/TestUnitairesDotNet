using Calculateur.DLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculateurs.Tests
{
    [TestClass] // Annotation qui précise qu'il s'agit d'une classe objet
    public class CalculatorTests
    {
        /* Conventions de nommage :
         * Le projet de test comprend le nom du projet à tester : nomProjet.Tests
         * Les classes de test porte le nom de la classe à tester : nomClasseTests
         * Le nom des méthodes de test : nomMéthodeAtester_etatdeparams_resultatAttendu
         * 
         * */


        [TestMethod] // annotation qui préciss qu'il s'agit d'une méthode de test
        [TestCategory("Calculator")]
        [TestProperty("Test groupe", "Performance")]
        [Priority(1)]
        [Owner("Dev1")]
        public void Division_NumerateurPositif_DenominateurPositif_ReturnResultatPositif()
        {
            // Pattern AAA : Arrange - Act - Assert
            // Arrange : initialisation des paramètres de la méthode
            int numerateur = 10;
            int denominateur = 5;
            int resultatAttendu = 2;

            // Act : appeler la méthode à tester
            int resultatObtenu = Calculator.Division(numerateur, denominateur);

            // Assert : vérification des resultats
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test groupe", "Performance")]
        [Priority(1)]
        [Owner("Dev1")]
        public void Division_NumerateurPositif_DenominateurNegatif_ReturnResultatNegatif()
        {
            // Arrange
            int numerateur = 10;
            int denominateur = -2;
            int resultatAttendu = -5;

            // Act : appeler la méthode à tester
            int resultatObtenu = Calculator.Division(numerateur, denominateur);

            // Assert : vérification des resultats
            Assert.AreEqual(resultatAttendu, resultatObtenu);

        }


        // Scénario de test Division_NumerateurNegatif_DenominateurNegatif_ReturnResultatPositif => il faut voir toutes les scénarios possibles
        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test groupe", "Performance")]
        [Priority(1)]
        [Owner("Dev1")]

        public void Division_NumerateurNegatif_DenominateurNegatif_ReturnResultatPositif()
        {
            // Arrange
            int numerateur = -10;
            int denominateur = -2;
            int resultatAttendu = 5;

            // Act : appeler la méthode à tester
            int resultatObtenu = Calculator.Division(numerateur, denominateur);

            // Assert : vérification des resultats
            Assert.AreEqual(resultatAttendu, resultatObtenu);

        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test groupe", "Performance")]
        [Priority(1)]
        [Owner("Dev1")]
        public void Division_NumerateurNegatif_DenominateurPositif_ReturnResultatNegatif()
        {
            // Arrange
            int numerateur = -10;
            int denominateur = 2;
            int resultatAttendu = -5;

            // Act : appeler la méthode à tester
            int resultatObtenu = Calculator.Division(numerateur, denominateur);

            // Assert : vérification des resultats
            Assert.AreEqual(resultatAttendu, resultatObtenu);

        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test groupe", "Performance")]
        [Priority(1)]
        [Owner("Dev1")]
        [ExpectedException(typeof(ArgumentException))]
        public void Division_NumerateurEgalZero_ReturnException()
        {
            // Arrange
            int numerateur = 10;
            int denominateur = 0;
            

            // Act : appeler la méthode à tester
            Calculator.Division(numerateur, denominateur);


        }





        [TestMethod]
        [TestCategory("Test méthode privée en utilisant une méthode publique")]
        public void Add_Param1Positif_Parm2Positif_ReturnSomme()
        {
            //Arrange
            int nb1 = 10;
            int nb2 = 10;
            int attendu = 20;

            //Act
            int obtenu = Calculator.Add(nb1, nb2);

            //Assert
            Assert.AreEqual(attendu, obtenu);

        }

        [TestMethod]
        [TestCategory("Test méthode privée en utilisant une méthode publique")]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_Param1Positif_Parm2Negatif_ReturnException()
        {
            //Arrange
            int nb1 = 10;
            int nb2 = -10;

            //Act
            int obtenu = Calculator.Add(nb1, nb2);
        }

        [TestMethod]
        [TestCategory("Test méthode privée en utilisant une méthode publique")]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_Param1NegatifPositif_Parm2Positif_ReturnException()
        {
            //Arrange
            int nb1 = -10;
            int nb2 = 10;

            //Act
            Calculator.Add(nb1, nb2);
        }

        [TestMethod]
        [TestCategory("Test d'une méthode privée static")]
        public void IsPositif_ParamPositif_ReturnTrue()
        {
            //Arrange
            PrivateType p = new PrivateType(typeof(Calculator));
            int nb = 10;

            //Act
            bool obtenu = (bool)p.InvokeStatic("IsPositif", nb);

            //Assert
            Assert.IsTrue(obtenu);
        }

        [TestMethod]
        [TestCategory("Test d'une méthode privée static")]
        public void IsPositif_ParamNegatif_ReturnFalse()
        {
            //Arrange
            PrivateType p = new PrivateType(typeof(Calculator));
            int nb = -10;

            //Act
            bool obtenu = (bool)p.InvokeStatic("IsPositif", nb);

            //Assert
            Assert.IsFalse(obtenu);
        }
        [TestMethod]
        [TestCategory("Test d'une méthode privée d'instance (non static)")]
        public void IsNegatif_ParamNegatif_ReturnTrue()
        {
            //Arrange
            int number = -10;
            PrivateObject p = new PrivateObject(typeof(Calculator));

            //Act
            bool obtenu = (bool)p.Invoke("IsNegatif", number);

            //Assert
            Assert.IsTrue(obtenu);
        }

        [TestMethod]
        [TestCategory("Test d'une méthode privée d'instance (non static)")]
        public void IsNegatif_ParamPositif_ReturnFalse()
        {
            //Arrange
            int number = 10;
            PrivateObject p = new PrivateObject(typeof(Calculator));

            //Act
            bool obtenu = (bool)p.Invoke("IsNegatif", number);

            //Assert
            Assert.IsFalse(obtenu);
        }


        [TestMethod]
        [TestCategory("Exo")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddElemTab_TableauNull_ReturnException()
        {
            // Arrange
            int[] t = null;

            // Act
            Calculator.AddElemTab(t);

        }


        [TestMethod]
        [TestCategory("Exo")]
        public void AddElemTab_TableauNonNull_ReturnSomme()
        {
            // Arrange
            int[] t = { 1, 2, 3, 4, 5, 6 };
            int attendu = 21;

            // Act
            int obtenu = Calculator.AddElemTab(t);

            //Assert
            Assert.AreEqual(attendu, obtenu);
        }


        [TestMethod]
        [TestCategory("Exo")]
        [ExpectedException(typeof(ArgumentException))]
        public void NombreMots_ChaineNull_ReturnException()
        {
            //Arrange
            string chaine = null;

            //Act
            Calculator.NombreMots(chaine);
        }

        [TestMethod]
        [TestCategory("Exo")]
        public void NombreMots_ChaineNonNull_ReturnException()
        {
            
            // Arrange 
            string chaine = "  ceci est   une chaine";
            int attendu = 4;

            // Act
            int obtenu = Calculator.NombreMots(chaine);

            // Assert
            Assert.AreEqual(attendu, obtenu);

            
            /*Assert.AreEqual(Calculator.NombreMots("ceci est  une chaine"), 4);
            Assert.AreEqual(Calculator.NombreMots("ceci est   une chaine"), 4);
            Assert.AreEqual(Calculator.NombreMots(" a b c "), 3);
            Assert.AreEqual(Calculator.NombreMots(" a b c 4"), 4);
            Assert.AreEqual(Calculator.NombreMots(" a b c 5 6"), 5);*/
        }



        [TestMethod]
        [TestCategory("Exo")]
        public void NombreChar_ChaineNull_ReturnZero()
        {
            //Arrange
            string chaine = null;
            int attendu = 0;

            //Act
            int obtenu = Calculator.NombreChar(chaine);

            //Assert
            Assert.AreEqual(attendu, obtenu);
        }

        [TestMethod]
        [TestCategory("Exo")]
        public void NombreChar_ChaineNotNull_ReturnNombreChar()
        {
            //Arrange
            string chaine = " cccc j uu ";
            int attendu = 11;

            //Act
            int obtenu = Calculator.NombreChar(chaine);

            //Assert
            Assert.AreEqual(attendu, obtenu);
        }


    }
}
