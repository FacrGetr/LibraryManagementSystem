using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Tests
{
    [TestClass()]
    public class BookTests
    {
        const string NAME = "書名";
        const string NUMBER = "ISBN";
        const string AUTHER = "作者";
        const string PUBLISHER = "出版者";
        const string NEW_NAME = "新書名";
        const string NEW_NUMBER = "新ISBN";
        const string NEW_AUTHER = "新作者";
        const string NEW_PUBLISHER = "新出版者";
        Book _book;

        [TestInitialize()]
        public void Initialize()
        {
            _book = new Book(NAME, NUMBER, AUTHER, PUBLISHER);
        }
        [TestMethod()]
        public void BookTest()
        {
            Assert.AreEqual(NAME, _book.Name);
            Assert.AreEqual(NUMBER, _book.Number);
            Assert.AreEqual(AUTHER, _book.Author);
            Assert.AreEqual(PUBLISHER, _book.Publisher);
            _book.Name = NEW_NAME;
            _book.Number = NEW_NUMBER;
            _book.Author = NEW_AUTHER;
            _book.Publisher = NEW_PUBLISHER;
            Assert.AreEqual(NEW_NAME, _book.Name);
            Assert.AreEqual(NEW_NUMBER, _book.Number);
            Assert.AreEqual(NEW_AUTHER, _book.Author);
            Assert.AreEqual(NEW_PUBLISHER, _book.Publisher);
    }
    }
}