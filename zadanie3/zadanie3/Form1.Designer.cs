namespace zadanie3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nameOfChainTextBox = new System.Windows.Forms.TextBox();
            this.countOfSalesTextBox = new System.Windows.Forms.TextBox();
            this.monthlyRevenueTextBox = new System.Windows.Forms.TextBox();
            this.ownerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addNewChainButton = new System.Windows.Forms.Button();
            this.chainsOfMarketsComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addNewChainButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ownerSurnameTextBox);
            this.tabPage1.Controls.Add(this.monthlyRevenueTextBox);
            this.tabPage1.Controls.Add(this.countOfSalesTextBox);
            this.tabPage1.Controls.Add(this.nameOfChainTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить сеть магазинов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chainsOfMarketsComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить магазин в сеть и просмотр информации";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nameOfChainTextBox
            // 
            this.nameOfChainTextBox.Location = new System.Drawing.Point(342, 86);
            this.nameOfChainTextBox.Name = "nameOfChainTextBox";
            this.nameOfChainTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameOfChainTextBox.TabIndex = 0;
            // 
            // countOfSalesTextBox
            // 
            this.countOfSalesTextBox.Location = new System.Drawing.Point(342, 134);
            this.countOfSalesTextBox.Name = "countOfSalesTextBox";
            this.countOfSalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.countOfSalesTextBox.TabIndex = 1;
            // 
            // monthlyRevenueTextBox
            // 
            this.monthlyRevenueTextBox.Location = new System.Drawing.Point(342, 172);
            this.monthlyRevenueTextBox.Name = "monthlyRevenueTextBox";
            this.monthlyRevenueTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyRevenueTextBox.TabIndex = 2;
            // 
            // ownerSurnameTextBox
            // 
            this.ownerSurnameTextBox.Location = new System.Drawing.Point(342, 212);
            this.ownerSurnameTextBox.Name = "ownerSurnameTextBox";
            this.ownerSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerSurnameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название сети";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество продаж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выручка за месяц";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Фамилия владелца сети";
            // 
            // addNewChainButton
            // 
            this.addNewChainButton.Location = new System.Drawing.Point(343, 238);
            this.addNewChainButton.Name = "addNewChainButton";
            this.addNewChainButton.Size = new System.Drawing.Size(105, 39);
            this.addNewChainButton.TabIndex = 8;
            this.addNewChainButton.Text = "Добавить новую сеть";
            this.addNewChainButton.UseVisualStyleBackColor = true;
            this.addNewChainButton.Click += new System.EventHandler(this.addNewChainButton_Click);
            // 
            // chainsOfMarketsComboBox
            // 
            this.chainsOfMarketsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chainsOfMarketsComboBox.FormattingEnabled = true;
            this.chainsOfMarketsComboBox.Location = new System.Drawing.Point(289, 27);
            this.chainsOfMarketsComboBox.Name = "chainsOfMarketsComboBox";
            this.chainsOfMarketsComboBox.Size = new System.Drawing.Size(121, 21);
            this.chainsOfMarketsComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ownerSurnameTextBox;
        private System.Windows.Forms.TextBox monthlyRevenueTextBox;
        private System.Windows.Forms.TextBox countOfSalesTextBox;
        private System.Windows.Forms.TextBox nameOfChainTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewChainButton;
        private System.Windows.Forms.ComboBox chainsOfMarketsComboBox;
    }
}

