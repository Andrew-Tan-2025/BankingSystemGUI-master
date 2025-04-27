namespace BankingSystemGUI.Forms
{
    partial class AccountDetailsForm
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
            lblWelcome = new Label();
            groupBox1 = new GroupBox();
            lblCheckingBalance = new Label();
            lblCheckingNumber = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lblSavingsBalance = new Label();
            lblSavingsNumber = new Label();
            label5 = new Label();
            label6 = new Label();
            btnClose = new Button();
            btnStocks = new Button();
            goTrans = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(41, 38);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(198, 29);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, User!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCheckingBalance);
            groupBox1.Controls.Add(lblCheckingNumber);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(47, 109);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(432, 154);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Checking Account";
            // 
            // lblCheckingBalance
            // 
            lblCheckingBalance.AutoSize = true;
            lblCheckingBalance.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckingBalance.Location = new Point(195, 92);
            lblCheckingBalance.Margin = new Padding(4, 0, 4, 0);
            lblCheckingBalance.Name = "lblCheckingBalance";
            lblCheckingBalance.Size = new Size(49, 18);
            lblCheckingBalance.TabIndex = 3;
            lblCheckingBalance.Text = "$0.00";
            // 
            // lblCheckingNumber
            // 
            lblCheckingNumber.AutoSize = true;
            lblCheckingNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckingNumber.Location = new Point(195, 46);
            lblCheckingNumber.Margin = new Padding(4, 0, 4, 0);
            lblCheckingNumber.Name = "lblCheckingNumber";
            lblCheckingNumber.Size = new Size(98, 18);
            lblCheckingNumber.TabIndex = 2;
            lblCheckingNumber.Text = "0000000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 18);
            label3.TabIndex = 1;
            label3.Text = "Balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 18);
            label2.TabIndex = 0;
            label2.Text = "Account Number:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSavingsBalance);
            groupBox2.Controls.Add(lblSavingsNumber);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(47, 294);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(432, 154);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Savings Account";
            // 
            // lblSavingsBalance
            // 
            lblSavingsBalance.AutoSize = true;
            lblSavingsBalance.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSavingsBalance.Location = new Point(195, 92);
            lblSavingsBalance.Margin = new Padding(4, 0, 4, 0);
            lblSavingsBalance.Name = "lblSavingsBalance";
            lblSavingsBalance.Size = new Size(49, 18);
            lblSavingsBalance.TabIndex = 3;
            lblSavingsBalance.Text = "$0.00";
            // 
            // lblSavingsNumber
            // 
            lblSavingsNumber.AutoSize = true;
            lblSavingsNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSavingsNumber.Location = new Point(195, 46);
            lblSavingsNumber.Margin = new Padding(4, 0, 4, 0);
            lblSavingsNumber.Name = "lblSavingsNumber";
            lblSavingsNumber.Size = new Size(98, 18);
            lblSavingsNumber.TabIndex = 2;
            lblSavingsNumber.Text = "0000000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 92);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 1;
            label5.Text = "Balance:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 46);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 18);
            label6.TabIndex = 0;
            label6.Text = "Account Number:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(259, 505);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 30);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnStocks
            // 
            btnStocks.Location = new Point(90, 505);
            btnStocks.Margin = new Padding(4, 5, 4, 5);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(137, 30);
            btnStocks.TabIndex = 6;
            btnStocks.Text = "Stock Market";
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // goTrans
            // 
            goTrans.Location = new Point(176, 468);
            goTrans.Name = "goTrans";
            goTrans.Size = new Size(137, 29);
            goTrans.TabIndex = 7;
            goTrans.Text = "Transfer Funds";
            goTrans.UseVisualStyleBackColor = true;
            goTrans.Click += goTrans_Click;
            // 
            // AccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 571);
            Controls.Add(goTrans);
            Controls.Add(btnStocks);
            Controls.Add(btnClose);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "AccountDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Details";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCheckingBalance;
        private System.Windows.Forms.Label lblCheckingNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSavingsBalance;
        private System.Windows.Forms.Label lblSavingsNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStocks;
        private Button goTrans;
    }
}