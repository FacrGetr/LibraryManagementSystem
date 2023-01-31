using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class MyBackPackItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        int _returnCount;
        string _bookName;
        int _quantity;
        string _date;
        string _dateDue;
        string _number;
        string _author;
        string _publisher;
        const string PROPERTY_RETURN_COUNT = "ReturnCount";
        const string PROPERTY_QUANTITY = "Quantity";
        const string BUTTON_TEXT = "歸還";

        public MyBackPackItem(int returnCount, string bookName, int quantity, string date, string dateDue, string number, string author, string publisher)
        {
            _returnCount = returnCount;
            _bookName = bookName;
            _quantity = quantity;
            _date = date;
            _dateDue = dateDue;
            _number = number;
            _author = author;
            _publisher = publisher;
        }

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Button
        {
            get
            {
                return BUTTON_TEXT;
            }
        }

        public int ReturnCount
        {
            get
            {
                return _returnCount;
            }
            set
            {
                _returnCount = value;
                Notify(PROPERTY_RETURN_COUNT);
            }
        }

        public string BookName
        {
            get
            {
                return _bookName;
            }
        }

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

        public string Date
        {
            get
            {
                return _date;
            }
        }

        public string DateDue
        {
            get
            {
                return _dateDue;
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
        }

        public string Publisher
        {
            get
            {
                return _publisher;
            }
        }
    }
}
