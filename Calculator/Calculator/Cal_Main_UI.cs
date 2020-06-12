using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Cal_Main_UI : Form
    {
        private double Value;
        private bool newBut;
        private char Operator;
        public Cal_Main_UI()
        {
            InitializeComponent();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            button_erase.Enabled = true;
            if (label_result.Text == "0" || newBut == true)
            {
                label_result.Text = number;
                newBut = false;
            }
            else
                label_result.Text = label_result.Text + number; 
        }

        public void All_Clear(object sender, EventArgs e)
        {
            label_result.Text = "0";
            label_mem.Text = "";
            newBut = true;
            button_erase.Enabled = false;

        }

        private void button_erase_Click(object sender, EventArgs e)
        {
            label_result.Text = label_result.Text.Remove(label_result.Text.Length - 1) ;
            if (label_result.Text.Length == 0)
            {
                label_result.Text = "0";
                button_erase.Enabled = false;
            }
            else
                button_erase.Enabled = true;
        }

        private void CE(object sender, EventArgs e)
        {
            label_result.Text = "0";
            button_erase.Enabled = false;
            newBut = true;
        }
    }
}
