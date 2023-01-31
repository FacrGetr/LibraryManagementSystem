using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class BackPackFormPresentationModel
    {
        const string DATE_FORMAT = "yyyy/MM/dd";
        Library _library; 
        BindingList<MyBackPackItem> _backPackList = new BindingList<MyBackPackItem>();

        public BackPackFormPresentationModel(Library library)
        {
            _library = library;

            List<BorrowedItem> borrowedBooks = GetBorrowedItems();
            foreach (BorrowedItem borrowedItem in borrowedBooks)
            {
                _backPackList.Add(new MyBackPackItem(1,
                                        borrowedItem.GetBook().Name,
                                        borrowedItem.Quantity,
                                        borrowedItem.GetTime().ToString(DATE_FORMAT),
                                        borrowedItem.GetTime().AddDays(30).ToString(DATE_FORMAT),
                                        borrowedItem.GetBook().Number,
                                        borrowedItem.GetBook().Author,
                                        borrowedItem.GetBook().Publisher));
            }
        }

        public BindingList<MyBackPackItem> BackPackList
        {
            get
            {
                return _backPackList;
            }
        }

        //取得借書清單
        public List<BorrowedItem> GetBorrowedItems()
        {
            return _library.GetBorrowedItems();
        }

        //參照書在表單上的順序還書
        public void ReturnBookInPackNumber(int number, int quantity)
        {
            _backPackList[number].Quantity -= quantity;
            bool isEmpty = _backPackList[number].Quantity == 0;
            if (isEmpty)
            {
                _backPackList.RemoveAt(number);
            }
            _library.ReturnBookInPackNumber(number, quantity, isEmpty);
        }

    }
}
