using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Cal_Main_UI : Form
    {

        //통합 숫자 입력 처리
        private void Num_Work(string number)
        {
            button_erase.Enabled = true;
            Msg_Box.Text = "";
            if (newBut == false)
            {
                button_equal.Enabled = true;
            }
            if (label_result.Text == "0" || newBut == true)
            {
                label_result.Text = number;
                newBut = false;
            }
            else
                label_result.Text = label_result.Text + number;

            Check_Calculation_availability();
        }

        //통합 연산자 입력 처리
        private void Operator_Work()
        {
            Value = Double.Parse(label_result.Text);
            label_mem.Text = Value.ToString() + Operator;
            //label_result.Text = "0";
            newBut = true;
            button_equal.Enabled = true;
            Check_Calculation_availability();
        }

        //C (Clear)버튼 처리
        public void All_Clear_Work()
        {
            label_result.Text = "0";
            label_mem.Text = "";
            newBut = true;
            button_erase.Enabled = false;
            Msg_Box.Text = "";
        }

        //백스페이스 처리
        public void Erase_Work()
        {
            label_result.Text = label_result.Text.Remove(label_result.Text.Length - 1);
            if (label_result.Text.Length == 0)
            {
                label_result.Text = "0";
                button_erase.Enabled = false;
            }
            else
                button_erase.Enabled = true;

            Check_Calculation_availability();
        }

        public void CE_Work()
        {
            label_result.Text = "0";
            button_erase.Enabled = false;
            newBut = true;
            Msg_Box.Text = "";
        }

        public void Swap_Work()
        {
            if (!label_result.Text.Contains("-"))               //해당 문자열에 -가 존재하지 않으면,
            {
                label_result.Text = "-" + label_result.Text; //문자열 앞에 -부호 추가 
            }

            else if (label_result.Text.Contains("-"))         //해당 문자열에 1가 존재하면,
            {
                label_result.Text = label_result.Text.Substring(1); //문자열의 1번째 자리부터 자름, 즉 -부호를 자름.    
            }
        }

        public void Period_Work()
        {
            if (label_result.Text.Contains(".")) //해당 문자열에 .이 존재하면,
            {
                Msg_Box.Text = "이미 . 이 존재합니다.";
            }
            else if (!label_result.Text.Contains(".")) //해당 문자열에 .가 존재하지 않으면,
            {
                label_result.Text += "."; //문자열 맨뒤에 .부호 추가 
            }
        }

        public void Equal_Work()
        {
            switch (Operator)
            {
                case "+":
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value + Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    newBut = true;
                    break;
                case "-":
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value - Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    newBut = true;
                    break;
                case "×":
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value * Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    newBut = true;
                    break;
                case "÷":
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value / Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    newBut = true;
                    break;
                default:
                    break;
            }
        }

        // 프로그램 정보 및 빌드번호
        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("호서대학교 20191220 이재원 \nC# 프로그래밍 \n\nBuild : 5");
        }
        // 도움말
        private void 키보드입력도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number = Numpad\nOperator = Operator\nBackspace = Backspace\nC = ESC\nCE = Del\nSwap +/ - = F9\nDecimal = .\nEqual = Enter\nMC = Ctrl + L\nMR = Ctrl + R\nM + = Crtl + P\nM - = Ctrl + Q\nMS = Ctrl + M");
        }
    }
}
