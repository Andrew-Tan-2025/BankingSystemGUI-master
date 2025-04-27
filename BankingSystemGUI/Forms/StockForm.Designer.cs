namespace BankingSystemGUI.Forms
{
    partial class StockForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPresetUrls = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBuildStocks = new System.Windows.Forms.Button();
            this.txtStockUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQuoteResult = new System.Windows.Forms.Label();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstStocks = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Market Portal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPresetUrls);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnBuildStocks);
            this.groupBox1.Controls.Add(this.txtStockUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Stock Data";
            // 
            // cmbPresetUrls
            // 
            this.cmbPresetUrls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresetUrls.FormattingEnabled = true;
            this.cmbPresetUrls.Location = new System.Drawing.Point(90, 76);
            this.cmbPresetUrls.Name = "cmbPresetUrls";
            this.cmbPresetUrls.Size = new System.Drawing.Size(275, 21);
            this.cmbPresetUrls.TabIndex = 6;
            this.cmbPresetUrls.SelectedIndexChanged += new System.EventHandler(this.cmbPresetUrls_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select URL:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(19, 107);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready";
            // 
            // btnBuildStocks
            // 
            this.btnBuildStocks.Location = new System.Drawing.Point(383, 44);
            this.btnBuildStocks.Name = "btnBuildStocks";
            this.btnBuildStocks.Size = new System.Drawing.Size(90, 23);
            this.btnBuildStocks.TabIndex = 2;
            this.btnBuildStocks.Text = "Build Stock Data";
            this.btnBuildStocks.UseVisualStyleBackColor = true;
            this.btnBuildStocks.Click += new System.EventHandler(this.btnBuildStocks_Click);
            // 
            // txtStockUrl
            // 
            this.txtStockUrl.Location = new System.Drawing.Point(90, 46);
            this.txtStockUrl.Name = "txtStockUrl";
            this.txtStockUrl.Size = new System.Drawing.Size(275, 20);
            this.txtStockUrl.TabIndex = 1;
            this.txtStockUrl.Text = "finance.yahoo.com/most-active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Source URL:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQuoteResult);
            this.groupBox2.Controls.Add(this.btnGetQuote);
            this.groupBox2.Controls.Add(this.txtSymbol);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(26, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 132);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Quote";
            // 
            // lblQuoteResult
            // 
            this.lblQuoteResult.AutoSize = true;
            this.lblQuoteResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteResult.Location = new System.Drawing.Point(19, 89);
            this.lblQuoteResult.Name = "lblQuoteResult";
            this.lblQuoteResult.Size = new System.Drawing.Size(116, 15);
            this.lblQuoteResult.TabIndex = 3;
            this.lblQuoteResult.Text = "Enter a symbol...";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(181, 43);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(75, 23);
            this.btnGetQuote.TabIndex = 2;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(90, 45);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(76, 20);
            this.txtSymbol.TabIndex = 1;
            this.txtSymbol.Text = "NVDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Symbol:";
            // 
            // lstStocks
            // 
            this.lstStocks.FormattingEnabled = true;
            this.lstStocks.Location = new System.Drawing.Point(310, 254);
            this.lstStocks.Name = "lstStocks";
            this.lstStocks.Size = new System.Drawing.Size(206, 108);
            this.lstStocks.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Available Stocks:";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 388);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstStocks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Market Portal";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBuildStocks;
        private System.Windows.Forms.TextBox txtStockUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblQuoteResult;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstStocks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPresetUrls;
        private System.Windows.Forms.Label label5;
    }
}