using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class BookItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        const string PROPERTY_NAME = "Name";
        const string PROPERTY_NUMBER = "Number";
        const string PROPERTY_AUTHOR = "Author";
        const string PROPERTY_PUBLISHER = "Publisher";
        const string PROPERTY_QUANTITY = "Quantity";

        private int _quantity;
        private Book _book;
        public BookItem(int quantity, Book book)
        {
            _quantity = quantity;
            _book = book;
        }
                
        //取得書有幾本
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                Notify(PROPERTY_QUANTITY);
            }
        }
        //給書名
        public string Name
        {
            get
            {
                return _book.Name;
            }
            set
            {
                _book.Name = value;
                Notify(PROPERTY_NAME);
            }
        }

        //給 ISBN
        public string Number
        {
            get
            {
                return _book.Number;
            }
            set
            {
                _book.Number = value;
                Notify(PROPERTY_NUMBER);
            }
        }

        //給作者
        public string Author
        {
            get
            {
                return _book.Author;
            }
            set
            {
                _book.Author = value;
                Notify(PROPERTY_AUTHOR);
            }
        }

        //給出版者
        public string Publisher
        {
            get
            {
                return _book.Publisher;
            }
            set
            {
                _book.Publisher = value;
                Notify(PROPERTY_PUBLISHER);
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

        //書本數量減少 N
        public void SetQuantityDownBy(int value)
        {
            Quantity -= value;
        }
               
        //取得這是哪一本
        public Book GetBook()
        {
            return _book;
        }
    }
}
