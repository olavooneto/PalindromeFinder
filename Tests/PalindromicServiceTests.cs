using Microsoft.VisualStudio.TestTools.UnitTesting;
using palindromicFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromicFinder.Tests
{
    [TestClass()]
    public class PalindromicServiceTests
    {
        [TestMethod()]
        public void FindPalindromicTest01()
        {
            var palindomicService = new PalindromicService();
            var actual = palindomicService.FindPalindromic("abac");
            var expected = "aba";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindPalindromicTest02()
        {
            var palindomicService = new PalindromicService();
            var actual = palindomicService.FindPalindromic("tacag");
            var expected = "aca";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindPalindromicTest03()
        {
            var palindomicService = new PalindromicService();
            var actual = palindomicService.FindPalindromic("wegeeksskeegyuwe");
            var expected = "geeksskeeg";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindPalindromicTest04()
        {
            var palindomicService = new PalindromicService();
            var actual = palindomicService.FindPalindromic("olavo");
            var expected = "o";

            Assert.AreEqual(expected, actual);
        }
    }
}