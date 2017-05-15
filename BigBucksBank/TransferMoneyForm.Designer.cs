namespace BigBucksBank
{
    partial class TransferMoneyForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fromSavingsRadio = new System.Windows.Forms.RadioButton();
            this.fromCheckingRadio = new System.Windows.Forms.RadioButton();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.transferTextBox = new System.Windows.Forms.TextBox();
            this.toCheckingRadio = new System.Windows.Forms.RadioButton();
            this.toSavingsRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Big Bucks Bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Transfer Money";
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(36, 331);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(106, 20);
            this.transferButton.TabIndex = 7;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(148, 331);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(106, 20);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fromSavingsRadio
            // 
            this.fromSavingsRadio.AutoSize = true;
            this.fromSavingsRadio.Location = new System.Drawing.Point(134, 101);
            this.fromSavingsRadio.Name = "fromSavingsRadio";
            this.fromSavingsRadio.Size = new System.Drawing.Size(63, 17);
            this.fromSavingsRadio.TabIndex = 14;
            this.fromSavingsRadio.TabStop = true;
            this.fromSavingsRadio.Text = "Savings";
            this.fromSavingsRadio.UseVisualStyleBackColor = true;
            // 
            // fromCheckingRadio
            // 
            this.fromCheckingRadio.AutoSize = true;
            this.fromCheckingRadio.Location = new System.Drawing.Point(16, 101);
            this.fromCheckingRadio.Name = "fromCheckingRadio";
            this.fromCheckingRadio.Size = new System.Drawing.Size(70, 17);
            this.fromCheckingRadio.TabIndex = 13;
            this.fromCheckingRadio.TabStop = true;
            this.fromCheckingRadio.Text = "Checking";
            this.fromCheckingRadio.UseVisualStyleBackColor = true;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(16, 221);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(255, 104);
            this.rtbMessage.TabIndex = 28;
            this.rtbMessage.Text = "";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(9, 191);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 27;
            this.amountLabel.Text = "Amount:";
            // 
            // transferTextBox
            // 
            this.transferTextBox.Location = new System.Drawing.Point(61, 184);
            this.transferTextBox.Name = "transferTextBox";
            this.transferTextBox.Size = new System.Drawing.Size(192, 20);
            this.transferTextBox.TabIndex = 26;
            // 
            // toCheckingRadio
            // 
            this.toCheckingRadio.AutoSize = true;
            this.toCheckingRadio.Location = new System.Drawing.Point(16, 142);
            this.toCheckingRadio.Name = "toCheckingRadio";
            this.toCheckingRadio.Size = new System.Drawing.Size(70, 17);
            this.toCheckingRadio.TabIndex = 13;
            this.toCheckingRadio.TabStop = true;
            this.toCheckingRadio.Text = "Checking";
            this.toCheckingRadio.UseVisualStyleBackColor = true;
            // 
            // toSavingsRadio
            // 
            this.toSavingsRadio.AutoSize = true;
            this.toSavingsRadio.Location = new System.Drawing.Point(134, 144);
            this.toSavingsRadio.Name = "toSavingsRadio";
            this.toSavingsRadio.Size = new System.Drawing.Size(63, 17);
            this.toSavingsRadio.TabIndex = 14;
            this.toSavingsRadio.TabStop = true;
            this.toSavingsRadio.Text = "Savings";
            this.toSavingsRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "To";
            // 
            // TransferMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(279, 360);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toSavingsRadio);
            this.Controls.Add(this.fromSavingsRadio);
            this.Controls.Add(this.toCheckingRadio);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.fromCheckingRadio);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.transferTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "TransferMoneyForm";
            this.Text = "Transfer Money";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton fromSavingsRadio;
        private System.Windows.Forms.RadioButton fromCheckingRadio;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox transferTextBox;
        private System.Windows.Forms.RadioButton toCheckingRadio;
        private System.Windows.Forms.RadioButton toSavingsRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}