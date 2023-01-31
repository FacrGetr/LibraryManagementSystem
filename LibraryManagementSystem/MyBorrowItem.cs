using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class MyBorrowItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string _name;
        int _count;
        string _number;
        string _author;
        string _publisher;
        const string PROPERTY_NAME = "Name";
        const string PROPERTY_COUNT = "Count";
        const string PROPERTY_NUMBER = "Number";
        const string PROPERTY_AUTHOR = "Author";
        const string PROPERTY_PUBLISHER = "Publisher";

        public MyBorrowItem(string name, int count, string number, string author, string publisher)
        {
            _name = name;
            _count = count;
            _number = number;
            _author = author;
            _publisher = publisher;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                Notify(PROPERTY_NAME);
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                Notify(PROPERTY_COUNT);
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                Notify(PROPERTY_NUMBER);
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                Notify(PROPERTY_AUTHOR);
            }
        }

        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
                Notify(PROPERTY_PUBLISHER);
            }
        }

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
