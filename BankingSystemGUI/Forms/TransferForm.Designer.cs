namespace BankingSystemGUI.Forms
{
    partial class TransferForm
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sndFrom = new ComboBox();
            sndTo = new ComboBox();
            label4 = new Label();
            FndTxt = new TextBox();
            groupBox1 = new GroupBox();
            StatusMessage = new Label();
            TransferFunc = new Button();
            DepositStatus = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 120000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label1.Location = new Point(246, 36);
            label1.Name = "label1";
            label1.Size = new Size(231, 36);
            label1.TabIndex = 0;
            label1.Text = "Transfer Funds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 42);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Transfer Funds from: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 76);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 2;
            label3.Text = "Transfer Funds to: ";
            // 
            // sndFrom
            // 
            sndFrom.FormattingEnabled = true;
            sndFrom.Items.AddRange(new object[] { "Savings", "Checkings" });
            sndFrom.Location = new Point(184, 39);
            sndFrom.Name = "sndFrom";
            sndFrom.Size = new Size(151, 28);
            sndFrom.TabIndex = 3;
            sndFrom.Text = "Select account";
            // 
            // sndTo
            // 
            sndTo.FormattingEnabled = true;
            sndTo.Items.AddRange(new object[] { "Checkings", "Savings" });
            sndTo.Location = new Point(184, 73);
            sndTo.Name = "sndTo";
            sndTo.Size = new Size(151, 28);
            sndTo.TabIndex = 4;
            sndTo.Text = "Select account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 110);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 5;
            label4.Text = "Transfer amount: ";
            // 
            // FndTxt
            // 
            FndTxt.Location = new Point(184, 107);
            FndTxt.Name = "FndTxt";
            FndTxt.Size = new Size(125, 27);
            FndTxt.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(StatusMessage);
            groupBox1.Controls.Add(TransferFunc);
            groupBox1.Controls.Add(sndFrom);
            groupBox1.Controls.Add(FndTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(sndTo);
            groupBox1.Location = new Point(21, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 261);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transfer Section";
            // 
            // StatusMessage
            // 
            StatusMessage.AutoSize = true;
            StatusMessage.ForeColor = Color.Red;
            StatusMessage.Location = new Point(118, 201);
            StatusMessage.Name = "StatusMessage";
            StatusMessage.Size = new Size(105, 20);
            StatusMessage.TabIndex = 9;
            StatusMessage.Text = "Transfer Status";
            // 
            // TransferFunc
            // 
            TransferFunc.Location = new Point(99, 152);
            TransferFunc.Name = "TransferFunc";
            TransferFunc.Size = new Size(155, 46);
            TransferFunc.TabIndex = 8;
            TransferFunc.Text = "Transfer Funds";
            TransferFunc.UseVisualStyleBackColor = true;
            TransferFunc.Click += TransferFunc_Click;
            // 
            // DepositStatus
            // 
            DepositStatus.AutoSize = true;
            DepositStatus.ForeColor = Color.Red;
            DepositStatus.Location = new Point(18, 59);
            DepositStatus.Name = "DepositStatus";
            DepositStatus.Size = new Size(151, 20);
            DepositStatus.TabIndex = 10;
            DepositStatus.Text = "Successful Deposits: -";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(131, 35);
            button1.TabIndex = 8;
            button1.Text = "Back to Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DepositStatus);
            groupBox2.Location = new Point(403, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Savings Deposit section";
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 348);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TransferForm";
            Text = "TransferForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox sndFrom;
        private ComboBox sndTo;
        private Label label4;
        private TextBox FndTxt;
        private GroupBox groupBox1;
        private Button TransferFunc;
        private Button button1;
        private Label StatusMessage;
        private Label DepositStatus;
        private GroupBox groupBox2;
    }
}