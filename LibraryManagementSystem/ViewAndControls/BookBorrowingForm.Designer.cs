
namespace LibraryManagementSystem
{
    partial class BookBorrowingForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this._pages = new System.Windows.Forms.Label();
            this._nextPage = new System.Windows.Forms.Button();
            this._lastPage = new System.Windows.Forms.Button();
            this._addToBorrowList = new System.Windows.Forms.Button();
            this._bestSells = new System.Windows.Forms.TabControl();
            this._groupBox2 = new System.Windows.Forms.GroupBox();
            this._booksQuantity = new System.Windows.Forms.Label();
            this._bookInfoTexts = new System.Windows.Forms.RichTextBox();
            this._borrowListTitle = new System.Windows.Forms.Label();
            this._borrowedBooksList = new System.Windows.Forms.DataGridView();
            this._deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookCounts = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._bookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._myBorrowItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._borrowConfirm = new System.Windows.Forms.Button();
            this._borrowedNumber = new System.Windows.Forms.Label();
            this._myPack = new System.Windows.Forms.Button();
            this._groupBox1.SuspendLayout();
            this._groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._borrowedBooksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._myBorrowItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _groupBox1
            // 
            this._groupBox1.Controls.Add(this._pages);
            this._groupBox1.Controls.Add(this._nextPage);
            this._groupBox1.Controls.Add(this._lastPage);
            this._groupBox1.Controls.Add(this._addToBorrowList);
            this._groupBox1.Controls.Add(this._bestSells);
            this._groupBox1.Controls.Add(this._groupBox2);
            this._groupBox1.Location = new System.Drawing.Point(12, 12);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(408, 426);
            this._groupBox1.TabIndex = 0;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "書籍";
            // 
            // _pages
            // 
            this._pages.AutoSize = true;
            this._pages.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pages.Location = new System.Drawing.Point(19, 403);
            this._pages.Name = "_pages";
            this._pages.Size = new System.Drawing.Size(64, 21);
            this._pages.TabIndex = 4;
            this._pages.Text = "Page：";
            // 
            // _nextPage
            // 
            this._nextPage.Location = new System.Drawing.Point(219, 402);
            this._nextPage.Name = "_nextPage";
            this._nextPage.Size = new System.Drawing.Size(75, 23);
            this._nextPage.TabIndex = 3;
            this._nextPage.Text = "下一頁";
            this._nextPage.UseVisualStyleBackColor = true;
            this._nextPage.Click += new System.EventHandler(this.ClickNextPage);
            // 
            // _lastPage
            // 
            this._lastPage.Location = new System.Drawing.Point(138, 402);
            this._lastPage.Name = "_lastPage";
            this._lastPage.Size = new System.Drawing.Size(75, 23);
            this._lastPage.TabIndex = 3;
            this._lastPage.Text = "上一頁";
            this._lastPage.UseVisualStyleBackColor = true;
            this._lastPage.Click += new System.EventHandler(this.ClickLastPage);
            // 
            // _addToBorrowList
            // 
            this._addToBorrowList.Enabled = false;
            this._addToBorrowList.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addToBorrowList.Location = new System.Drawing.Point(300, 400);
            this._addToBorrowList.Name = "_addToBorrowList";
            this._addToBorrowList.Size = new System.Drawing.Size(108, 24);
            this._addToBorrowList.TabIndex = 2;
            this._addToBorrowList.Text = "加入借書單";
            this._addToBorrowList.UseVisualStyleBackColor = true;
            this._addToBorrowList.Click += new System.EventHandler(this.AddToBorrowListClick);
            // 
            // _bestSells
            // 
            this._bestSells.Location = new System.Drawing.Point(6, 21);
            this._bestSells.Name = "_bestSells";
            this._bestSells.SelectedIndex = 0;
            this._bestSells.Size = new System.Drawing.Size(390, 191);
            this._bestSells.TabIndex = 1;
            // 
            // _groupBox2
            // 
            this._groupBox2.Controls.Add(this._booksQuantity);
            this._groupBox2.Controls.Add(this._bookInfoTexts);
            this._groupBox2.Location = new System.Drawing.Point(10, 218);
            this._groupBox2.Name = "_groupBox2";
            this._groupBox2.Size = new System.Drawing.Size(426, 178);
            this._groupBox2.TabIndex = 0;
            this._groupBox2.TabStop = false;
            this._groupBox2.Text = "書籍介紹";
            // 
            // _booksQuantity
            // 
            this._booksQuantity.AutoSize = true;
            this._booksQuantity.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._booksQuantity.Location = new System.Drawing.Point(6, 163);
            this._booksQuantity.Name = "_booksQuantity";
            this._booksQuantity.Size = new System.Drawing.Size(72, 13);
            this._booksQuantity.TabIndex = 2;
            this._booksQuantity.Text = "剩餘數量：";
            // 
            // _bookInfoTexts
            // 
            this._bookInfoTexts.Enabled = false;
            this._bookInfoTexts.Location = new System.Drawing.Point(6, 21);
            this._bookInfoTexts.Name = "_bookInfoTexts";
            this._bookInfoTexts.Size = new System.Drawing.Size(380, 139);
            this._bookInfoTexts.TabIndex = 0;
            this._bookInfoTexts.Text = "";
            // 
            // _borrowListTitle
            // 
            this._borrowListTitle.AutoSize = true;
            this._borrowListTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._borrowListTitle.Location = new System.Drawing.Point(657, 9);
            this._borrowListTitle.Name = "_borrowListTitle";
            this._borrowListTitle.Size = new System.Drawing.Size(113, 40);
            this._borrowListTitle.TabIndex = 1;
            this._borrowListTitle.Text = "借書單";
            // 
            // _borrowedBooksList
            // 
            this._borrowedBooksList.AllowUserToAddRows = false;
            this._borrowedBooksList.AutoGenerateColumns = false;
            this._borrowedBooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._borrowedBooksList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._borrowedBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._borrowedBooksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteColumn,
            this._bookName,
            this._bookCounts,
            this._bookNumber,
            this._bookAuthor,
            this._bookPublisher});
            this._borrowedBooksList.DataSource = this._myBorrowItemBindingSource;
            this._borrowedBooksList.Location = new System.Drawing.Point(426, 52);
            this._borrowedBooksList.Name = "_borrowedBooksList";
            this._borrowedBooksList.RowHeadersVisible = false;
            this._borrowedBooksList.RowTemplate.Height = 24;
            this._borrowedBooksList.Size = new System.Drawing.Size(524, 335);
            this._borrowedBooksList.TabIndex = 2;
            this._borrowedBooksList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContent);
            this._borrowedBooksList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorrowedBooksListCellValueChanged);
            // 
            // deleteColumn
            // 
            this._deleteColumn.FillWeight = 60.91371F;
            this._deleteColumn.HeaderText = "刪除";
            this._deleteColumn.Name = "deleteColumn";
            // 
            // bookName
            // 
            this._bookName.DataPropertyName = "Name";
            this._bookName.FillWeight = 112.1885F;
            this._bookName.HeaderText = "書籍名稱";
            this._bookName.Name = "bookName";
            // 
            // bookCounts
            // 
            this._bookCounts.DataPropertyName = "Count";
            this._bookCounts.FillWeight = 90.33235F;
            this._bookCounts.HeaderText = "數量";
            this._bookCounts.Name = "bookCounts";
            this._bookCounts.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._bookCounts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bookISBN
            // 
            this._bookNumber.DataPropertyName = "Number";
            this._bookNumber.FillWeight = 112.1885F;
            this._bookNumber.HeaderText = "書籍編號";
            this._bookNumber.Name = "bookISBN";
            // 
            // bookAuthor
            // 
            this._bookAuthor.DataPropertyName = "Author";
            this._bookAuthor.FillWeight = 112.1885F;
            this._bookAuthor.HeaderText = "作者";
            this._bookAuthor.Name = "bookAuthor";
            // 
            // bookPublisher
            // 
            this._bookPublisher.DataPropertyName = "Publisher";
            this._bookPublisher.FillWeight = 112.1885F;
            this._bookPublisher.HeaderText = "出版項";
            this._bookPublisher.Name = "bookPublisher";
            // 
            // myBorrowItemBindingSource
            // 
            this._myBorrowItemBindingSource.DataSource = typeof(LibraryManagementSystem.MyBorrowItem);
            // 
            // _borrowConfirm
            // 
            this._borrowConfirm.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._borrowConfirm.Location = new System.Drawing.Point(816, 393);
            this._borrowConfirm.Name = "_borrowConfirm";
            this._borrowConfirm.Size = new System.Drawing.Size(134, 41);
            this._borrowConfirm.TabIndex = 3;
            this._borrowConfirm.Text = "確認借書";
            this._borrowConfirm.UseVisualStyleBackColor = true;
            this._borrowConfirm.Click += new System.EventHandler(this.ClickBorrowConfirm);
            // 
            // _borrowedNumber
            // 
            this._borrowedNumber.AutoSize = true;
            this._borrowedNumber.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._borrowedNumber.Location = new System.Drawing.Point(426, 403);
            this._borrowedNumber.Name = "_borrowedNumber";
            this._borrowedNumber.Size = new System.Drawing.Size(115, 21);
            this._borrowedNumber.TabIndex = 4;
            this._borrowedNumber.Text = "借書數量：";
            // 
            // _myPack
            // 
            this._myPack.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._myPack.Location = new System.Drawing.Point(656, 393);
            this._myPack.Name = "_myPack";
            this._myPack.Size = new System.Drawing.Size(154, 41);
            this._myPack.TabIndex = 3;
            this._myPack.Text = "查看我的書包";
            this._myPack.UseVisualStyleBackColor = true;
            this._myPack.Click += new System.EventHandler(this.ClickMyPack);
            // 
            // BookBorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this._borrowedNumber);
            this.Controls.Add(this._myPack);
            this.Controls.Add(this._borrowConfirm);
            this.Controls.Add(this._borrowedBooksList);
            this.Controls.Add(this._borrowListTitle);
            this.Controls.Add(this._groupBox1);
            this.Name = "BookBorrowingForm";
            this.Text = "借書";
            this._groupBox1.ResumeLayout(false);
            this._groupBox1.PerformLayout();
            this._groupBox2.ResumeLayout(false);
            this._groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._borrowedBooksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._myBorrowItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupBox1;
        private System.Windows.Forms.GroupBox _groupBox2;
        private System.Windows.Forms.RichTextBox _bookInfoTexts;
        private System.Windows.Forms.Button _addToBorrowList;
        private System.Windows.Forms.Label _booksQuantity;
        private System.Windows.Forms.Label _borrowListTitle;
        private System.Windows.Forms.DataGridView _borrowedBooksList;
        private System.Windows.Forms.Button _borrowConfirm;
        private System.Windows.Forms.Label _borrowedNumber;
        private System.Windows.Forms.TabControl _bestSells;
        private System.Windows.Forms.Label _pages;
        private System.Windows.Forms.Button _nextPage;
        private System.Windows.Forms.Button _lastPage;
        private System.Windows.Forms.Button _myPack;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookName;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _bookCounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookPublisher;
        private System.Windows.Forms.BindingSource _myBorrowItemBindingSource;
    }
}

