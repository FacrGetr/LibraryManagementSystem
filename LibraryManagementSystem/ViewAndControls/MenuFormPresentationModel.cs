using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class MenuFormPresentationModel
    {
        Library _library;

        public MenuFormPresentationModel(Library library)
        {
            _library = library;
        }

        //問圖書館是哪間
        public Library GetLibrary()
        {
            return _library;
        }

        //按庫存系統按鈕
        public void ClickInventory()
        {
            _library.IsInventoryEnable = false;
        }

        //按借書系統按鈕
        public void ClickBorrowing()
        {
            _library.IsBorrowingEnable = false;
        }
    }
}
