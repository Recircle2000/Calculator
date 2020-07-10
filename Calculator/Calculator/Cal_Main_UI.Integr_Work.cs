using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Cal_Main_UI : Form
    {
        private double Value; //첫번째로 입력한 값 또는 결과창에있는 값을 기억합니다.
        private double Next_Value; //두번째로 입력한값을 기억합니다. , 연속되지 않은 계산에만 사용됩니다.
        private double Memory; //메모리 기억
        private bool newBut; //입력을 새로 받을지 여부를 판단하는 플래그입니다.
        private string Operator; //가장 최근 입력한 연산자를 기억합니다.
        private string Operator_Old;//그 전에 입력된 연산자를 기억합니다.

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
            //수식창에 연산자가 있는지 여부를 판단하고 숫자 입력이 끝났다고 판단하면, 
            if ((label_mem.Text.Contains("-") || label_mem.Text.Contains("+") || label_mem.Text.Contains("×") || label_mem.Text.Contains("÷")) && newBut == false)
            {
                Equal_Work(Operator_Old);// 수식창에있던 연산자(그 전에 입력한 연산자)를 이용하여 재연산 한 뒤, 코드 마저 실행
                //숫자 - 연산자 - 숫자 - 연산자 와같이 연속된 계산 가능.
            }
            Value = Double.Parse(label_result.Text); //입력한 값을 임시저장.
            label_mem.Text = Value.ToString() + Operator; //입력한 연산자를 수식창에 출력.
            //label_result.Text = "0";
            newBut = true; //이제 숫자를 새로 받아야함.
            button_equal.Enabled = true; //이제 연산이 가능.
            Check_Calculation_availability();//예외 검사
        }

        public void Equal_Work(string Operator)
        {

            switch (Operator)
            {
                case "+":
                    if (Check_Equal())
                    {
                        //연속 계산(=연타)
                        Operator_Work();//1. 수식창에 =기호가 있으면, 현재 결과창에있는 값을 기억하고 연산자입력을 재처리하기위해 함수돌림.
                        label_mem.Text = Value + Operator + Next_Value + "="; // 2. 다시 기억한 Value값과 두번째로 입력했던 값을 재처리하여 표시.
                        label_result.Text = (Value + Next_Value).ToString(); //실제 연산 후, 결과값에 결과만 표기
                    }
                    else
                    {
                        //비연속 계산(최초 계산)
                        Next_Value = Double.Parse(label_result.Text);  //두번째로 입력했던 값을 저장.(=입력이 연속해서 들어왔을때 처리할때만 사용.)
                        label_mem.Text = label_mem.Text + label_result.Text + "="; // 수식창 처리 
                        label_result.Text = (Value + Double.Parse(label_result.Text)).ToString(); //결과값 출력
                    }
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
        }//수식창에 =기호가 있는경우는 전체초기화,
        //그외에는 결과창만 초기화해주고 새로운 입력을 받습니다.

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
            MessageBox.Show("호서대학교 20191220 이재원 \nC# 프로그래밍 \n\nBuild : 11");
        }
        // 도움말
        private void 키보드입력도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Keyboard_Help Help_ = new Keyboard_Help();
            Help_.Show();
        }
    }
}

