using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class Book : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private string _number;
        private string _author;
        private string _publisher;
        const string PROPERTY_NAME = "Name";
        const string PROPERTY_NUMBER = "Number";
        const string PROPERTY_AUTHOR = "Author";
        const string PROPERTY_PUBLISHER = "Publisher";

        public Book(string name, string number, string author, string publisher)
        {
            _name = name;
            _number = number;
            _author = author;
            _publisher = publisher;
        }

        //給書名
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

        //給 ISBN
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

        //給作者
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

        //給出版者
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

        //Observer / DataBinding 用
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
