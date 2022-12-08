using AutoFixture;
using EntityFR.Models;
using EntityFR.Repositories;
using EntityFR.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace EntityFR.Test1.Services
{
    [TestClass]
    public class ContactServiceTests
    {
        /*
         * Le service dépend complètement du Repository. A priori les tests unitaires pour le Service
         * ne sont pas possibles.
         * Pour mettre en place des tests unitaires pour le Service, on doit mocker le Repository
         * en utilisant un Framework de Mocking
         * Framework Moq (.net) - Mockito (java)......
         * Moq: Framework pour mocker des objets
         * Fixture: Framework pour mocker des données
         * 
         * 
         */

        ContactService service;
        Mock<IContactRepository> mockRepo;
        Fixture fixture;

        [TestInitialize]
        public void Setup()
        {
            mockRepo = new Mock<IContactRepository>();
            service = new ContactService(mockRepo.Object);
            fixture = new Fixture();
        }

        [TestMethod]
        [TestCategory("ContactService Unit Test")]
        public void GetAll_Test()
        {
            //List<Contact> contacts = (List<Contact>)fixture.CreateMany<Contact>(5);

            //Arrange
            List<Contact> lst = new List<Contact>();
            lst.Add(new Contact());
            lst.Add(new Contact());

            mockRepo.Setup(r => r.GetAll()).Returns(lst); //Simulation du fonction du repository

            //Act
            List<Contact> result = service.GetAll();

            //Assert
            Assert.AreEqual(2, result.Count);

        }

        [TestMethod]
        [TestCategory("ContactService Unit Test")]
        public void GetById_Test()
        {

            //Arrange
            Contact c = new Contact { Id = 1, Name = "Test" };
            mockRepo.Setup(r => r.GetById(1)).Returns(c); //Simulation du fonction du repository

            //Act
            Contact result = service.GetById(1);

            //Assert
            Assert.AreEqual("Test", result.Name);

        }

        [TestMethod]
        [TestCategory("ContactService Unit Test")]
        public void Insert_Test()
        {

            //Arrange
            Contact c = new Contact { Id = 1, Name = "Test" };
            mockRepo.Setup(r => r.Insert(c)).Callback(() => Console.WriteLine("Contact inséré....")); //Simulation du fonction du repository

            //Act
            service.Insert(c);

            //Il suffit de vérifier si la méthode Insert du Repo est appelée.

        }
    }
}
