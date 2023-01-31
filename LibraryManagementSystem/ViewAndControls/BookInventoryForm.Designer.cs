
namespace LibraryManagementSystem
{
    partial class BookInventoryForm
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
            this._title = new System.Windows.Forms.Label();
            this._bookInventory = new System.Windows.Forms.DataGridView();
            this._bookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._replenishment = new System.Windows.Forms.DataGridViewButtonColumn();
            this._bookInfo = new System.Windows.Forms.GroupBox();
            this._bookInfoTexts = new System.Windows.Forms.RichTextBox();
            this._bookImage = new System.Windows.Forms.GroupBox();
            this._image = new System.Windows.Forms.PictureBox();
            this._bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._bookItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._bookInventory)).BeginInit();
            this._bookInfo.SuspendLayout();
            this._bookImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _title
            // 
            this._title.AutoSize = true;
            this._title.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold);
            this._title.Location = new System.Drawing.Point(249, 9);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(292, 45);
            this._title.TabIndex = 0;
            this._title.Text = "書籍庫存管理系統";
            // 
            // _bookInventory
            // 
            this._bookInventory.AllowUserToAddRows = false;
            this._bookInventory.AllowUserToDeleteRows = false;
            this._bookInventory.AllowUserToResizeColumns = false;
            this._bookInventory.AllowUserToResizeRows = false;
            this._bookInventory.AutoGenerateColumns = false;
            this._bookInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._bookInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._bookInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._bookInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._bookName,
            this._bookCategory,
            this._bookQuantity,
            this._replenishment});
            this._bookInventory.DataSource = this._bookItemBindingSource1;
            this._bookInventory.Location = new System.Drawing.Point(12, 57);
            this._bookInventory.Name = "_bookInventory";
            this._bookInventory.RowHeadersVisible = false;
            this._bookInventory.RowTemplate.Height = 24;
            this._bookInventory.Size = new System.Drawing.Size(372, 381);
            this._bookInventory.TabIndex = 1;
            this._bookInventory.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ValidatingCell);
            // 
            // _bookCategory
            // 
            this._bookCategory.HeaderText = "書籍類別";
            this._bookCategory.Name = "_bookCategory";
            this._bookCategory.ReadOnly = true;
            // 
            // _replenishment
            // 
            this._replenishment.HeaderText = "補貨";
            this._replenishment.Name = "_replenishment";
            // 
            // _bookInfo
            // 
            this._bookInfo.Controls.Add(this._bookInfoTexts);
            this._bookInfo.Location = new System.Drawing.Point(390, 260);
            this._bookInfo.Name = "_bookInfo";
            this._bookInfo.Size = new System.Drawing.Size(398, 178);
            this._bookInfo.TabIndex = 2;
            this._bookInfo.TabStop = false;
            this._bookInfo.Text = "書籍介紹";
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
            // _bookImg
            // 
            this._bookImage.Controls.Add(this._image);
            this._bookImage.Location = new System.Drawing.Point(396, 57);
            this._bookImage.Name = "_bookImg";
            this._bookImage.Size = new System.Drawing.Size(392, 197);
            this._bookImage.TabIndex = 3;
            this._bookImage.TabStop = false;
            this._bookImage.Text = "書籍圖片";
            // 
            // _image
            // 
            this._image.Location = new System.Drawing.Point(6, 21);
            this._image.Name = "_image";
            this._image.Size = new System.Drawing.Size(191, 170);
            this._image.TabIndex = 0;
            this._image.TabStop = false;
            // 
            // _bookName
            // 
            this._bookName.DataPropertyName = "Name";
            this._bookName.HeaderText = "書籍名稱";
            this._bookName.Name = "_bookName";
            this._bookName.ReadOnly = true;
            // 
            // _bookQuantity
            // 
            this._bookQuantity.DataPropertyName = "Quantity";
            this._bookQuantity.HeaderText = "書籍數量";
            this._bookQuantity.Name = "_bookQuantity";
            // 
            // bookItemBindingSource1
            // 
            this._bookItemBindingSource1.DataSource = typeof(LibraryManagementSystem.BookItem);
            // 
            // bookItemBindingSource
            // 
            this._bookItemBindingSource.DataSource = typeof(LibraryManagementSystem.BookItem);
            // 
            // BookInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._bookImage);
            this.Controls.Add(this._bookInfo);
            this.Controls.Add(this._bookInventory);
            this.Controls.Add(this._title);
            this.Name = "BookInventoryForm";
            this.Text = "書本庫存";
            ((System.ComponentModel.ISupportInitialize)(this._bookInventory)).EndInit();
            this._bookInfo.ResumeLayout(false);
            this._bookImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.DataGridView _bookInventory;
        private System.Windows.Forms.GroupBox _bookInfo;
        private System.Windows.Forms.RichTextBox _bookInfoTexts;
        private System.Windows.Forms.GroupBox _bookImage;
        private System.Windows.Forms.BindingSource _bookItemBindingSource;
        private System.Windows.Forms.BindingSource _bookItemBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookQuantity;

       private System.Windows.Forms.DataGridViewButtonColumn _replenishment;
        private System.Windows.Forms.PictureBox _image;
    }
}