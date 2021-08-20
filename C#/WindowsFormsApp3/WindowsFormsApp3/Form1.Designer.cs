namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_Розрахунок = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButton_div = new System.Windows.Forms.RadioButton();
            this.radioButton_mult = new System.Windows.Forms.RadioButton();
            this.radioButton_sub = new System.Windows.Forms.RadioButton();
            this.radioButton_add = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_symbol = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button_Розрахунок);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.radioButton_div);
            this.groupBox1.Controls.Add(this.radioButton_mult);
            this.groupBox1.Controls.Add(this.radioButton_sub);
            this.groupBox1.Controls.Add(this.radioButton_add);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_symbol);
            this.groupBox1.Controls.Add(this.textBox_result);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Розрахунки";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.Location = new System.Drawing.Point(184, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 36);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sqrt";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(397, 209);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 26);
            this.numericUpDown1.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(165, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(233, 23);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "округляти до знаків після коми";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_Розрахунок
            // 
            this.button_Розрахунок.Location = new System.Drawing.Point(33, 197);
            this.button_Розрахунок.Name = "button_Розрахунок";
            this.button_Розрахунок.Size = new System.Drawing.Size(100, 38);
            this.button_Розрахунок.TabIndex = 13;
            this.button_Розрахунок.Text = "Пуск";
            this.button_Розрахунок.UseVisualStyleBackColor = true;
            this.button_Розрахунок.Click += new System.EventHandler(this.button_Розрахунок_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HEX",
            "DEC",
            "OCT",
            "BIN",
            "???"});
            this.comboBox1.Location = new System.Drawing.Point(363, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 27);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.textBox2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 136);
            this.progressBar1.Maximum = 4;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(168, 32);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // radioButton_div
            // 
            this.radioButton_div.AutoSize = true;
            this.radioButton_div.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_div.Location = new System.Drawing.Point(151, 94);
            this.radioButton_div.Name = "radioButton_div";
            this.radioButton_div.Size = new System.Drawing.Size(17, 36);
            this.radioButton_div.TabIndex = 10;
            this.radioButton_div.Text = "/";
            this.radioButton_div.UseVisualStyleBackColor = true;
            this.radioButton_div.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton_mult
            // 
            this.radioButton_mult.AutoSize = true;
            this.radioButton_mult.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_mult.Location = new System.Drawing.Point(112, 94);
            this.radioButton_mult.Name = "radioButton_mult";
            this.radioButton_mult.Size = new System.Drawing.Size(21, 36);
            this.radioButton_mult.TabIndex = 9;
            this.radioButton_mult.Text = "*";
            this.radioButton_mult.UseVisualStyleBackColor = true;
            this.radioButton_mult.CheckedChanged += new System.EventHandler(this.radioButton_mult_CheckedChanged);
            // 
            // radioButton_sub
            // 
            this.radioButton_sub.AutoSize = true;
            this.radioButton_sub.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_sub.Location = new System.Drawing.Point(72, 94);
            this.radioButton_sub.Name = "radioButton_sub";
            this.radioButton_sub.Size = new System.Drawing.Size(19, 36);
            this.radioButton_sub.TabIndex = 8;
            this.radioButton_sub.Text = "-";
            this.radioButton_sub.UseVisualStyleBackColor = true;
            this.radioButton_sub.CheckedChanged += new System.EventHandler(this.radioButton_sub_CheckedChanged);
            // 
            // radioButton_add
            // 
            this.radioButton_add.AutoSize = true;
            this.radioButton_add.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_add.Location = new System.Drawing.Point(33, 94);
            this.radioButton_add.Name = "radioButton_add";
            this.radioButton_add.Size = new System.Drawing.Size(22, 36);
            this.radioButton_add.TabIndex = 7;
            this.radioButton_add.Text = "+";
            this.radioButton_add.UseVisualStyleBackColor = true;
            this.radioButton_add.CheckedChanged += new System.EventHandler(this.radioButton_add_CheckedChanged);
            this.radioButton_add.TextChanged += new System.EventHandler(this.radioButton_add_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(371, 177);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 19);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "копіювати";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Система числення";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // label_symbol
            // 
            this.label_symbol.AutoSize = true;
            this.label_symbol.Location = new System.Drawing.Point(152, 64);
            this.label_symbol.Name = "label_symbol";
            this.label_symbol.Size = new System.Drawing.Size(16, 19);
            this.label_symbol.TabIndex = 3;
            this.label_symbol.Text = "?";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(337, 57);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(100, 26);
            this.textBox_result.TabIndex = 2;
            this.textBox_result.Text = "???";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 322);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаба 1 - Windows Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_div;
        private System.Windows.Forms.RadioButton radioButton_mult;
        private System.Windows.Forms.RadioButton radioButton_sub;
        private System.Windows.Forms.RadioButton radioButton_add;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_symbol;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_Розрахунок;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

