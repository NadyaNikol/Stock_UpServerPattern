namespace WindowsFormsApp3
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textboxCourceForSell = new System.Windows.Forms.TextBox();
            this.textBoxSummForSell = new System.Windows.Forms.TextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.textboxCourceForBuy = new System.Windows.Forms.TextBox();
            this.textBoxSummForBuy = new System.Windows.Forms.TextBox();
            this.textBoxBTC = new System.Windows.Forms.TextBox();
            this.labelNAme = new System.Windows.Forms.Label();
            this.labelCourceForSell = new System.Windows.Forms.Label();
            this.labelSummForBuy = new System.Windows.Forms.Label();
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelCourceForBuy = new System.Windows.Forms.Label();
            this.labelSummForSell = new System.Windows.Forms.Label();
            this.labelBTC = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCourceBTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(22, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textboxCourceForSell
            // 
            this.textboxCourceForSell.Location = new System.Drawing.Point(25, 228);
            this.textboxCourceForSell.Name = "textboxCourceForSell";
            this.textboxCourceForSell.Size = new System.Drawing.Size(121, 20);
            this.textboxCourceForSell.TabIndex = 2;
            // 
            // textBoxSummForSell
            // 
            this.textBoxSummForSell.Location = new System.Drawing.Point(244, 228);
            this.textBoxSummForSell.Name = "textBoxSummForSell";
            this.textBoxSummForSell.Size = new System.Drawing.Size(121, 20);
            this.textBoxSummForSell.TabIndex = 3;
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Location = new System.Drawing.Point(432, 96);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(121, 20);
            this.textBoxUSD.TabIndex = 4;
            // 
            // textboxCourceForBuy
            // 
            this.textboxCourceForBuy.Location = new System.Drawing.Point(22, 159);
            this.textboxCourceForBuy.Name = "textboxCourceForBuy";
            this.textboxCourceForBuy.Size = new System.Drawing.Size(121, 20);
            this.textboxCourceForBuy.TabIndex = 5;
            // 
            // textBoxSummForBuy
            // 
            this.textBoxSummForBuy.Location = new System.Drawing.Point(244, 159);
            this.textBoxSummForBuy.Name = "textBoxSummForBuy";
            this.textBoxSummForBuy.Size = new System.Drawing.Size(121, 20);
            this.textBoxSummForBuy.TabIndex = 6;
            // 
            // textBoxBTC
            // 
            this.textBoxBTC.Location = new System.Drawing.Point(244, 96);
            this.textBoxBTC.Name = "textBoxBTC";
            this.textBoxBTC.Size = new System.Drawing.Size(121, 20);
            this.textBoxBTC.TabIndex = 7;
            // 
            // labelNAme
            // 
            this.labelNAme.AutoSize = true;
            this.labelNAme.BackColor = System.Drawing.Color.Transparent;
            this.labelNAme.Location = new System.Drawing.Point(22, 77);
            this.labelNAme.Name = "labelNAme";
            this.labelNAme.Size = new System.Drawing.Size(35, 13);
            this.labelNAme.TabIndex = 8;
            this.labelNAme.Text = "Name";
            // 
            // labelCourceForSell
            // 
            this.labelCourceForSell.AutoSize = true;
            this.labelCourceForSell.Location = new System.Drawing.Point(25, 212);
            this.labelCourceForSell.Name = "labelCourceForSell";
            this.labelCourceForSell.Size = new System.Drawing.Size(99, 13);
            this.labelCourceForSell.TabIndex = 9;
            this.labelCourceForSell.Text = "Курс для продажи";
            // 
            // labelSummForBuy
            // 
            this.labelSummForBuy.AutoSize = true;
            this.labelSummForBuy.Location = new System.Drawing.Point(241, 143);
            this.labelSummForBuy.Name = "labelSummForBuy";
            this.labelSummForBuy.Size = new System.Drawing.Size(106, 13);
            this.labelSummForBuy.TabIndex = 10;
            this.labelSummForBuy.Text = "Сумма для покупки";
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(429, 80);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(30, 13);
            this.labelUSD.TabIndex = 11;
            this.labelUSD.Text = "USD";
            // 
            // labelCourceForBuy
            // 
            this.labelCourceForBuy.AutoSize = true;
            this.labelCourceForBuy.Location = new System.Drawing.Point(19, 143);
            this.labelCourceForBuy.Name = "labelCourceForBuy";
            this.labelCourceForBuy.Size = new System.Drawing.Size(96, 13);
            this.labelCourceForBuy.TabIndex = 12;
            this.labelCourceForBuy.Text = "Курс для покупки";
            // 
            // labelSummForSell
            // 
            this.labelSummForSell.AutoSize = true;
            this.labelSummForSell.Location = new System.Drawing.Point(244, 212);
            this.labelSummForSell.Name = "labelSummForSell";
            this.labelSummForSell.Size = new System.Drawing.Size(109, 13);
            this.labelSummForSell.TabIndex = 13;
            this.labelSummForSell.Text = "Сумма для продажи";
            // 
            // labelBTC
            // 
            this.labelBTC.AllowDrop = true;
            this.labelBTC.AutoSize = true;
            this.labelBTC.Location = new System.Drawing.Point(241, 77);
            this.labelBTC.Name = "labelBTC";
            this.labelBTC.Size = new System.Drawing.Size(28, 13);
            this.labelBTC.TabIndex = 14;
            this.labelBTC.Text = "BTC";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(247, 33);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCourceBTC
            // 
            this.labelCourceBTC.AutoSize = true;
            this.labelCourceBTC.Location = new System.Drawing.Point(446, 182);
            this.labelCourceBTC.Name = "labelCourceBTC";
            this.labelCourceBTC.Size = new System.Drawing.Size(13, 13);
            this.labelCourceBTC.TabIndex = 16;
            this.labelCourceBTC.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Текущий курс биткоина";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(349, 33);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCourceBTC);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelBTC);
            this.Controls.Add(this.labelSummForSell);
            this.Controls.Add(this.labelCourceForBuy);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.labelSummForBuy);
            this.Controls.Add(this.labelCourceForSell);
            this.Controls.Add(this.labelNAme);
            this.Controls.Add(this.textBoxBTC);
            this.Controls.Add(this.textBoxSummForBuy);
            this.Controls.Add(this.textboxCourceForBuy);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.textBoxSummForSell);
            this.Controls.Add(this.textboxCourceForSell);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textboxCourceForSell;
        private System.Windows.Forms.TextBox textBoxSummForSell;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.TextBox textboxCourceForBuy;
        private System.Windows.Forms.TextBox textBoxSummForBuy;
        private System.Windows.Forms.TextBox textBoxBTC;
        private System.Windows.Forms.Label labelNAme;
        private System.Windows.Forms.Label labelCourceForSell;
        private System.Windows.Forms.Label labelSummForBuy;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.Label labelCourceForBuy;
        private System.Windows.Forms.Label labelSummForSell;
        private System.Windows.Forms.Label labelBTC;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCourceBTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEdit;
    }
}

