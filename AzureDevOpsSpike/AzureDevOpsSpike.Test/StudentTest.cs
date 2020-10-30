using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureDevOpsSpike.Test
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void Constructor_AllValidArguments_CreatesObject()
        {
            string index = "RA101/2017";
            string firstName = "Ilija";
            string lastName = "Brdar";
            double GPA = 9.89;

            new Student(index, firstName, lastName, GPA);
        }

        [TestMethod]
        public void Constructor_FirstNameNull_ThrowsArgumentNullException()
        {
            string index = "RA101/2017";
            string firstName = null;
            string lastName = "Brdar";
            double GPA = 9.89;

            Assert.ThrowsException<ArgumentNullException>(() => new Student(index, firstName, lastName, GPA));
        }

        [TestMethod]
        public void Constructor_FirstNameEmpty_ThrowsArgumentNullException()
        {
            string index = "RA101/2017";
            string firstName = "";
            string lastName = "Brdar";
            double GPA = 9.89;

            Assert.ThrowsException<ArgumentNullException>(() => new Student(index, firstName, lastName, GPA));
        }

        [TestMethod]
        public void Constructor_LastNameNull_ThrowsArgumentNullException()
        {
            string index = "RA101/2017";
            string firstName = "Ilija";
            string lastName = null;
            double GPA = 9.89;

            Assert.ThrowsException<ArgumentNullException>(() => new Student(index, firstName, lastName, GPA));
        }

        [TestMethod]
        public void Constructor_LastNameEmpty_ThrowsArgumentNullException()
        {
            string index = "RA101/2017";
            string firstName = "Ilija";
            string lastName = "";
            double GPA = 9.89;

            Assert.ThrowsException<ArgumentNullException>(() => new Student(index, firstName, lastName, GPA));
        }

        [TestMethod]
        public void Constructor_IndexNull_ThrowsArgumentNullException()
        {
            string index = null;
            string firstName = "Ilija";
            string lastName = "Brdar";
            double GPA = 9.89;

            Assert.ThrowsException<ArgumentNullException>(() => new Student(index, firstName, lastName, GPA));
        }

        [TestMethod]
        public void Constructor_IndexEmpty_ThrowsArgumentNullException()
        {
            string index = "";
            string firstName = "Ilija";
            string lastName = "Brdar";
            double GPA = 9.89;

            Assert.ThrowsException<ArgumentNullException>(() => new Student(index, firstName, lastName, GPA));
        }

        [TestMethod]
        public void Constructor_GPANegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            string index = "RA101/2017";
            string firstName = "Ilija";
            string lastName = "Brdar";
            double GPA = -5;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Student(index, firstName, lastName, GPA));
        }
    }
}
