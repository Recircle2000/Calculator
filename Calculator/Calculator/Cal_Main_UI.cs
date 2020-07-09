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
        public Cal_Main_UI()
        {
            InitializeComponent();
            label_result.Text = "0";
            Memory = 0;
           
        }

        //각 숫자 키를 마우스로 입력했을때의 처리
        public void Num_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Button btn = sender as Button;
            Num_Work(btn.Text);

        }

        //각 연산자 키를 마우스로 입력했을 때의 처리
        public void Operator_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Button btn = sender as Button;
            Operator_Old = Operator;
            Operator = btn.Text;
            Operator_Work();
        }

        //Percent 버튼_마우스입력
        private void Percent_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Percent_Work();
        }

        //전체 초기화_마우스입력
        public void AllClear_btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            All_Clear_Work();
        }

        //백스페이스_마우스입력
        private void Button_Erase_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Erase_Work();
        }

        // 마지막 연산기호를 누른 뒤 입력한 숫자제거_마우스입력
        private void CE(object sender, EventArgs e)
        {
            button_equal.Focus();
            CE_Work();
        }

        //최종 연산 수행_마우스입력
        private void Equal_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Equal_Work(Operator);
        }

        //숫자의 음/양을 전환_마우스입력
        private void Swap_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Swap_Work();
        }

        //소수점을 추가_마우스입력
        private void Period_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Period_Work();
        }

        //MC_메모리에서 저장된 숫자를 지운다_마우스입력
        private void Memory_Clear_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Memory_Clear_Work();
        }

        //MR_메모리에 저장된 숫자를 화면에 출력_마우스입력
        private void Memory_Read_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Memory_Read_Work();
        }

        //M+_메모리에 저장된 숫자에 화면의 숫자를 더한다_마우스입력
        private void Memory_Plus_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Memory_Plus_Work();
        }

        //M-_메모리에 저장된 숫자에 화면의 숫자를 뺀다_마우스입력
        private void Memory_Minus_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Memory_Minus_Work();
        }

        //MS_메모리에 숫자를 저장한다_마우스입력
        private void Memory_Save_Btn_Click(object sender, EventArgs e)
        {
            button_equal.Focus();
            Memory_Save_Work();
        }



        //키보드 입력 통합 처리
        private void Num_KeyDown(object sender, KeyPressEventArgs e)
        {
            Msg_Box.Text = e.KeyChar.ToString();
            //숫자
            if (char.IsDigit(e.KeyChar))
            {
                button_equal.Focus();
                Num_Work(e.KeyChar.ToString());
            }
            //연산자
            else if (e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '-' || e.KeyChar == '+' || e.KeyChar == '%')
            {
                button_equal.Focus();
                if (e.KeyChar == '/')
                {
                    Operator_Old = Operator;
                    Operator = "÷";
                }
                else if (e.KeyChar=='*')
                {
                    Operator_Old = Operator;
                    Operator = "×";
                }
                else
                {
                    Operator_Old = Operator;
                    Operator = e.KeyChar.ToString();
                }
                Operator_Work();
            }
            //Backspace
            else if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                button_equal.Focus();
                Erase_Work();
            }
            //Clear
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                button_equal.Focus();
                All_Clear_Work();
            }
            else if (e.KeyChar == (char)13)
            {
                if (button_equal.Enabled == true)
                {
                    button_equal.Focus();
                    Equal_Work(Operator);
                }
            }
            
            
        }

        //일부 keydown이 필요한 경우 사용.
        private void Key_Down(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    button_equal.Focus();
                    CE_Work();
                    break;

                case Keys.F9:
                    button_equal.Focus();
                    Swap_Work();
                    break;

                case Keys.Decimal:
                    button_equal.Focus();
                    Period_Work(); 
                    break;

                default:
                    if (e.Control&&e.KeyCode==Keys.R)
                    {
                        button_equal.Focus();
                        Memory_Read_Work();
                    }
                    else if (e.Control && e.KeyCode == Keys.L)
                    {
                        button_equal.Focus();
                        Memory_Clear_Work();
                    }
                    else if (e.Control && e.KeyCode == Keys.P)
                    {
                        button_equal.Focus();
                        Memory_Plus_Work();

                    }
                    else if (e.Control && e.KeyCode == Keys.Q)
                    {
                        button_equal.Focus();
                        Memory_Minus_Work();
                    }
                    else if (e.Control && e.KeyCode == Keys.M)
                    {
                        button_equal.Focus();
                        Memory_Save_Work();
                    }
                    else if ((e.KeyCode == Keys.D5) && e.Shift)
                    {
                        button_equal.Focus();
                        Percent_Work();
                    }
                    break;
            }
           
        }
        
    }
}
