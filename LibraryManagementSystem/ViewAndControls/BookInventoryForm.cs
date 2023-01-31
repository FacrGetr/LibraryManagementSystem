using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookInventoryForm : Form
    {
        BookInventoryFormPresentationModel _model;
        const char END_OF_LINE = '\n';
        const int QUANTITY_INDEX = 2;
        public BookInventoryForm(BookInventoryFormPresentationModel model)
        {
            InitializeComponent();
            _bookInventory.CellPainting += PaintGridCell;
            _model = model;
            FormClosing += Exit;
            _bookInventory.DataSource = _model.BookItems;
            _bookInventory.CellClick += ClickCellContent;
            //_bindingSource.Add(_model.BookItems);
        }

        //因為 Databinding 是 BookItem，沒有類別，得自己爬一遍填上去
        private void GetCategories()
        {
            for (int i = 0; i < _bookInventory.RowCount; i++)
            {
                _bookInventory.Rows[i].Cells[1].Value = _model.GetCategory(i);
            }
        }

        //關視窗
        private void Exit(object sender, EventArgs e)
        {
            _model.Exit();
        }

        //給那個按鈕圖樣
        private void PaintGridCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 3)
            {
                Image img = Image.FromFile("../../../image/replenishment.png");
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = img.Width;
                var h = img.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            GetCategories();
        }

        //按 DataGridView 時，彈出補貨視窗，或在右方顯示資訊
        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            int bookIndex = e.RowIndex;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ShowReplenishmentWindow(bookIndex);
            } 
            if (e.RowIndex >= 0)
            {
                DisplayInfos(bookIndex);
            }

        }

        //補貨視窗
        private void ShowReplenishmentWindow(int bookIndex)
        {
            string bookInfo = "";
            bookInfo += "書籍名稱：" + _model.GetBookName(bookIndex) + END_OF_LINE;
            bookInfo += END_OF_LINE;
            bookInfo += "書籍類別：" + _model.GetCategory(bookIndex) + END_OF_LINE;
            bookInfo += "庫存數量：" + _model.BookItems[bookIndex].Quantity + END_OF_LINE;

            ReplenishmentForm popOut = new ReplenishmentForm(bookInfo);
            if (popOut.ShowDialog() == DialogResult.OK)
            {
                int quantity = int.Parse(popOut.Result);
                _model.Replenish(bookIndex, quantity);
            }
        }

        //顯示右方資訊
        private void DisplayInfos(int bookIndex)
        {
            _image.Image = Image.FromFile("../../../image/" + (bookIndex + 1) + ".jpg");

            //跟後端要資料，用來在下方框框顯示資訊
            string infoText = "";
            infoText += _model.GetBookName(bookIndex) + END_OF_LINE;
            infoText += "編號：" + _model.GetBookNumber(bookIndex) + END_OF_LINE;
            infoText += "作者：" + _model.GetBookAuthor(bookIndex) + END_OF_LINE;
            infoText += "出版項：" + _model.GetBookPublisher(bookIndex);

            _bookInfoTexts.Text = infoText;
        }

        //檢查更改的數量真的是數字嗎
        private void ValidatingCell(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == QUANTITY_INDEX)
            {
                int newInteger;

                if (!int.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("請輸入正整數");
                }
            }
        }
    }
}
