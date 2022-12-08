using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Runtime.Remoting.Contexts;
using EntityFR.Repositories;
using EntityFR.Models;

namespace EntityFR.Test1.Repositories
{
    [TestClass]
    public class ContactRepositoryTests
    {
        /*
         * ****** Ne pas utiliser la base de données de la prod - prévoir une BD de test
         * - Installer Entity Framework 6
         * - Dans App.config, via ConnectionString, fournir la BD de test.
         * Le context du Repository, va utiliser 
         * 
         * 
         */

        ContactRepository repo;

        [TestInitialize]
        public void Setup()
        {
            repo = new ContactRepository();
        }

        [TestMethod]
        [TestCategory("ContactRepository Unit Test")]
        public void a_GetAll_Test()
        {
            Assert.AreEqual(0, repo.GetAll().Count);
        }

        [TestMethod]
        [TestCategory("ContactRepository Unit Test")]
        public void b_Insert_Test()
        {
            //Arrange
            Contact c = new Contact { Id = 1, Name = "Dawan" };
            int tailleAvantInsertion = repo.GetAll().Count;

            //Act
            repo.Insert(c);
            int tailleApresInsertion = repo.GetAll().Count;

            //Assert
            Assert.AreEqual(tailleApresInsertion, tailleAvantInsertion + 1);
        }

        [TestMethod]
        [TestCategory("ContactRepository Unit Test")]
        public void c_GetById_Test()
        {
            //Arrange
            int id = 1;

            //Act
            Contact c = repo.GetById(id);

            //Assert
            Assert.AreEqual("Dawan", c.Name);
        }

        [TestMethod]
        [TestCategory("ContactRepository Unit Test")]
        [ExpectedException(typeof(Exception))]
        public void d_GetById_IdNotExist_ReturnException()
        {
            //Arrange
            int id = 1500;

            //Act
            repo.GetById(id);

        }

        [TestMethod]
        [TestCategory("ContactRepository Unit Test")]
        public void e_Update_Test()
        {
            //Arrange
            int id = 1;
            Contact c = repo.GetById(1);
            c.Name = "new name";

            //Act
            repo.Update(c);
            Contact contactUpdated = repo.GetById(id);

            //Assert
            Assert.AreEqual("new name", contactUpdated.Name);

        }

        [TestMethod]
        [TestCategory("ContactRepository Unit Test")]
        public void f_Delete_Test()
        {
            //Arrange
            int id = 1;
            int tailleAvantSuppression = repo.GetAll().Count;
            //Act
            repo.Delete(id);
            int tailleApresSuppression = repo.GetAll().Count;

            //Assert
            Assert.AreEqual(tailleApresSuppression, tailleAvantSuppression - 1);

        }

        [TestMethod]
        [TestCategory("ContactRepository Unit Test")]
        [ExpectedException(typeof(Exception))]
        public void e_Delete_IdNotExist_ReturnException()
        {
            //Arrange
            int id = 1000;

            //Act
            repo.Delete(id);

        }
    }
}
