namespace BigBucksBank
{
    partial class actionForm
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
            this.nextButton = new System.Windows.Forms.Button();
            this.depositRado = new System.Windows.Forms.RadioButton();
            this.withdrawRadio = new System.Windows.Forms.RadioButton();
            this.balanceRadio = new System.Windows.Forms.RadioButton();
            this.transferRadio = new System.Windows.Forms.RadioButton();
            this.exitRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Big Bucks Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an Action";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(12, 194);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(110, 27);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // depositRado
            // 
            this.depositRado.AutoSize = true;
            this.depositRado.Location = new System.Drawing.Point(64, 61);
            this.depositRado.Name = "depositRado";
            this.depositRado.Size = new System.Drawing.Size(100, 17);
            this.depositRado.TabIndex = 1;
            this.depositRado.TabStop = true;
            this.depositRado.Text = "Make a Deposit";
            this.depositRado.UseVisualStyleBackColor = true;
            this.depositRado.CheckedChanged += new System.EventHandler(this.depositRadio_CheckedChanged);
            // 
            // withdrawRadio
            // 
            this.withdrawRadio.AutoSize = true;
            this.withdrawRadio.Location = new System.Drawing.Point(64, 84);
            this.withdrawRadio.Name = "withdrawRadio";
            this.withdrawRadio.Size = new System.Drawing.Size(117, 17);
            this.withdrawRadio.TabIndex = 2;
            this.withdrawRadio.TabStop = true;
            this.withdrawRadio.Text = "Make a Withdrawal";
            this.withdrawRadio.UseVisualStyleBackColor = true;
            this.withdrawRadio.CheckedChanged += new System.EventHandler(this.withdrawRadio_CheckedChanged);
            // 
            // balanceRadio
            // 
            this.balanceRadio.AutoSize = true;
            this.balanceRadio.Location = new System.Drawing.Point(64, 130);
            this.balanceRadio.Name = "balanceRadio";
            this.balanceRadio.Size = new System.Drawing.Size(98, 17);
            this.balanceRadio.TabIndex = 3;
            this.balanceRadio.TabStop = true;
            this.balanceRadio.Text = "Check Balance";
            this.balanceRadio.UseVisualStyleBackColor = true;
            this.balanceRadio.CheckedChanged += new System.EventHandler(this.balanceRadio_CheckedChanged);
            // 
            // transferRadio
            // 
            this.transferRadio.AutoSize = true;
            this.transferRadio.Location = new System.Drawing.Point(64, 107);
            this.transferRadio.Name = "transferRadio";
            this.transferRadio.Size = new System.Drawing.Size(96, 17);
            this.transferRadio.TabIndex = 4;
            this.transferRadio.TabStop = true;
            this.transferRadio.Text = "Transfer Funds";
            this.transferRadio.UseVisualStyleBackColor = true;
            this.transferRadio.CheckedChanged += new System.EventHandler(this.transferRadio_CheckedChanged);
            // 
            // exitRadioButton
            // 
            this.exitRadioButton.AutoSize = true;
            this.exitRadioButton.Location = new System.Drawing.Point(64, 153);
            this.exitRadioButton.Name = "exitRadioButton";
            this.exitRadioButton.Size = new System.Drawing.Size(42, 17);
            this.exitRadioButton.TabIndex = 5;
            this.exitRadioButton.TabStop = true;
            this.exitRadioButton.Text = "Exit";
            this.exitRadioButton.UseVisualStyleBackColor = true;
            this.exitRadioButton.CheckedChanged += new System.EventHandler(this.exitRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(128, 194);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 27);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // actionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(246, 233);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exitRadioButton);
            this.Controls.Add(this.transferRadio);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.balanceRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.withdrawRadio);
            this.Controls.Add(this.depositRado);
            this.Controls.Add(this.label1);
            this.Name = "actionForm";
            this.Text = "Action Form";
            this.Load += new System.EventHandler(this.actionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RadioButton depositRado;
        private System.Windows.Forms.RadioButton withdrawRadio;
        private System.Windows.Forms.RadioButton balanceRadio;
        private System.Windows.Forms.RadioButton transferRadio;
        private System.Windows.Forms.RadioButton exitRadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}