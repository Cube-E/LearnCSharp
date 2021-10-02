using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalDataLibrary.Utility;

namespace PharmaTests
{
    [TestClass]
    public class StringUtilityUnitTest
    {
        [TestMethod]
        public void test_nullString() {
            string str = null;
            Assert.IsTrue(StringUtility.isNullOrEmpty(str));
        }

        [TestMethod]
        public void test_emptyString() {
            string str = "";
            Assert.IsTrue(StringUtility.isNullOrEmpty(str));
        }

        [TestMethod]
        public void test_nonEmptyString() {
            string str = "A";
            Assert.IsFalse(StringUtility.isNullOrEmpty(str));
        }

        [TestMethod]
        public void test_validCharacters() {
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-abcdefghijklmnopqrstuvwxyz";
            Assert.IsFalse(StringUtility.containsInvalidCharacters(str));
        }

        [TestMethod]
        public void test_invalidCharacters() {
            string str = "#";
            Assert.IsTrue(StringUtility.containsInvalidCharacters(str));
        }
    }
}
