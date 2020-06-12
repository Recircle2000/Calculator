namespace Calculator
{
    partial class Cal_Main_UI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cal_Main_UI));
            this.button_init = new System.Windows.Forms.Button();
            this.button_erase = new System.Windows.Forms.Button();
            this.button_Remainder = new System.Windows.Forms.Button();
            this.button_Div = new System.Windows.Forms.Button();
            this.button_Num_7 = new System.Windows.Forms.Button();
            this.button_Num_8 = new System.Windows.Forms.Button();
            this.button_Num_9 = new System.Windows.Forms.Button();
            this.button_Mul = new System.Windows.Forms.Button();
            this.button_Num_4 = new System.Windows.Forms.Button();
            this.button_Num_5 = new System.Windows.Forms.Button();
            this.button_Num_6 = new System.Windows.Forms.Button();
            this.button_Sub = new System.Windows.Forms.Button();
            this.button_Num_1 = new System.Windows.Forms.Button();
            this.button_Num_2 = new System.Windows.Forms.Button();
            this.button_Num_3 = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Num_0 = new System.Windows.Forms.Button();
            this.button_period = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_mem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_init
            // 
            this.button_init.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_init.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_init.FlatAppearance.BorderSize = 0;
            this.button_init.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_init.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_init.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_init.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_init.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_init.ForeColor = System.Drawing.Color.Black;
            this.button_init.Location = new System.Drawing.Point(145, 92);
            this.button_init.Name = "button_init";
            this.button_init.Size = new System.Drawing.Size(60, 27);
            this.button_init.TabIndex = 0;
            this.button_init.Text = "C";
            this.button_init.UseVisualStyleBackColor = false;
            this.button_init.Click += new System.EventHandler(this.All_Clear);
            // 
            // button_erase
            // 
            this.button_erase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_erase.Enabled = false;
            this.button_erase.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_erase.FlatAppearance.BorderSize = 0;
            this.button_erase.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_erase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_erase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_erase.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_erase.ForeColor = System.Drawing.Color.Black;
            this.button_erase.Location = new System.Drawing.Point(211, 92);
            this.button_erase.Name = "button_erase";
            this.button_erase.Size = new System.Drawing.Size(60, 60);
            this.button_erase.TabIndex = 1;
            this.button_erase.Text = "←";
            this.button_erase.UseVisualStyleBackColor = false;
            this.button_erase.Click += new System.EventHandler(this.button_erase_Click);
            // 
            // button_Remainder
            // 
            this.button_Remainder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Remainder.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Remainder.FlatAppearance.BorderSize = 0;
            this.button_Remainder.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Remainder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Remainder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Remainder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remainder.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remainder.ForeColor = System.Drawing.Color.Black;
            this.button_Remainder.Location = new System.Drawing.Point(12, 92);
            this.button_Remainder.Name = "button_Remainder";
            this.button_Remainder.Size = new System.Drawing.Size(60, 60);
            this.button_Remainder.TabIndex = 2;
            this.button_Remainder.Text = "%";
            this.button_Remainder.UseVisualStyleBackColor = false;
            // 
            // button_Div
            // 
            this.button_Div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Div.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Div.FlatAppearance.BorderSize = 0;
            this.button_Div.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Div.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Div.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Div.ForeColor = System.Drawing.Color.Black;
            this.button_Div.Location = new System.Drawing.Point(79, 92);
            this.button_Div.Name = "button_Div";
            this.button_Div.Size = new System.Drawing.Size(60, 60);
            this.button_Div.TabIndex = 3;
            this.button_Div.Text = "÷";
            this.button_Div.UseVisualStyleBackColor = false;
            // 
            // button_Num_7
            // 
            this.button_Num_7.BackColor = System.Drawing.Color.White;
            this.button_Num_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_7.FlatAppearance.BorderSize = 0;
            this.button_Num_7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_7.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_7.ForeColor = System.Drawing.Color.Black;
            this.button_Num_7.Location = new System.Drawing.Point(13, 158);
            this.button_Num_7.Name = "button_Num_7";
            this.button_Num_7.Size = new System.Drawing.Size(60, 60);
            this.button_Num_7.TabIndex = 4;
            this.button_Num_7.Text = "7";
            this.button_Num_7.UseVisualStyleBackColor = false;
            this.button_Num_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num_8
            // 
            this.button_Num_8.BackColor = System.Drawing.Color.White;
            this.button_Num_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_8.FlatAppearance.BorderSize = 0;
            this.button_Num_8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_8.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_8.ForeColor = System.Drawing.Color.Black;
            this.button_Num_8.Location = new System.Drawing.Point(79, 158);
            this.button_Num_8.Name = "button_Num_8";
            this.button_Num_8.Size = new System.Drawing.Size(60, 60);
            this.button_Num_8.TabIndex = 5;
            this.button_Num_8.Text = "8";
            this.button_Num_8.UseVisualStyleBackColor = false;
            this.button_Num_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num_9
            // 
            this.button_Num_9.BackColor = System.Drawing.Color.White;
            this.button_Num_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_9.FlatAppearance.BorderSize = 0;
            this.button_Num_9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_9.ForeColor = System.Drawing.Color.Black;
            this.button_Num_9.Location = new System.Drawing.Point(145, 158);
            this.button_Num_9.Name = "button_Num_9";
            this.button_Num_9.Size = new System.Drawing.Size(60, 60);
            this.button_Num_9.TabIndex = 6;
            this.button_Num_9.Text = "9";
            this.button_Num_9.UseVisualStyleBackColor = false;
            this.button_Num_9.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Mul
            // 
            this.button_Mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Mul.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Mul.FlatAppearance.BorderSize = 0;
            this.button_Mul.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Mul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Mul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mul.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Mul.ForeColor = System.Drawing.Color.Black;
            this.button_Mul.Location = new System.Drawing.Point(211, 158);
            this.button_Mul.Name = "button_Mul";
            this.button_Mul.Size = new System.Drawing.Size(60, 60);
            this.button_Mul.TabIndex = 7;
            this.button_Mul.Text = "×";
            this.button_Mul.UseVisualStyleBackColor = false;
            // 
            // button_Num_4
            // 
            this.button_Num_4.BackColor = System.Drawing.Color.White;
            this.button_Num_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_4.FlatAppearance.BorderSize = 0;
            this.button_Num_4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_4.ForeColor = System.Drawing.Color.Black;
            this.button_Num_4.Location = new System.Drawing.Point(13, 224);
            this.button_Num_4.Name = "button_Num_4";
            this.button_Num_4.Size = new System.Drawing.Size(60, 60);
            this.button_Num_4.TabIndex = 8;
            this.button_Num_4.Text = "4";
            this.button_Num_4.UseVisualStyleBackColor = false;
            this.button_Num_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num_5
            // 
            this.button_Num_5.BackColor = System.Drawing.Color.White;
            this.button_Num_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_5.FlatAppearance.BorderSize = 0;
            this.button_Num_5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_5.ForeColor = System.Drawing.Color.Black;
            this.button_Num_5.Location = new System.Drawing.Point(79, 224);
            this.button_Num_5.Name = "button_Num_5";
            this.button_Num_5.Size = new System.Drawing.Size(60, 60);
            this.button_Num_5.TabIndex = 9;
            this.button_Num_5.Text = "5";
            this.button_Num_5.UseVisualStyleBackColor = false;
            this.button_Num_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num_6
            // 
            this.button_Num_6.BackColor = System.Drawing.Color.White;
            this.button_Num_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_6.FlatAppearance.BorderSize = 0;
            this.button_Num_6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_6.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_6.ForeColor = System.Drawing.Color.Black;
            this.button_Num_6.Location = new System.Drawing.Point(145, 224);
            this.button_Num_6.Name = "button_Num_6";
            this.button_Num_6.Size = new System.Drawing.Size(60, 60);
            this.button_Num_6.TabIndex = 10;
            this.button_Num_6.Text = "6";
            this.button_Num_6.UseVisualStyleBackColor = false;
            this.button_Num_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Sub
            // 
            this.button_Sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sub.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Sub.FlatAppearance.BorderSize = 0;
            this.button_Sub.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Sub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Sub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sub.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sub.ForeColor = System.Drawing.Color.Black;
            this.button_Sub.Location = new System.Drawing.Point(211, 224);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(60, 60);
            this.button_Sub.TabIndex = 11;
            this.button_Sub.Text = "-";
            this.button_Sub.UseVisualStyleBackColor = false;
            // 
            // button_Num_1
            // 
            this.button_Num_1.BackColor = System.Drawing.Color.White;
            this.button_Num_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_1.FlatAppearance.BorderSize = 0;
            this.button_Num_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_1.ForeColor = System.Drawing.Color.Black;
            this.button_Num_1.Location = new System.Drawing.Point(13, 290);
            this.button_Num_1.Name = "button_Num_1";
            this.button_Num_1.Size = new System.Drawing.Size(60, 60);
            this.button_Num_1.TabIndex = 12;
            this.button_Num_1.Text = "1";
            this.button_Num_1.UseVisualStyleBackColor = false;
            this.button_Num_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num_2
            // 
            this.button_Num_2.BackColor = System.Drawing.Color.White;
            this.button_Num_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_2.FlatAppearance.BorderSize = 0;
            this.button_Num_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_2.ForeColor = System.Drawing.Color.Black;
            this.button_Num_2.Location = new System.Drawing.Point(79, 290);
            this.button_Num_2.Name = "button_Num_2";
            this.button_Num_2.Size = new System.Drawing.Size(60, 60);
            this.button_Num_2.TabIndex = 13;
            this.button_Num_2.Text = "2";
            this.button_Num_2.UseVisualStyleBackColor = false;
            this.button_Num_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Num_3
            // 
            this.button_Num_3.BackColor = System.Drawing.Color.White;
            this.button_Num_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_3.FlatAppearance.BorderSize = 0;
            this.button_Num_3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_3.ForeColor = System.Drawing.Color.Black;
            this.button_Num_3.Location = new System.Drawing.Point(145, 290);
            this.button_Num_3.Name = "button_Num_3";
            this.button_Num_3.Size = new System.Drawing.Size(60, 60);
            this.button_Num_3.TabIndex = 14;
            this.button_Num_3.Text = "3";
            this.button_Num_3.UseVisualStyleBackColor = false;
            this.button_Num_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_Add
            // 
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.Black;
            this.button_Add.Location = new System.Drawing.Point(211, 290);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(60, 60);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = false;
            // 
            // button_Num_0
            // 
            this.button_Num_0.BackColor = System.Drawing.Color.White;
            this.button_Num_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Num_0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Num_0.FlatAppearance.BorderSize = 0;
            this.button_Num_0.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_Num_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Num_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_Num_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Num_0.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Num_0.ForeColor = System.Drawing.Color.Black;
            this.button_Num_0.Location = new System.Drawing.Point(13, 356);
            this.button_Num_0.Name = "button_Num_0";
            this.button_Num_0.Size = new System.Drawing.Size(126, 60);
            this.button_Num_0.TabIndex = 16;
            this.button_Num_0.Text = "0";
            this.button_Num_0.UseVisualStyleBackColor = false;
            this.button_Num_0.Click += new System.EventHandler(this.btn_Click);
            // 
            // button_period
            // 
            this.button_period.BackColor = System.Drawing.Color.White;
            this.button_period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_period.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_period.FlatAppearance.BorderSize = 0;
            this.button_period.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_period.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_period.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_period.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_period.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_period.ForeColor = System.Drawing.Color.Black;
            this.button_period.Location = new System.Drawing.Point(145, 356);
            this.button_period.Name = "button_period";
            this.button_period.Size = new System.Drawing.Size(60, 60);
            this.button_period.TabIndex = 17;
            this.button_period.Text = ".";
            this.button_period.UseVisualStyleBackColor = false;
            // 
            // button_equal
            // 
            this.button_equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_equal.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_equal.FlatAppearance.BorderSize = 0;
            this.button_equal.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equal.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.ForeColor = System.Drawing.Color.Black;
            this.button_equal.Location = new System.Drawing.Point(211, 356);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(60, 60);
            this.button_equal.TabIndex = 18;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            // 
            // label_result
            // 
            this.label_result.AutoEllipsis = true;
            this.label_result.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_result.Location = new System.Drawing.Point(13, 38);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(271, 51);
            this.label_result.TabIndex = 19;
            this.label_result.Text = "0";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_mem
            // 
            this.label_mem.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_mem.Location = new System.Drawing.Point(13, 23);
            this.label_mem.Name = "label_mem";
            this.label_mem.Size = new System.Drawing.Size(258, 23);
            this.label_mem.TabIndex = 20;
            this.label_mem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(145, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CE);
            // 
            // Cal_Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(289, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_mem);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_period);
            this.Controls.Add(this.button_Num_0);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Num_3);
            this.Controls.Add(this.button_Num_2);
            this.Controls.Add(this.button_Num_1);
            this.Controls.Add(this.button_Sub);
            this.Controls.Add(this.button_Num_6);
            this.Controls.Add(this.button_Num_5);
            this.Controls.Add(this.button_Num_4);
            this.Controls.Add(this.button_Mul);
            this.Controls.Add(this.button_Num_9);
            this.Controls.Add(this.button_Num_8);
            this.Controls.Add(this.button_Num_7);
            this.Controls.Add(this.button_Div);
            this.Controls.Add(this.button_Remainder);
            this.Controls.Add(this.button_erase);
            this.Controls.Add(this.button_init);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cal_Main_UI";
            this.Text = "계산기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.Button button_erase;
        private System.Windows.Forms.Button button_Remainder;
        private System.Windows.Forms.Button button_Div;
        private System.Windows.Forms.Button button_Num_7;
        private System.Windows.Forms.Button button_Num_8;
        private System.Windows.Forms.Button button_Num_9;
        private System.Windows.Forms.Button button_Mul;
        private System.Windows.Forms.Button button_Num_4;
        private System.Windows.Forms.Button button_Num_5;
        private System.Windows.Forms.Button button_Num_6;
        private System.Windows.Forms.Button button_Sub;
        private System.Windows.Forms.Button button_Num_1;
        private System.Windows.Forms.Button button_Num_2;
        private System.Windows.Forms.Button button_Num_3;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Num_0;
        private System.Windows.Forms.Button button_period;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_mem;
        private System.Windows.Forms.Button button1;
    }
}

