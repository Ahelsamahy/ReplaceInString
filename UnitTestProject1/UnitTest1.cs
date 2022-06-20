using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ReplaceString;
using static ReplaceString.Program;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstOccurrence()
        {
            Replacable target = new Replacable("word");
            //String target = null;
            string _base = "apple";
            string expected = "abble";
            string actual = target.Replace(_base, 'p', 'b', 1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SecondOccurrence()
        {
            Replacable target = new Replacable("word");
            //String target = null;
            string _base = "apppppple";
            string expected = "apbpbpble";
            string actual = target.Replace(_base, 'p', 'b', 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(myNegativeParamException))]
        public void NegativeOccurrence()
        {
            Replacable target = new Replacable("word");
            //String target = null;
            string _base = "apple";
            string actual = target.Replace(_base, 'p', 'b', -1);
        }

        [TestMethod]
        [ExpectedException(typeof(myIllegalParamException))]
        public void NullString()
        {
            Replacable target = new Replacable("word");
            //String target = null;
            string _base = "apple";
            string actual = target.Replace(null, 'p', 'b', 1);
        }
    }
}
