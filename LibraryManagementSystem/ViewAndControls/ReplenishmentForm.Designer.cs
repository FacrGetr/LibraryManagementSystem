
namespace LibraryManagementSystem
{
    partial class ReplenishmentForm
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
            this._title = new System.Windows.Forms.Label();
            this._bookInfoTexts = new System.Windows.Forms.RichTextBox();
            this._refillCountText = new System.Windows.Forms.Label();
            this._numberInput = new System.Windows.Forms.TextBox();
            this._confirmButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _title
            // 
            this._title.AutoSize = true;
            this._title.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.Location = new System.Drawing.Point(324, 25);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(125, 46);
            this._title.TabIndex = 0;
            this._title.Text = "補貨單";
            // 
            // _bookInfoTexts
            // 
            this._bookInfoTexts.Enabled = false;
            this._bookInfoTexts.Font = new System.Drawing.Font("微软雅黑", 18F);
            this._bookInfoTexts.Location = new System.Drawing.Point(71, 95);
            this._bookInfoTexts.Name = "_bookInfoTexts";
            this._bookInfoTexts.Size = new System.Drawing.Size(642, 199);
            this._bookInfoTexts.TabIndex = 1;
            this._bookInfoTexts.Text = "";
            // 
            // _refillCountText
            // 
            this._refillCountText.AutoSize = true;
            this._refillCountText.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this._refillCountText.Location = new System.Drawing.Point(63, 309);
            this._refillCountText.Name = "_refillCountText";
            this._refillCountText.Size = new System.Drawing.Size(195, 46);
            this._refillCountText.TabIndex = 2;
            this._refillCountText.Text = "補貨數量：";
            // 
            // _numberInput
            // 
            this._numberInput.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this._numberInput.Location = new System.Drawing.Point(247, 309);
            this._numberInput.Name = "_numberInput";
            this._numberInput.Size = new System.Drawing.Size(100, 54);
            this._numberInput.TabIndex = 3;
            this._numberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressInputKey);
            // 
            // _confirmButton
            // 
            this._confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._confirmButton.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this._confirmButton.Location = new System.Drawing.Point(124, 385);
            this._confirmButton.Name = "_confirmButton";
            this._confirmButton.Size = new System.Drawing.Size(162, 53);
            this._confirmButton.TabIndex = 4;
            this._confirmButton.Text = "確認";
            this._confirmButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this._cancelButton.Location = new System.Drawing.Point(467, 385);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(162, 53);
            this._cancelButton.TabIndex = 5;
            this._cancelButton.Text = "取消";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // ReplenishmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._confirmButton);
            this.Controls.Add(this._numberInput);
            this.Controls.Add(this._refillCountText);
            this.Controls.Add(this._bookInfoTexts);
            this.Controls.Add(this._title);
            this.Name = "ReplenishmentForm";
            this.Text = "ReplenishmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.RichTextBox _bookInfoTexts;
        private System.Windows.Forms.Label _refillCountText;
        private System.Windows.Forms.TextBox _numberInput;
        private System.Windows.Forms.Button _confirmButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}