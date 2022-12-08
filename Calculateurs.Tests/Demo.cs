using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;

namespace Calculateurs.Tests
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class Demo
    {
        //TextContent: classe abstraite fournie par MsTest qui propose des méthodes intéressantes
        //Pour l'instancier il suffit de déclarer une propriété qui porte le nom de la classe
        public Demo()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext { get; set; }
        

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test groupe", "Sécurité")]
        [Owner("Dev2")]
        public void TestMethod1()
        {
            //
            // TODO: ajoutez ici la logique du test
            //

            TestContext.WriteLine(TestContext.TestName);
            TestContext.WriteLine(TestContext.FullyQualifiedTestClassName);
        }

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test groupe", "Sécurité")]
        [Owner("Dev2")]
        public void TestMethod2()
        {
            //
            // TODO: ajoutez ici la logique du test
            //
            // Pour utiliser la console d'affichage
            Console.WriteLine("Message de console.writeline");
            Debug.WriteLine("Message de debug.writeline");
            MessageBox.Show("Message");
        }
    }
}
