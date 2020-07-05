using System;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Cal_Main_UI : Form
    {
        private double Value;
        private bool newBut;
        private string Operator;
        public Cal_Main_UI()
        {
            InitializeComponent();
            label_result.Text = "0";
        }

        //각 숫자 키를 마우스로 입력했을때의 처리
        public void Num_Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Num_Work(btn.Text);
        }

        //각 연산자 키를 마우스로 입력했을 때의 처리 method
        public void Operator_Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Operator = btn.Text;
            Operator_Work();
        }
        //전체 초기화
        public void AllClear_btn_Click(object sender, EventArgs e)
        {
            All_Clear_Work();
        }
        
        // 지우기 버튼을 클릭했을 때의 처리 method
        private void Button_Erase_Click(object sender, EventArgs e)
        {
            Erase_Work();
        }

        // 마지막 연산기호를 누른 뒤 입력한 숫자를 지우는 method
        private void CE(object sender, EventArgs e)
        {
            CE_Work();
        }

        //최종 연산 수행 메소드
        private void Equal_Btn_Click(object sender, EventArgs e)
        {
            Equal_Work();
        }

        //숫자의 음/양을 전환하는 메소드
        private void Swap_Btn_Click(object sender, EventArgs e)
        {
            Swap_Work();
        }

        //소수점을 추가하는 메소드
        private void Period_Btn_Click(object sender, EventArgs e)
        {
            Period_Work();
        }

        //키보드 입력 통합 처리
        private void Num_KeyDown(object sender, KeyPressEventArgs e)
        {
            Msg_Box.Text = e.KeyChar.ToString();
            //숫자
            if (char.IsDigit(e.KeyChar))
            {
                Num_Work(e.KeyChar.ToString());
            }
            //연산자
            else if (e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '-' || e.KeyChar == '+' || e.KeyChar == '%')
            {
                if (e.KeyChar == '/')
                {
                    Operator = "÷";
                }
                else
                {
                    Operator = e.KeyChar.ToString();
                }
                Operator_Work();
            }
            //Backspace
            else if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                Erase_Work();
            }
            //Clear
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                All_Clear_Work();
            }
            else
                Msg_Box.Text = "올바르지않은 입력. \n키보드 입력시 도움말을 참조 하세요. ";
            
        }

        //일부 keydown이 필요한 경우 사용.
        private void Key_Down(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    CE_Work();
                    break;

                case Keys.F9:
                    Swap_Work();
                    break;

                case Keys.Decimal:
                    Period_Work(); 
                    break;

                case Keys.Enter:
                    if (button_equal.Enabled==true)
                    {
                        Equal_Work();
                    }
                    
                    break;

                default:
                    break;
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
        }


       
    }
}
