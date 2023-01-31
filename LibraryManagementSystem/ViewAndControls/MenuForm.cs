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
    public partial class MenuForm : Form
    {
        MenuFormPresentationModel _model;

        public MenuForm(MenuFormPresentationModel model)
        {
            _model = model;
            InitializeComponent();

            _bookBorrowingSystem.DataBindings.Add("Enabled", _model.GetLibrary(), "IsBorrowingEnable");
            _bookInventorySystem.DataBindings.Add("Enabled", _model.GetLibrary(), "IsInventoryEnable");
        }

        //開後台視窗
        private void ClickOnBookInventorySystem(object sender, EventArgs e)
        {
            BookInventoryForm bookInventoryForm = new BookInventoryForm(new BookInventoryFormPresentationModel(_model.GetLibrary()));
            bookInventoryForm.Show();
            _model.ClickInventory();
        }

        //開前台視窗
        private void ClickOnBookBorrowingSystem(object sender, EventArgs e)
        {
            BookBorrowingForm bookBorrowingForm = new BookBorrowingForm(new BookBorrowingFormPresentationModel(_model.GetLibrary()));
            bookBorrowingForm.Show();
            _model.ClickBorrowing();
        }

        //關視窗
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
