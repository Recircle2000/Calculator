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
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.키보드입력도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Msg_Box = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            resources.ApplyResources(this.button_init, "button_init");
            this.button_init.ForeColor = System.Drawing.Color.Black;
            this.button_init.Name = "button_init";
            this.button_init.TabStop = false;
            this.button_init.UseVisualStyleBackColor = false;
            this.button_init.Click += new System.EventHandler(this.AllClear_btn_Click);
            // 
            // button_erase
            // 
            this.button_erase.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_erase, "button_erase");
            this.button_erase.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_erase.FlatAppearance.BorderSize = 0;
            this.button_erase.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_erase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_erase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_erase.ForeColor = System.Drawing.Color.Black;
            this.button_erase.Name = "button_erase";
            this.button_erase.TabStop = false;
            this.button_erase.UseVisualStyleBackColor = false;
            this.button_erase.Click += new System.EventHandler(this.Button_Erase_Click);
            // 
            // button_Remainder
            // 
            this.button_Remainder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Remainder.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Remainder.FlatAppearance.BorderSize = 0;
            this.button_Remainder.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Remainder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Remainder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button_Remainder, "button_Remainder");
            this.button_Remainder.ForeColor = System.Drawing.Color.Black;
            this.button_Remainder.Name = "button_Remainder";
            this.button_Remainder.TabStop = false;
            this.button_Remainder.UseVisualStyleBackColor = false;
            this.button_Remainder.Click += new System.EventHandler(this.Operator_Btn_Click);
            // 
            // button_Div
            // 
            this.button_Div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Div.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Div.FlatAppearance.BorderSize = 0;
            this.button_Div.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Div.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button_Div, "button_Div");
            this.button_Div.ForeColor = System.Drawing.Color.Black;
            this.button_Div.Name = "button_Div";
            this.button_Div.TabStop = false;
            this.button_Div.UseVisualStyleBackColor = false;
            this.button_Div.Click += new System.EventHandler(this.Operator_Btn_Click);
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
            resources.ApplyResources(this.button_Num_7, "button_Num_7");
            this.button_Num_7.ForeColor = System.Drawing.Color.Black;
            this.button_Num_7.Name = "button_Num_7";
            this.button_Num_7.TabStop = false;
            this.button_Num_7.UseVisualStyleBackColor = false;
            this.button_Num_7.Click += new System.EventHandler(this.Num_Btn_Click);
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
            resources.ApplyResources(this.button_Num_8, "button_Num_8");
            this.button_Num_8.ForeColor = System.Drawing.Color.Black;
            this.button_Num_8.Name = "button_Num_8";
            this.button_Num_8.TabStop = false;
            this.button_Num_8.UseVisualStyleBackColor = false;
            this.button_Num_8.Click += new System.EventHandler(this.Num_Btn_Click);
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
            resources.ApplyResources(this.button_Num_9, "button_Num_9");
            this.button_Num_9.ForeColor = System.Drawing.Color.Black;
            this.button_Num_9.Name = "button_Num_9";
            this.button_Num_9.TabStop = false;
            this.button_Num_9.UseVisualStyleBackColor = false;
            this.button_Num_9.Click += new System.EventHandler(this.Num_Btn_Click);
            // 
            // button_Mul
            // 
            this.button_Mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Mul.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Mul.FlatAppearance.BorderSize = 0;
            this.button_Mul.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Mul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Mul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button_Mul, "button_Mul");
            this.button_Mul.ForeColor = System.Drawing.Color.Black;
            this.button_Mul.Name = "button_Mul";
            this.button_Mul.TabStop = false;
            this.button_Mul.UseVisualStyleBackColor = false;
            this.button_Mul.Click += new System.EventHandler(this.Operator_Btn_Click);
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
            resources.ApplyResources(this.button_Num_4, "button_Num_4");
            this.button_Num_4.ForeColor = System.Drawing.Color.Black;
            this.button_Num_4.Name = "button_Num_4";
            this.button_Num_4.TabStop = false;
            this.button_Num_4.UseVisualStyleBackColor = false;
            this.button_Num_4.Click += new System.EventHandler(this.Num_Btn_Click);
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
            resources.ApplyResources(this.button_Num_5, "button_Num_5");
            this.button_Num_5.ForeColor = System.Drawing.Color.Black;
            this.button_Num_5.Name = "button_Num_5";
            this.button_Num_5.TabStop = false;
            this.button_Num_5.UseVisualStyleBackColor = false;
            this.button_Num_5.Click += new System.EventHandler(this.Num_Btn_Click);
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
            resources.ApplyResources(this.button_Num_6, "button_Num_6");
            this.button_Num_6.ForeColor = System.Drawing.Color.Black;
            this.button_Num_6.Name = "button_Num_6";
            this.button_Num_6.TabStop = false;
            this.button_Num_6.UseVisualStyleBackColor = false;
            this.button_Num_6.Click += new System.EventHandler(this.Num_Btn_Click);
            // 
            // button_Sub
            // 
            this.button_Sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sub.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Sub.FlatAppearance.BorderSize = 0;
            this.button_Sub.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Sub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Sub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button_Sub, "button_Sub");
            this.button_Sub.ForeColor = System.Drawing.Color.Black;
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.TabStop = false;
            this.button_Sub.UseVisualStyleBackColor = false;
            this.button_Sub.Click += new System.EventHandler(this.Operator_Btn_Click);
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
            resources.ApplyResources(this.button_Num_1, "button_Num_1");
            this.button_Num_1.ForeColor = System.Drawing.Color.Black;
            this.button_Num_1.Name = "button_Num_1";
            this.button_Num_1.TabStop = false;
            this.button_Num_1.UseVisualStyleBackColor = false;
            this.button_Num_1.Click += new System.EventHandler(this.Num_Btn_Click);
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
            resources.ApplyResources(this.button_Num_2, "button_Num_2");
            this.button_Num_2.ForeColor = System.Drawing.Color.Black;
            this.button_Num_2.Name = "button_Num_2";
            this.button_Num_2.TabStop = false;
            this.button_Num_2.UseVisualStyleBackColor = false;
            this.button_Num_2.Click += new System.EventHandler(this.Num_Btn_Click);
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
            resources.ApplyResources(this.button_Num_3, "button_Num_3");
            this.button_Num_3.ForeColor = System.Drawing.Color.Black;
            this.button_Num_3.Name = "button_Num_3";
            this.button_Num_3.TabStop = false;
            this.button_Num_3.UseVisualStyleBackColor = false;
            this.button_Num_3.Click += new System.EventHandler(this.Num_Btn_Click);
            // 
            // button_Add
            // 
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button_Add, "button_Add");
            this.button_Add.ForeColor = System.Drawing.Color.Black;
            this.button_Add.Name = "button_Add";
            this.button_Add.TabStop = false;
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.Operator_Btn_Click);
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
            resources.ApplyResources(this.button_Num_0, "button_Num_0");
            this.button_Num_0.ForeColor = System.Drawing.Color.Black;
            this.button_Num_0.Name = "button_Num_0";
            this.button_Num_0.TabStop = false;
            this.button_Num_0.UseVisualStyleBackColor = false;
            this.button_Num_0.Click += new System.EventHandler(this.Num_Btn_Click);
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
            resources.ApplyResources(this.button_period, "button_period");
            this.button_period.ForeColor = System.Drawing.Color.Black;
            this.button_period.Name = "button_period";
            this.button_period.TabStop = false;
            this.button_period.UseVisualStyleBackColor = false;
            this.button_period.Click += new System.EventHandler(this.Period_Btn_Click);
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.Color.DimGray;
            this.button_equal.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_equal, "button_equal");
            this.button_equal.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_equal.FlatAppearance.BorderSize = 0;
            this.button_equal.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button_equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_equal.ForeColor = System.Drawing.Color.White;
            this.button_equal.Name = "button_equal";
            this.button_equal.TabStop = false;
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.Equal_Btn_Click);
            // 
            // label_result
            // 
            this.label_result.AutoEllipsis = true;
            resources.ApplyResources(this.label_result, "label_result");
            this.label_result.Name = "label_result";
            // 
            // label_mem
            // 
            resources.ApplyResources(this.label_mem, "label_mem");
            this.label_mem.Name = "label_mem";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CE);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Name = "button2";
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Swap_Btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem,
            this.키보드입력도움말ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            resources.ApplyResources(this.메뉴ToolStripMenuItem, "메뉴ToolStripMenuItem");
            this.메뉴ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // 키보드입력도움말ToolStripMenuItem
            // 
            this.키보드입력도움말ToolStripMenuItem.Name = "키보드입력도움말ToolStripMenuItem";
            resources.ApplyResources(this.키보드입력도움말ToolStripMenuItem, "키보드입력도움말ToolStripMenuItem");
            this.키보드입력도움말ToolStripMenuItem.Click += new System.EventHandler(this.키보드입력도움말ToolStripMenuItem_Click);
            // 
            // Msg_Box
            // 
            resources.ApplyResources(this.Msg_Box, "Msg_Box");
            this.Msg_Box.Name = "Msg_Box";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Name = "button3";
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Name = "button4";
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Name = "button5";
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Name = "button6";
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button7, "button7");
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Name = "button7";
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Cal_Main_UI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Msg_Box);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cal_Main_UI";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.Label Msg_Box;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem 키보드입력도움말ToolStripMenuItem;
    }
}

