namespace BigBucksBank
{
    partial class DepositMoneyForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.savingsRadio = new System.Windows.Forms.RadioButton();
            this.checkingRadio = new System.Windows.Forms.RadioButton();
            this.recieptTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depositAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Big Bucks Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deposit Money";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(35, 306);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(105, 20);
            this.depositButton.TabIndex = 7;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(149, 306);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 20);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // savingsRadio
            // 
            this.savingsRadio.AutoSize = true;
            this.savingsRadio.Location = new System.Drawing.Point(153, 88);
            this.savingsRadio.Name = "savingsRadio";
            this.savingsRadio.Size = new System.Drawing.Size(63, 17);
            this.savingsRadio.TabIndex = 14;
            this.savingsRadio.TabStop = true;
            this.savingsRadio.Text = "Savings";
            this.savingsRadio.UseVisualStyleBackColor = true;
            this.savingsRadio.CheckedChanged += new System.EventHandler(this.rbSavings_CheckedChanged);
            // 
            // checkingRadio
            // 
            this.checkingRadio.AutoSize = true;
            this.checkingRadio.Location = new System.Drawing.Point(35, 88);
            this.checkingRadio.Name = "checkingRadio";
            this.checkingRadio.Size = new System.Drawing.Size(70, 17);
            this.checkingRadio.TabIndex = 13;
            this.checkingRadio.TabStop = true;
            this.checkingRadio.Text = "Checking";
            this.checkingRadio.UseVisualStyleBackColor = true;
            this.checkingRadio.CheckedChanged += new System.EventHandler(this.rbChecking_CheckedChanged);
            // 
            // recieptTextBox
            // 
            this.recieptTextBox.Location = new System.Drawing.Point(21, 177);
            this.recieptTextBox.Name = "recieptTextBox";
            this.recieptTextBox.Size = new System.Drawing.Size(241, 111);
            this.recieptTextBox.TabIndex = 19;
            this.recieptTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount:";
            // 
            // depositAmount
            // 
            this.depositAmount.Location = new System.Drawing.Point(70, 122);
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(192, 20);
            this.depositAmount.TabIndex = 17;
            // 
            // DepositMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(278, 341);
            this.ControlBox = false;
            this.Controls.Add(this.savingsRadio);
            this.Controls.Add(this.checkingRadio);
            this.Controls.Add(this.recieptTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depositAmount);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepositMoneyForm";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton savingsRadio;
        private System.Windows.Forms.RadioButton checkingRadio;
        private System.Windows.Forms.RichTextBox recieptTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox depositAmount;
    }
}