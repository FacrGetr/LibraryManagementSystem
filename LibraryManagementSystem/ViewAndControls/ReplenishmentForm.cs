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
    public partial class ReplenishmentForm : Form
    {
        public ReplenishmentForm(string bookInfo)
        {
            InitializeComponent();

            _bookInfoTexts.Text = bookInfo;
        }

        public string Result
        {
            get
            {
                return _numberInput.Text;
            }
        }

        //檢查輸入的是不是數字，是才給過
        private void PressInputKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
