using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class BookCategory : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        const string PROPERTY_CATEGORY_NAME = "CategoryName";

        public BookCategory(string name, Book book)
        {
            _books = new List<Book>();
            _categoryName = name;
            _books.Add(book);
        }
                
        //取得我這種類叫啥
        public string CategoryName
        {
            get
            {
                return _categoryName;
            }
            set
            {
                _categoryName = value;
                Notify(PROPERTY_CATEGORY_NAME);
            }
        }

        //Observer / DataBinding 用
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //回傳書單
        public List<Book> GetBooks()
        {
            return _books;
        }
                
        //新增書籍
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        //確認這本書歸不歸我
        public bool BookIsInCategory(Book book)
        {
            return _books.Contains(book);
        }

        //旗下有幾種書
        public int GetBookCounts()
        {
            return _books.Count();
        }

        private string _categoryName;
        private List<Book> _books;
    }
}
