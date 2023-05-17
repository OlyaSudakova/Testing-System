namespace Testing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            password = new TextBox();
            login = new TextBox();
            enter = new Button();
            text = new Label();
            label1 = new Label();
            student = new Button();
            teacher = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password.Location = new Point(309, 69);
            password.Name = "password";
            password.Size = new Size(464, 31);
            password.TabIndex = 13;
            password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            login.Location = new Point(309, 3);
            login.Name = "login";
            login.Size = new Size(464, 31);
            login.TabIndex = 12;
            // 
            // enter
            // 
            enter.Cursor = Cursors.Hand;
            enter.Location = new Point(3, 3);
            enter.Name = "enter";
            enter.Size = new Size(185, 48);
            enter.TabIndex = 11;
            enter.Text = "Войти";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click_1;
            // 
            // text
            // 
            text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            text.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            text.Location = new Point(351, 75);
            text.Name = "text";
            text.Size = new Size(128, 60);
            text.TabIndex = 10;
            text.Text = "Вход";
            text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(140, 366);
            label1.Name = "label1";
            label1.Size = new Size(568, 28);
            label1.TabIndex = 14;
            label1.Text = "Не зарегистрировались? Пройдите регистрацию ниже\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // student
            // 
            student.Anchor = AnchorStyles.Right;
            student.Cursor = Cursors.Hand;
            student.Location = new Point(233, 3);
            student.Name = "student";
            student.Size = new Size(150, 46);
            student.TabIndex = 15;
            student.Text = "Студент";
            student.UseVisualStyleBackColor = true;
            student.Click += button1_Click;
            // 
            // teacher
            // 
            teacher.Anchor = AnchorStyles.Left;
            teacher.Cursor = Cursors.Hand;
            teacher.Location = new Point(389, 3);
            teacher.Name = "teacher";
            teacher.Size = new Size(150, 46);
            teacher.TabIndex = 16;
            teacher.Text = "Преподаватель";
            teacher.UseVisualStyleBackColor = true;
            teacher.Click += teacher_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 28);
            label2.TabIndex = 17;
            label2.Text = "Введите логин";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(300, 28);
            label3.TabIndex = 18;
            label3.Text = "Введите пароль";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Century", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 9);
            label4.MinimumSize = new Size(731, 57);
            label4.Name = "label4";
            label4.Size = new Size(731, 57);
            label4.TabIndex = 19;
            label4.Text = "Система тестирования БГУИР";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // checkBox1
            // 
            checkBox1.CheckAlign = ContentAlignment.TopLeft;
            checkBox1.Location = new Point(248, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(213, 29);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.43299F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.56701F));
            tableLayoutPanel1.Controls.Add(login, 1, 0);
            tableLayoutPanel1.Controls.Add(password, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 153);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(776, 201);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 219F));
            tableLayoutPanel3.Controls.Add(checkBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(enter, 0, 0);
            tableLayoutPanel3.Location = new Point(309, 135);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(464, 63);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(teacher, 1, 0);
            tableLayoutPanel2.Controls.Add(student, 0, 0);
            tableLayoutPanel2.Location = new Point(15, 397);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(773, 52);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(text);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(822, 506);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox password;
        private TextBox login;
        private Button enter;
        private Label text;
        private Label label1;
        private Button student;
        private Button teacher;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}