using System;
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
                if (Check_Equal())
                {
                    All_Clear_Work();
                }
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

        public void Equal_Work()
        {

            switch (Operator)
            {
                case "+":
                    if (Check_Equal())
                    {
                        Operator_Work();
                        label_mem.Text = label_result.Text + Operator + Next_Value + "=";
                        label_result.Text = (Value + Next_Value).ToString();
                    }
                    else
                    {
                        Next_Value = Double.Parse(label_result.Text);
                        label_mem.Text = label_mem.Text + label_result.Text + "=";
                        label_result.Text = (Value + Double.Parse(label_result.Text)).ToString();
                    }
                    //button_equal.Enabled = false;
                    newBut = true;
                    break;
                case "-":
                    if (Check_Equal())
                    {
                        Operator_Work();
                        label_mem.Text = label_result.Text + Operator + Next_Value + "=";
                        label_result.Text = (Value - Next_Value).ToString();
                    }
                    else
                    {
                        Next_Value = Double.Parse(label_result.Text);
                        label_mem.Text = label_mem.Text + label_result.Text + "=";
                        label_result.Text = (Value - Double.Parse(label_result.Text)).ToString();
                    }
                    newBut = true;
                    break;
                case "×":
                    if (Check_Equal())
                    {
                        Operator_Work();
                        label_mem.Text = label_result.Text + Operator + Next_Value + "=";
                        label_result.Text = (Value * Next_Value).ToString();
                    }
                    else
                    {
                        Next_Value = Double.Parse(label_result.Text);
                        label_mem.Text = label_mem.Text + label_result.Text + "=";
                        label_result.Text = (Value * Double.Parse(label_result.Text)).ToString();
                    }
                    newBut = true;
                    break;
                case "÷":
                    if (Check_Equal())
                    {
                        Operator_Work();
                        label_mem.Text = label_result.Text + Operator + Next_Value + "=";
                        label_result.Text = (Value / Next_Value).ToString();
                    }
                    else
                    {
                        Next_Value = Double.Parse(label_result.Text);
                        label_mem.Text = label_mem.Text + label_result.Text + "=";
                        label_result.Text = (Value / Double.Parse(label_result.Text)).ToString();
                    }
                    newBut = true;
                    break;
                default:
                    break;
            }
        }

        //%버튼 처리
        private void Percent_Work()
        {
            label_result.Text = (double.Parse(label_result.Text) / 100).ToString();
            
        }
        //C (Clear)버튼 처리
        public void All_Clear_Work()
        {
            label_result.Text = "0";
            label_mem.Text = "";
            newBut = true;
            button_erase.Enabled = false;
            // button_equal.Enabled = false;
            Msg_Box.Text = "";
            Value = 0;
            Next_Value = 0;
            Operator = "C";
        }
        //CE
        public void CE_Work()
        {
            if (Check_Equal())
            {
                All_Clear_Work();
            }
            else
            {
                label_result.Text = "0";
                button_erase.Enabled = false;
                newBut = true;
                Msg_Box.Text = "";
            }
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


        //음/양전환
        public void Swap_Work()
        {
            if (label_result.Text==0.ToString())
            {
                return;
            }
            else if (!label_result.Text.Contains("-"))               //해당 문자열에 -가 존재하지 않으면,
            {
                label_result.Text = "-" + label_result.Text; //문자열 앞에 -부호 추가 
            }

            else if (label_result.Text.Contains("-"))         //해당 문자열에 -가 존재하면,
            {
                label_result.Text = label_result.Text.Substring(1); //문자열의 1번째 자리부터 자름, 즉 -부호를 자름.    
            }
        }
        //소수점 추가
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



        //연산이 불가능한 예외가 있을경우 Equal버튼을 비활성화 하는 함수
        private void Check_Calculation_availability()
        {
            if (Operator == "÷" && label_result.Text == "0")
            {
                Msg_Box.Text = "0으로 나눌수 없습니다.";
                button_equal.Enabled = false;
            }
            else if (label_result.Text == "0" && label_mem.Text == "")
            {
                Msg_Box.Text = "수식을 입력해주세요.";
                button_equal.Enabled = false;
            }
        }

        //수식창의 맨 마지막 기호가 '='인지 여부 반환
        private bool Check_Equal()
        {
            if (label_mem.Text.Length == 0)
            {
                return false;
            }
            else if (label_mem.Text[label_mem.Text.Length - 1] == '=')
            {
                return true;
            }
            else return false;
        }

        //MS
        private void Memory_Save_Work()
        {
            Memory = double.Parse(label_result.Text);
            Display_Memory();
            newBut = true;
            Enable_Memory(true);
        }
        //MR
        private void Memory_Read_Work()
        {
            label_result.Text = Memory.ToString();
            newBut = true;
        }
        //M+
        private void Memory_Plus_Work()
        {
            Memory += double.Parse(label_result.Text);
            Display_Memory();
            newBut = true;
            Enable_Memory(true);
        }
        //M-
        private void Memory_Minus_Work()
        {
            Memory -= double.Parse(label_result.Text);
            Display_Memory();
            newBut = true;
            Enable_Memory(true);
        }
        //MC
        private void Memory_Clear_Work()
        {
            Memory = 0;
            Label_Memory.Text = "";
            Msg_Box.Text = "메모리 초기화 완료.";
            newBut = true;
            Enable_Memory(false);
        }
        //메모리 버튼 활성화/비활성화
        private void Enable_Memory(bool flag)
        {
            if (flag==true)
            {
                button_MC.Enabled = true;
                button_MR.Enabled = true;
            }
            else if (flag == false)
            {
                button_MC.Enabled = false;
                button_MR.Enabled = false;
            }
        }

        private void Display_Memory()
        {
            Label_Memory.Text = "메모리값 : " + Memory.ToString();
        }

        // 프로그램 정보 및 빌드번호
        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("호서대학교 20191220 이재원 \nC# 프로그래밍 \n\nBuild : 8");
        }
        // 도움말
        private void 키보드입력도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number = Numpad\nOperator = Operator\nBackspace = Backspace\nC = ESC\nCE = Del\nSwap +/ - = F9\nDecimal = .\nEqual = Enter\nMC = Ctrl + L\nMR = Ctrl + R\nM + = Crtl + P\nM - = Ctrl + Q\nMS = Ctrl + M");
        }
    }
}

