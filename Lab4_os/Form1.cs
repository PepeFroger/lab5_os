using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace Lab4_os
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignLabel_Click(object sender, EventArgs e)
        {

        }

        private void EqSignLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstValTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondValTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void PlusButton_Click(object sender, EventArgs e)
        {
            SignLabel.Text = "+";
            if (FirstValTextBox.Text == "" || SecondValTextBox.Text == "")
            {
                ResLabel.Text = "Введите оба числа";
            }
            else
            {
                ResLabel.Text = Convert.ToString(MyLib.MyLib.Plus(Convert.ToDecimal(FirstValTextBox.Text), Convert.ToDecimal(SecondValTextBox.Text)));

            }


        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            SignLabel.Text = "-";
            if (FirstValTextBox.Text == "" || SecondValTextBox.Text == "")
            {
                ResLabel.Text = "Введите оба числа";
            }
            else
            {
                ResLabel.Text = Convert.ToString(MyLib.MyLib.Subtrackt(Convert.ToDecimal(FirstValTextBox.Text), Convert.ToDecimal(SecondValTextBox.Text)));

            }
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            SignLabel.Text = "*";
            if (FirstValTextBox.Text == "" || SecondValTextBox.Text == "")
            {
                ResLabel.Text = "Введите оба числа";
            }
            else
            {
                ResLabel.Text = Convert.ToString(MyLib.MyLib.Mult(Convert.ToDecimal(FirstValTextBox.Text), Convert.ToDecimal(SecondValTextBox.Text)));

            }
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            SignLabel.Text = "/";
            if (FirstValTextBox.Text == "" || SecondValTextBox.Text == "")
            {
                ResLabel.Text = "Введите оба числа";
            }
            else
            {
                ResLabel.Text = Convert.ToString(MyLib.MyLib.Divide(Convert.ToDecimal(FirstValTextBox.Text), Convert.ToDecimal(SecondValTextBox.Text)));
            }
            
        }
    }
}

