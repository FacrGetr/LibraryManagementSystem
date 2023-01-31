using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LibraryManagementSystem
{
    public class BookInventoryFormPresentationModel
    {
        Library _library;

        public BookInventoryFormPresentationModel(Library library)
        {
            _library = library;
        }

        public BindingList<BookItem> BookItems
        {
            get
            {
                return _library.BookItems;
            }
        }

        //取得這本書的分類名
        public string GetCategory(int index)
        {
            return _library.GetBookCategory(index);
        }

        //關視窗時告訴 Model 可以開新的了
        public void Exit()
        {
            _library.IsInventoryEnable = true;
        }

        //取得現在要顯示的書名
        public string GetBookName(int index)
        {
            return _library.GetBookNameByOrder(index);
        }

        //取得現在要顯示的 ISBN
        public string GetBookNumber(int index)
        {
            return _library.GetBookNumberByOrder(index);
        }

        //取得現在要顯示的作者
        public string GetBookAuthor(int index)
        {
            return _library.GetBookAuthorByOrder(index);
        }

        //取得現在要顯示的出版者
        public string GetBookPublisher(int index)
        {
            return _library.GetBookPublisherByOrder(index);
        }

        //補貨
        public void Replenish(int index, int quantity)
        {
            _library.Replenish(index, quantity);
        }
    }
}
