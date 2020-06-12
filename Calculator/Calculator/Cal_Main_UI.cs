using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public void Num_Btn_Click(object sender, EventArgs e)
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

        public void Operator_Btn_Click(object sender ,EventArgs e)
        {
            Button btn = sender as Button;
            Value = Double.Parse(label_result.Text);
            Operator = char.Parse(btn.Text);
            label_mem.Text = label_result.Text + btn.Text;
            label_result.Text = "0";
            button_equal.Enabled = true;
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

        private void Equal_Btn_Click(object sender, EventArgs e)
        {
            switch (Operator)
            {
                case '+':
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value + Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    break;
                case '-':
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value - Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    break;
                case '×':
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value * Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    break;
                case '÷':
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value / Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("호서대학교 20191220 이재원 \nC# 프로그래밍 \n\nBuild : 23");
        }
    }
}
