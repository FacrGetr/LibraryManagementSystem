
namespace LibraryManagementSystem
{
    partial class BackPackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._backPackBooksList = new System.Windows.Forms.DataGridView();
            this._myBackPackItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._returnCount = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookCounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._timeBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._timeReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._backPackBooksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._myBackPackItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _backPackBooksList
            // 
            this._backPackBooksList.AllowUserToAddRows = false;
            this._backPackBooksList.AutoGenerateColumns = false;
            this._backPackBooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._backPackBooksList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._backPackBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._backPackBooksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteColumn,
            this._returnCount,
            this._bookName,
            this._bookCounts,
            this._timeBorrowed,
            this._timeReturn,
            this._bookNumber,
            this._bookAuthor,
            this._bookPublisher});
            this._backPackBooksList.DataSource = this._myBackPackItemBindingSource;
            this._backPackBooksList.Location = new System.Drawing.Point(12, 12);
            this._backPackBooksList.Name = "_backPackBooksList";
            this._backPackBooksList.RowHeadersVisible = false;
            this._backPackBooksList.RowTemplate.Height = 24;
            this._backPackBooksList.Size = new System.Drawing.Size(776, 426);
            this._backPackBooksList.TabIndex = 3;
            this._backPackBooksList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickOnBackPackBooksListCellContent);
            this._backPackBooksList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeBackPackListValue);
            // 
            // myBackPackItemBindingSource
            // 
            this._myBackPackItemBindingSource.DataSource = typeof(LibraryManagementSystem.MyBackPackItem);
            // 
            // deleteColumn
            // 
            this._deleteColumn.DataPropertyName = "Button";
            this._deleteColumn.FillWeight = 60.91371F;
            this._deleteColumn.HeaderText = "還書";
            this._deleteColumn.Name = "deleteColumn";
            this._deleteColumn.ReadOnly = true;
            this._deleteColumn.Text = "歸還";
            // 
            // _returnCount
            // 
            this._returnCount.DataPropertyName = "ReturnCount";
            this._returnCount.HeaderText = "歸還數量";
            this._returnCount.Name = "_returnCount";
            this._returnCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._returnCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bookName
            // 
            this._bookName.DataPropertyName = "BookName";
            this._bookName.FillWeight = 112.1885F;
            this._bookName.HeaderText = "書籍名稱";
            this._bookName.Name = "bookName";
            this._bookName.ReadOnly = true;
            // 
            // bookCounts
            // 
            this._bookCounts.DataPropertyName = "Quantity";
            this._bookCounts.FillWeight = 90.33235F;
            this._bookCounts.HeaderText = "數量";
            this._bookCounts.Name = "bookCounts";
            this._bookCounts.ReadOnly = true;
            // 
            // _timeBorrowed
            // 
            this._timeBorrowed.DataPropertyName = "Date";
            this._timeBorrowed.HeaderText = "借書日期";
            this._timeBorrowed.Name = "_timeBorrowed";
            this._timeBorrowed.ReadOnly = true;
            // 
            // _timeReturn
            // 
            this._timeReturn.DataPropertyName = "DateDue";
            this._timeReturn.HeaderText = "還書日期";
            this._timeReturn.Name = "_timeReturn";
            this._timeReturn.ReadOnly = true;
            // 
            // bookISBN
            // 
            this._bookNumber.DataPropertyName = "Number";
            this._bookNumber.FillWeight = 112.1885F;
            this._bookNumber.HeaderText = "書籍編號";
            this._bookNumber.Name = "bookISBN";
            this._bookNumber.ReadOnly = true;
            // 
            // bookAuthor
            // 
            this._bookAuthor.DataPropertyName = "Author";
            this._bookAuthor.FillWeight = 112.1885F;
            this._bookAuthor.HeaderText = "作者";
            this._bookAuthor.Name = "bookAuthor";
            this._bookAuthor.ReadOnly = true;
            // 
            // bookPublisher
            // 
            this._bookPublisher.DataPropertyName = "Publisher";
            this._bookPublisher.FillWeight = 112.1885F;
            this._bookPublisher.HeaderText = "出版項";
            this._bookPublisher.Name = "bookPublisher";
            this._bookPublisher.ReadOnly = true;
            // 
            // BackPackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._backPackBooksList);
            this.Name = "BackPackForm";
            this.Text = "BackPackForm";
            ((System.ComponentModel.ISupportInitialize)(this._backPackBooksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._myBackPackItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _backPackBooksList;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteColumn;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _returnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookCounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn _timeBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn _timeReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookPublisher;
        private System.Windows.Forms.BindingSource _myBackPackItemBindingSource;
    }
}