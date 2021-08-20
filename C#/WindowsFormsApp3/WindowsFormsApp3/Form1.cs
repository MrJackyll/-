using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_add.Checked = true;
            comboBox1.SelectedItem = "DEC";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_div.Checked == true) label_symbol.Text = "/";
            progressBar1.Value = 4;
            стираниеРезультата();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) numericUpDown1.Enabled = true;
            else numericUpDown1.Enabled = false;

        }

        private void label_symbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_add_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton_add.Checked == true) label_symbol.Text = "+";
            progressBar1.Value = 1;
            стираниеРезультата();

        }

        private void radioButton_sub_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_sub.Checked == true) label_symbol.Text = "-";
            progressBar1.Value = 2;
            стираниеРезультата();

        }

        private void radioButton_mult_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_mult.Checked == true) label_symbol.Text = "*";
            progressBar1.Value = 3;
            стираниеРезультата();

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) label_symbol.Text = "sqrt";
            progressBar1.Value = 4;
            стираниеРезультата();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) label_symbol.Text = "sub";
            progressBar1.Value = 4;
            стираниеРезультата();
        }

        private void button_Розрахунок_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";

            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Double.Parse(textBox2.Text);
            string symbol = label_symbol.Text;
            double y;
            switch (symbol)
            {
                case "+":
                    y = x1 + x2;
                    break;
                case "-":
                    y = x1 - x2;
                    break;
                case "*":
                    y = x1 * x2;
                    break;
                case "/":
                    y = x1 / x2;
                    break;
                case "sqrt":
                    y = Math.Pow(x1, 1 / x2);
                    break;


                default:
                    y = 0;
                    break;

            }
            int precision = (int)numericUpDown1.Value;
            y = Math.Round(y, precision);

            symbol = Convert.ToString(comboBox1.SelectedItem);
            string result;
            switch (symbol)
            {
                case "HEX":
                    result = Convert.ToString((int)y, 16);
                    result = result.ToUpper();
                    break;
                case "DEC":
                    result = Convert.ToString(y);
                    break;
                case "OCT":
                    result = Convert.ToString((int)y, 8);
                    break;
                case "BIN":
                    result = Convert.ToString((int)y, 2);
                    break;
                default:
                    MessageBox.Show("Така система числення не запрограмована", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_result.Text = "???";
                    return;
                    //break;
            }

            textBox_result.Text = result;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            //{
            //    //{

            //    //    e.Handled = true;
            //    //}
            //    // textBox1.Text.Length -1
            //    // char s = ;
            //    if (!char.IsDigit(e.KeyChar))
            //        if (textBox1.Text.IndexOf(",") != -1)
            //            if (e.KeyChar == ',')
            //                e.Handled = true;
            //}
            if (!char.IsDigit(e.KeyChar) && textBox1.Text.IndexOf(",") != -1 || (e.KeyChar == ','))
                e.Handled = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();    //Clear if any old value is there in Clipboard        
            Clipboard.SetText(textBox_result.Text); //Copy text to Clipboard
            string strClip = Clipboard.GetText(); //Get text from Clipboard
            MessageBox.Show("Результат \n" + strClip + "\n скопійовано \n\n тепер можете нажати Ctrl+V \n і вставити текст кудись", "Копія у буфер обміну", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            //textBox.SelectAll();
            (sender as TextBox).SelectAll();
        }

        private void стираниеРезультата()
        {
            textBox_result.Text = "???";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.Clear();    //Clear if any old value is there in Clipboard        
            Clipboard.SetText(textBox_result.Text); //Copy text to Clipboard
            string strClip = Clipboard.GetText(); //Get text from Clipboard

            MessageBox.Show("Результат \n" + strClip + "\n скопійовано \n\n тепер можете нажати Ctrl+V \n і вставити текст кудись", "Копія у буфер обміну", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //if (!char.IsControl(e.) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar/*, textBox1.Text.Length - 1*/))
                if (textBox1.Text.IndexOf(",") != -1)
                    if (e.KeyChar == ',') e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar/*, textBox1.Text.Length - 1*/))
                if (textBox2.Text.IndexOf(",") != -1)
                    if (e.KeyChar == ',') e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
