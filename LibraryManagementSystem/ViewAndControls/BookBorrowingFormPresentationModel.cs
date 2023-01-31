using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class BookBorrowingFormPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Library _library;
        int _nowDisplayBook;
        int _nowDisplayCategory;
        List<int> _borrowList;
        int _bookButtonCounter;
        const int BOOK_COUNTS_FOR_EVERY_PAGE = 3;
        const int NULL = -1;
        const int MAX_BORROW_NUMBER = 5;
        int _page;
        string _quantityText;
        string _borrowedQuantityText = "";
        BindingList<MyBorrowItem> _myBorrows = new BindingList<MyBorrowItem>();

        public BookBorrowingFormPresentationModel(Library library)
        {
            _borrowList = new List<int>();
            _library = library;
            _bookButtonCounter = 0;
            _nowDisplayBook = NULL;
            _page = 1;
            _nowDisplayCategory = 0;
            _library._bookQuantityChanged += ResetText;
        }

        public string BorrowedQuantityText
        {
            get
            {
                return _borrowedQuantityText;
            }
            set
            {
                _borrowedQuantityText = value;
                Notify("BorrowedQuantityText");
            }
        }

        public List<int> BorrowList
        {
            get
            {
                return _borrowList;
            }
        }

        public BindingList<MyBorrowItem> MyBorrows
        {
            get
            {
                return _myBorrows;
            }
        }

        public string QuantityText
        {
            get
            {
                return _quantityText;
            }
        }

        //關視窗時告知 Model 可以開新的了
        public void Exit()
        {
            _library.IsBorrowingEnable = true;
        }

        //取得現在顯示的是哪個月的暢銷書
        public int GetNowDisplay()
        {
            return _nowDisplayCategory;
        }

        //取得現在是第幾頁
        public int GetPage()
        {
            return _page;
        }

        //上一頁
        public void GoPreviousPage()
        {
            _page--;
        }

        //下一頁
        public void GoNextPage()
        {
            _page++;
        }

        //能不能上一頁
        public bool IsPreviousEnabled()
        {
            return _page > 1;
        }

        //能不能下一頁
        public bool IsNextPageEnable()
        {
            return _page < GetPageCounts();
        }

        //確認一下一頁能有幾本書
        public int GetBookCountsForEveryPage()
        {
            return BOOK_COUNTS_FOR_EVERY_PAGE;
        }

        //書本按鈕記數
        public void MakeNewButton()
        {
            _bookButtonCounter++;
        }

        //現在書本按鈕數到第幾了
        public int GetButtonNumber()
        {
            return _bookButtonCounter;
        }

        //重抓一次數量的 Text
        private void ResetText()
        {
            _quantityText = "剩餘數量：" + GetBookQuantity();
            Notify("QuantityText");
        }

        //設定現在顯示的是哪本書
        public void ClickBookButton(int order)
        {
            _nowDisplayBook = order;
            ResetText();
        }

        //Observer / DataBinding 用
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //點暢銷月
        public void ClickCategoryTab(int order)
        {
            _nowDisplayCategory = order;
            _page = 1;
        }

        //取得現在要顯示的書名
        public string GetBookName()
        {
            return _library.GetBookNameByOrder(_nowDisplayBook);
        }

        //取得現在要顯示的 ISBN
        public string GetBookNumber()
        {
            return _library.GetBookNumberByOrder(_nowDisplayBook);
        }

        //取得現在要顯示的作者
        public string GetBookAuthor()
        {
            return _library.GetBookAuthorByOrder(_nowDisplayBook);
        }

        //取得現在要顯示的出版者
        public string GetBookPublisher()
        {
            return _library.GetBookPublisherByOrder(_nowDisplayBook);
        }

        //取得現在要顯示的數量
        public int GetBookQuantity()
        {
            return _library.GetBookQuantityByOrder(_nowDisplayBook);
        }

        //取得特定某本書有幾本
        public int GetBookQuantity(int bookIndex)
        {
            return _library.GetBookQuantityByOrder(bookIndex);
        }

        //新增目前畫面上顯示中的那本書，到右邊借書清單中
        public void AddToBorrowList()
        {
            if (!IsBooksEmpty())
            {
                _borrowList.Add(_nowDisplayBook);
                _myBorrows.Add(new MyBorrowItem(
                                GetBookName(),
                                1,
                                GetBookNumber(),
                                GetBookAuthor(),
                                GetBookPublisher()
                                )
                    );
                BorrowedQuantityText = "借書數量：" + GetBorrowedCounts();
            }
        }

        //從借書單中剃除
        public void RemoveFromBorrowList(int index)
        {
            _borrowList.RemoveAt(index);
        }

        //取得現在借了幾本在借書單裡
        public int GetBorrowedCounts()
        {
            int count = 0;
            foreach (MyBorrowItem borrowItem in _myBorrows)
            {
                count += borrowItem.Count;
            }
            return count;
        }

        //這本書給不給借
        public bool IsAddToBorrowListEnabled()
        {
            if (_nowDisplayBook == NULL ||
                _borrowList.Contains(_nowDisplayBook) ||
                _library.GetBookQuantity(_nowDisplayBook) == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        //借書單會塞太多嗎
        public bool IsTooMany()
        {
            return _borrowList.Count() == MAX_BORROW_NUMBER;
        }

        //這書空了嗎，還有剩嗎
        public bool IsBooksEmpty()
        {
            return !(_library.GetBookQuantityByOrder(_nowDisplayBook) > 0);
        }

        //確認一下該月暢銷書有幾本
        public int GetBookCountsInCategory(int categoryNumber)
        {
            return _library.GetBookCountsInCategoryNumber(categoryNumber);
        }

        //共有幾種暢銷月
        public int GetCategoryCounts()
        {
            return _library.GetCategoryCounts();
        }

        //取得暢銷月的名字
        public string GetCategoryName(int categoryOrder)
        {
            return _library.GetCategoryName(categoryOrder);
        }

        //算出現在共有幾頁的書
        public int GetPageCounts()
        {
            int bookCounts = _library.GetBookCountsInCategoryNumber(_nowDisplayCategory);
            double pageCount = Math.Ceiling((double)bookCounts / BOOK_COUNTS_FOR_EVERY_PAGE);
            return (int)pageCount;
        }

        //確認這個書本按鈕現在是要顯示還是不要顯示
        public bool IsThisBookButtonVisible(int tabIndex, int bookIndex)
        {
            if (_library.GetBookCategory(bookIndex) == _library.GetCategoryName(_nowDisplayCategory))
            {
                if (tabIndex >= (_page - 1) * BOOK_COUNTS_FOR_EVERY_PAGE
                    && tabIndex < _page * BOOK_COUNTS_FOR_EVERY_PAGE)
                {
                    return true;
                }
            }
            return false;
        }

        //借書單為空否
        public bool IsBorrowListEmpty()
        {
            return !(_borrowList.Count() > 0);
        }

        //取得所有借的書的各自書名
        public List<string> GetBorrowedBooksName()
        {
            List<string> bookNames = new List<string>();
            foreach (int bookIndex in _borrowList)
            {
                bookNames.Add(_library.GetBookNameByOrder(bookIndex));
            }
            return bookNames;
        }

        //確認借書
        public void ConfirmBorrow()
        {
            _library.BorrowBook(_borrowList, MyBorrows);
            _borrowList.Clear();
        }

        //告訴我圖書館是哪一間
        public Library GetLibrary()
        {
            return _library;
        }
    }
}
