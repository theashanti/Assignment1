using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        public FootballPlayer Correct = new FootballPlayer { Id = 1, Name = "John", Age = 23, ShirtNumber = 25 };
        public FootballPlayer ShortName = new FootballPlayer { Id = 1, Name = "J", Age = 23, ShirtNumber = 2 };
        public FootballPlayer NoName = new FootballPlayer { Id = 1, Name = null, Age = 23, ShirtNumber = 5 };
        public FootballPlayer TooYoung = new FootballPlayer { Id = 1, Name = "John", Age = 0, ShirtNumber = 18 };
        public FootballPlayer BigShirtNumber = new FootballPlayer { Id = 1, Name = "John", Age = 23, ShirtNumber = 103 };

        [TestMethod()]
        public void ValidateToString()
        {
            Assert.AreEqual(Correct.ToString(), "1, John, Age: 23, Number: 25.");

        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            Correct.ValidateName();
            Assert.ThrowsException <ArgumentException> (() => ShortName.ValidateName());
            Assert.ThrowsException<NullReferenceException>(()=> NoName.ValidateName());


        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            Correct.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => TooYoung.ValidateAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            Correct.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> BigShirtNumber.ValidateShirtNumber());
        }
    }
}