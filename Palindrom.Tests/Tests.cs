using NUnit.Framework;
using Palindrom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsSingleLetterAPalindrom()
        {
            //Arrange
            string word = "a";
            
            //Act
            bool result = PalindromChecker.IsPalindrom(word);

            //Assert
            Assert.AreEqual(result,true);
        }

        [Test]
        public void IsWordAPalindrom()
        {
            //Arrange
            string word = "kajak";

            //Act
            bool result = PalindromChecker.IsPalindrom(word);

            //Assert
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsSentenceAPalindrom()
        {
            //Arrange
            string word = "I mała dama sama dała mi";

            //Act
            bool result = PalindromChecker.IsPalindrom(word);

            //Assert
            Assert.AreEqual(result, true);
        }
    }
}
