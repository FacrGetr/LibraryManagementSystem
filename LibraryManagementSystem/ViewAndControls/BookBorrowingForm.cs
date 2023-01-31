using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewNumericUpDownElements;

namespace LibraryManagementSystem
{
    public partial class BookBorrowingForm : Form
    {
        const int LOCATION_X = 5;
        const int LOCATION_Y = 5;
        const int X_GAP = 125;
        const int WIDTH = 120;
        const int HEIGHT = 156;
        const int QUANTITY = 2;
        BookBorrowingFormPresentationModel _model;
        const char END_OF_LINE = '\n';

        public BookBorrowingForm(BookBorrowingFormPresentationModel model)
        {
            InitializeComponent();
            _model = model;
            _addToBorrowList.Enabled = false;
            _borrowedBooksList.CellPainting += PaintGridCell;
            _bestSells.SelectedIndexChanged += new EventHandler(ChangeCategoryTab);
            _booksQuantity.DataBindings.Add("Text", model, "QuantityText");
            _borrowedBooksList.DataSource = _model.MyBorrows;
            //_borrowedNumber.DataBindings.Add("Text", model, "BorrowedQuantityText");
            FormClosing += Exit;
            ConstructButtons();
            RefreshAll();
        }

        //建構按鈕們
        private void ConstructButtons()
        {
            for (int i = 0; i < _model.GetCategoryCounts(); i++)
            {
                TabPage bestSellMonthTab = new TabPage();
                bestSellMonthTab.Name = "_bestSell" + i;
                bestSellMonthTab.Text = _model.GetCategoryName(i);
                bestSellMonthTab.Tag = i;
                bestSellMonthTab.Location = new Point(4, 22);
                bestSellMonthTab.Size = new Size(249, 165);
                bestSellMonthTab.Parent = _bestSells;

                ConstructBookButtons(i);
            }
        }

        //建構按鈕們(左上角的書本們)
        private void ConstructBookButtons(int categoryNumber)
        {
            for (int i = 0; i < _model.GetBookCountsInCategory(categoryNumber); i++)
            {
                int bookCountsForEveryPage = _model.GetBookCountsForEveryPage();
                Button button = new Button();

                _bestSells.TabPages[categoryNumber].Controls.Add(button);
                button.Location = new Point(LOCATION_X + X_GAP * (i % bookCountsForEveryPage), LOCATION_Y);
                button.Tag = _model.GetButtonNumber();
                _model.MakeNewButton();
                button.Size = new Size(WIDTH, HEIGHT);
                button.Image = Image.FromFile("../../../image/" + ((int)button.Tag + 1) + ".jpg");
                button.Name = "book" + button.Tag;
                button.Click += new EventHandler(BookButtonClick);
            }
        }

        //更換 6 月 / 4 月暢銷書
        void ChangeCategoryTab(Object sender, EventArgs e)
        {
            _model.ClickCategoryTab(_bestSells.SelectedTab.TabIndex);
            RefreshAll();
        }

        //左上角那的書籍按鈕
        private void BookButtonClick(object sender, EventArgs e)        
        {
            Button button = (Button)sender;
            //告訴後端現在顯示的書是幾號
            _model.ClickBookButton((int)button.Tag);
            //跟後端要資料，用來在下方框框顯示資訊
            string infoText = "";
            infoText += _model.GetBookName() + END_OF_LINE;
            infoText += "編號：" + _model.GetBookNumber() + END_OF_LINE;
            infoText += "作者：" + _model.GetBookAuthor() + END_OF_LINE;
            infoText += "出版項：" + _model.GetBookPublisher();

            _bookInfoTexts.Text = infoText;
            RefreshAll();
        }

        //把現在顯示中的書加到借書清單裡
        private void AddToBorrowListClick(object sender, EventArgs e)
        {
            if (_model.IsTooMany())
            {
                MessageBox.Show("每次借書限借五本，您的借書單已滿");
            }
            else 
            {
                _model.AddToBorrowList();
            }
            RefreshAll();
        }

        //點下一頁
        private void ClickNextPage(object sender, EventArgs e)
        {
            _model.GoNextPage();
            RefreshAll();
        }

        //點上一頁
        private void ClickLastPage(object sender, EventArgs e)
        {
            _model.GoPreviousPage();
            RefreshAll();
        }

        //重新整理顯示畫面
        private void RefreshAll()
        {
            _borrowedNumber.Text = "借書數量：" + _model.GetBorrowedCounts();
            _addToBorrowList.Enabled = _model.IsAddToBorrowListEnabled();
            _pages.Text = "Page：" + _model.GetPage() + '/' + _model.GetPageCounts();
            _lastPage.Enabled = _model.IsPreviousEnabled();
            _nextPage.Enabled = _model.IsNextPageEnable();
            for (int i = 0; i < _model.GetCategoryCounts(); i++)
            {
                foreach (Control control in _bestSells.TabPages[i].Controls)
                {
                    if (control is Button)
                    {
                        control.Visible = _model.IsThisBookButtonVisible(control.TabIndex, (int)control.Tag);
                    }
                }
            }
        }

        //給那個按鈕垃圾桶圖樣
        private void PaintGridCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                Image img = Image.FromFile("../../../image/trash_can.png");
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = img.Width;
                var h = img.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        //垃圾桶按鈕的功能實作，從借書單移除
        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                senderGrid.Rows.RemoveAt(e.RowIndex);
                _model.RemoveFromBorrowList(e.RowIndex);
            }

            RefreshAll();
        }

        //確認借書
        private void ClickBorrowConfirm(object sender, EventArgs e)
        {
            if (_model.IsBorrowListEmpty())
            {
                MessageBox.Show("欸不是你還沒挑書欸","錯誤");
                return;
            }
            BorrowMessage();
            
            _model.ConfirmBorrow();
            _borrowedBooksList.Rows.Clear();
            _booksQuantity.Text = "剩餘數量：" + _model.GetBookQuantity();

            RefreshAll();
        }

        //成功借書時彈出來的對話框
        private void BorrowMessage()
        {
            List<string> bookNames = _model.GetBorrowedBooksName();
            string text = "";

            for (int i = 0; i < bookNames.Count; i++)
            {
                int count = (int)_borrowedBooksList.Rows[i].Cells[QUANTITY].Value;

                if (text != "")
                {
                    text += '、';
                }
                text += '【' + bookNames[i] + '】' + count + "本";
            }
            text += "\n\n已成功借出！";
            MessageBox.Show(text);
        }

        //打開包包
        private void ClickMyPack(object sender, EventArgs e)
        {
            BackPackForm backPackForm = new BackPackForm(new BackPackFormPresentationModel(_model.GetLibrary()));
            backPackForm.Show();
        }

        //關視窗
        private void Exit(object sender, EventArgs e)
        {
            _model.Exit();
        }

        //DataGridView 數值更動（就是那個up down）時做的事
        private void BorrowedBooksListCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewNumericUpDownColumn && e.RowIndex >= 0)
            {
                const int MAX_BORROW_LIMIT = 2;
                int count = (int)senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int bookquantity = _model.GetBookQuantity(_model.BorrowList[e.RowIndex]);

                if (count > bookquantity)
                {
                    senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = bookquantity;
                    MessageBox.Show("該書本剩餘數量不足", "庫存狀態");
                } else if (count > MAX_BORROW_LIMIT)
                {
                    senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = MAX_BORROW_LIMIT;
                    MessageBox.Show("同一本書一次限借2本", "借書違規");
                }
                RefreshAll();
            }
        }
    }
}
