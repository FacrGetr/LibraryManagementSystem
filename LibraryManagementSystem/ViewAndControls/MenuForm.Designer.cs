
namespace LibraryManagementSystem
{
    partial class MenuForm
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
            this._bookBorrowingSystem = new System.Windows.Forms.Button();
            this._bookInventorySystem = new System.Windows.Forms.Button();
            this._exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _bookBorrowingSystem
            // 
            this._bookBorrowingSystem.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold);
            this._bookBorrowingSystem.Location = new System.Drawing.Point(12, 12);
            this._bookBorrowingSystem.Name = "_bookBorrowingSystem";
            this._bookBorrowingSystem.Size = new System.Drawing.Size(776, 172);
            this._bookBorrowingSystem.TabIndex = 0;
            this._bookBorrowingSystem.Text = "Book Borrowing System";
            this._bookBorrowingSystem.UseVisualStyleBackColor = true;
            this._bookBorrowingSystem.Click += new System.EventHandler(this.ClickOnBookBorrowingSystem);
            // 
            // _bookInventorySystem
            // 
            this._bookInventorySystem.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold);
            this._bookInventorySystem.Location = new System.Drawing.Point(12, 196);
            this._bookInventorySystem.Name = "_bookInventorySystem";
            this._bookInventorySystem.Size = new System.Drawing.Size(776, 172);
            this._bookInventorySystem.TabIndex = 0;
            this._bookInventorySystem.Text = "Book Inventory System";
            this._bookInventorySystem.UseVisualStyleBackColor = true;
            this._bookInventorySystem.Click += new System.EventHandler(this.ClickOnBookInventorySystem);
            // 
            // _exit
            // 
            this._exit.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this._exit.Location = new System.Drawing.Point(617, 383);
            this._exit.Name = "_exit";
            this._exit.Size = new System.Drawing.Size(171, 43);
            this._exit.TabIndex = 0;
            this._exit.Text = "Exit";
            this._exit.UseVisualStyleBackColor = true;
            this._exit.Click += new System.EventHandler(this.Exit);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._exit);
            this.Controls.Add(this._bookInventorySystem);
            this.Controls.Add(this._bookBorrowingSystem);
            this.Name = "MenuForm";
            this.Text = "首頁";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _bookBorrowingSystem;
        private System.Windows.Forms.Button _bookInventorySystem;
        private System.Windows.Forms.Button _exit;
    }
}