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
    public partial class BackPackForm : Form
    {
        BackPackFormPresentationModel _model;
        public BackPackForm(BackPackFormPresentationModel model)
        {
            _model = model;
            InitializeComponent();
            _backPackBooksList.DataSource = _model.BackPackList;
            //_model.Reset();
        }

        //歸還按鈕實作
        private void ClickOnBackPackBooksListCellContent(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int quantity = (int)senderGrid.Rows[e.RowIndex].Cells[1].Value;

                string bookName = _model.GetBorrowedItems()[e.RowIndex].GetBook().Name;
                string text = '【' + bookName + '】' + "已成功歸還" + quantity + "本";
                MessageBox.Show(text);
                _model.ReturnBookInPackNumber(e.RowIndex, quantity);
            }
        }

        //每當有數值改變（就是那個up down）時做的事，判斷還書邏輯有沒有錯
        private void ChangeBackPackListValue(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewNumericUpDownColumn && e.RowIndex >= 0)
            {
                int count = (int)senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int borrowedQuantity = (int)senderGrid.Rows[e.RowIndex].Cells[3].Value;
                const string ERROR_MESSAGE_TITLE = "還書錯誤";
                if (count > borrowedQuantity)
                {
                    senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = borrowedQuantity;
                    MessageBox.Show("還書數量不能超過已借數量", ERROR_MESSAGE_TITLE);
                }
                else if (count == 0)
                {
                    senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                    MessageBox.Show("您至少要還一本書", ERROR_MESSAGE_TITLE);
                }
            }
        }
    }
}
