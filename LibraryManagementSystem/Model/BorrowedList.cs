using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BorrowedList
    {
        List<BorrowedItem> _borrowedItems;
        
        public BorrowedList()
        {
            _borrowedItems = new List<BorrowedItem>();
        }

        //借新的書
        public void MakeNewBorrow(Book book, int borrowedNumber)
        {
            _borrowedItems.Add(new BorrowedItem(book, borrowedNumber));
        }

        //告訴我借了哪些書
        public List<BorrowedItem> GetBorrowedItems()
        {
            return _borrowedItems;
        }

        //還書清單上第 N 本書 
        public void RemoveBook(int index)
        {
            _borrowedItems.RemoveAt(index);
        }

    }
}
