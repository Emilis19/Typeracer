using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestTyperacer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckTextsCount()
        {
            int expected = 3;
            
            typeracer.Texts texts = new typeracer.Texts();
            texts.GenerateStartingTexts();
           int actual = texts.text.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextsNotNull()
        {
            typeracer.Texts texts = new typeracer.Texts();
            texts.GenerateStartingTexts();
            Assert.IsNotNull(texts.text);
        }
    }
}
