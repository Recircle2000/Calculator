using System;
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
            label_result.Text = "0";
        }


        public void Num_Btn_Click(object sender, EventArgs e) //각 숫자 키를 마우스로 입력했을때의 처리 method
        {
            Button btn = sender as Button;
            Num_integrate_Work(btn.Text);
        }
      
        private void Num_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                Num_integrate_Work(e.KeyChar.ToString());
            }
            

        }

        private void Num_integrate_Work(string number)
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


        public void Operator_Btn_Click(object sender, EventArgs e) //각 연산자 키를 마우스로 입력했을 때의 처리 method
        {
            Button btn = sender as Button;
            Value = Double.Parse(label_result.Text);
            Operator = char.Parse(btn.Text);
            label_mem.Text = Value + btn.Text;
            //label_result.Text = "0";
            newBut = true;
            button_equal.Enabled = true;
            Check_Calculation_availability();
        }


        public void All_Clear(object sender, EventArgs e) //C (Clear)버튼을 클릭했을 떄의 초기화 method
        {
            label_result.Text = "0";
            label_mem.Text = "";
            newBut = true;
            button_erase.Enabled = false;
            Msg_Box.Text = "";
        }

        private void Check_Calculation_availability()  //연산이 불가능한 예외가 있을경우 Equal버튼을 비활성화 하는 함수
        {
            if (Operator == '÷' && label_result.Text == "0")
            {
                Msg_Box.Text = "0으로 나눌수 없습니다.";
                button_equal.Enabled = false;
            }
        }


        private void button_erase_Click(object sender, EventArgs e)// 지우기 버튼을 클릭했을 때의 처리 method
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


        private void CE(object sender, EventArgs e) // 마지막 연산기호를 누른 뒤 입력한 숫자를 지우는 method
        {
            label_result.Text = "0";
            button_erase.Enabled = false;
            newBut = true;
            Msg_Box.Text = "";
        }


        private void Equal_Btn_Click(object sender, EventArgs e)//최종 연산 수행 메소드
        {
            switch (Operator)
            {
                case '+':
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value + Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    newBut = true;
                    break;
                case '-':
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value - Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    newBut = true;
                    break;
                case '×':
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value * Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    newBut = true;
                    break;
                case '÷':
                    label_mem.Text = label_mem.Text + label_result.Text + "=";
                    label_result.Text = (Value / Double.Parse(label_result.Text)).ToString();
                    button_equal.Enabled = false;
                    newBut = true;
                    break;
                default:
                    break;
            }
        }


        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e) // 프로그램 정보 및 빌드번호
        {
            MessageBox.Show("호서대학교 20191220 이재원 \nC# 프로그래밍 \n\nBuild : 4");
        }


        private void Swap_Btn_Click(object sender, EventArgs e) //숫자의 음/양을 전환하는 메소드
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

        private void Period_Btn_Click(object sender, EventArgs e) //소수점을 추가하는 메소드
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

        


    }
}
