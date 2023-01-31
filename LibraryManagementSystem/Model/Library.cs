using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class Library : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event ModelChangedEventHandler _bookQuantityChanged;
        public delegate void ModelChangedEventHandler();

        bool _isBorrowingEnable = true;
        bool _isInventoryEnable = true;

        const int QUANTITY = 0;
        const int CATEGORY = 1;
        const int NAME = 2;
        const int NUMBER = 3;
        const int AUTHOR = 4;
        const int PUBLISHER = 5;
        BindingList<BookItem> _bookItems;
        BindingList<BookCategory> _bookCategories;
        BorrowedList _borrowedList;
        const string DATA_SPLITER = "BOOK";
        const char BOOK_INFO_SPLITER = '*';
        const string PROPERTY_BORROW_ENABLE = "IsBorrowingEnable";
        const string PROPERTY_INVENTORY_ENABLE = "IsInventoryEnable";

        public BindingList<BookItem> BookItems
        {
            get
            {
                return _bookItems;
            }
        }

        public BindingList<BookCategory> BookCategories
        {
            get
            {
                return _bookCategories;
            }
        }

        public Library()
        {
            _borrowedList = new BorrowedList();
            _bookItems = new BindingList<BookItem>();
            _bookCategories = new BindingList<BookCategory>();
        }

        public bool IsBorrowingEnable
        {
            get
            {
                return _isBorrowingEnable;
            }
            set
            {
                _isBorrowingEnable = value;
                Notify(PROPERTY_BORROW_ENABLE);
            }
        }

        public bool IsInventoryEnable
        {
            get
            {
                return _isInventoryEnable;
            }
            set
            {
                _isInventoryEnable = value;
                Notify(PROPERTY_INVENTORY_ENABLE);
            }
        }

        //Observer / DataBinding 用
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //讀檔
        public void ReadFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                if (line == DATA_SPLITER)
                {
                    line = streamReader.ReadLine();
                    AnalyzeBookInput(streamReader, line);
                }
                line = streamReader.ReadLine();
            }
        }

        //讀檔過程中每筆書的資料個別處理
        private void AnalyzeBookInput(StreamReader streamReader, string line)
        {
            string bookInfo = "";
            while (line != "" && line != null)
            {
                if (bookInfo != "")
                {
                    bookInfo += BOOK_INFO_SPLITER;
                }
                bookInfo += line;
                line = streamReader.ReadLine();
            }
            MakeNewBook(bookInfo);
        }

        //建立新的書物件
        private void MakeNewBook(string bookInfo)
        {
            string[] bookInfos = bookInfo.Split(BOOK_INFO_SPLITER);

            Book book = new Book(bookInfos[NAME], bookInfos[NUMBER], bookInfos[AUTHOR], bookInfos[PUBLISHER]);
            _bookItems.Add(new BookItem(int.Parse(bookInfos[QUANTITY]), book));

            //先看一遍分類是否已有現成的
            foreach (BookCategory category in _bookCategories)
            {
                if (category.CategoryName == bookInfos[CATEGORY])
                {
                    //有就直接加上去
                    category.AddBook(book);
                    return;
                }
            }
            //沒有就自己開闢新未來
            _bookCategories.Add(new BookCategory(bookInfos[CATEGORY], book));
        }

        //依照歸檔時的順序找書名
        public string GetBookNameByOrder(int order)
        {
            return _bookItems[order].GetBook().Name;
        }

        //依照歸檔時的順序找作者    
        public string GetBookAuthorByOrder(int order)
        {
            return _bookItems[order].GetBook().Author;
        }

        //依照歸檔時的順序找 ISBN
        public string GetBookNumberByOrder(int order)
        {
            return _bookItems[order].GetBook().Number;
        }

        //依照歸檔時的順序找出版者
        public string GetBookPublisherByOrder(int order)
        {
            return _bookItems[order].GetBook().Publisher;
        }

        //依照歸檔時的順序找書剩餘數
        public int GetBookQuantityByOrder(int order)
        {
            return _bookItems[order].Quantity;
        }

        //依照歸檔時的順序找書(整本)
        private Book FindBook(int bookOrder)
        {
            return _bookItems[bookOrder].GetBook();
        }

        //借這清單書
        public void BorrowBook(List<int> borrowList, BindingList<MyBorrowItem> myBorrowList)
        {
            for (int i = 0; i < borrowList.Count; i++)
            {
                int borrowedNum = myBorrowList[i].Count;
                _bookItems[borrowList[i]].SetQuantityDownBy(borrowedNum);
                _borrowedList.MakeNewBorrow(FindBook(borrowList[i]), borrowedNum);
            }

        }

        //全館共有幾種書
        public int GetBookTotals()
        {
            return _bookItems.Count();
        }

        //共有幾種分類法
        public int GetCategoryCounts()
        {
            return _bookCategories.Count();
        }

        //某分類旗下有幾種書
        public int GetBookCountsInCategoryNumber(int categoryNumber)
        {
            return _bookCategories[categoryNumber].GetBookCounts();
        }

        //問第 N 跟分類名字叫啥
        public string GetCategoryName(int categoryOrder)
        {
            return _bookCategories[categoryOrder].CategoryName;
        }

        //問這本書是哪個類組的
        public string GetBookCategory(int bookOrder)
        {
            Book book = _bookItems[bookOrder].GetBook();
            foreach (BookCategory category in _bookCategories)
            {
                if (category.BookIsInCategory(book))
                {
                    return category.CategoryName;
                }
            }
            return null;
        }

        //問借書單
        public List<BorrowedItem> GetBorrowedItems()
        {
            return _borrowedList.GetBorrowedItems();
        }

        //依照背包內的 Index 還書
        public void ReturnBookInPackNumber(int number, int quantity, bool isClear)
        {
            Book borrowedBook = _borrowedList.GetBorrowedItems()[number].GetBook();
            foreach (BookItem bookItem in _bookItems)
            {
                if (bookItem.GetBook() == borrowedBook)
                {
                    bookItem.Quantity += quantity;
                }
            }
            if (isClear)
                _borrowedList.RemoveBook(number);
        }

        //取得這本書剩幾本庫存
        public int GetBookQuantity(int bookIndex)
        {
            return _bookItems[bookIndex].Quantity;
        }

        //補貨
        public void Replenish(int index, int quantity)
        {
            _bookItems[index].Quantity += quantity;
            NotifyObserver();
        }

        //Observer / DataBinding 用
        void NotifyObserver()
        {
            if (_bookQuantityChanged != null)
                _bookQuantityChanged();
        }
    } 
}
