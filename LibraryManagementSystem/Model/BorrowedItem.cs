using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BorrowedItem
    {
        DateTime _borrowedTime;
        Book _book;
        int _quantity;

        public BorrowedItem(Book book, int quantity)
        {
            _borrowedTime = DateTime.Now;
            _book = book;
            _quantity = quantity;
        }

        //回傳書
        public Book GetBook()
        {
            return _book;
        }

        //回傳借書時間
        public DateTime GetTime()
        {
            return _borrowedTime;
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
    }
}
