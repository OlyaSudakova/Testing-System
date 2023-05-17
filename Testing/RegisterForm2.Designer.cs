namespace Testing
{
    partial class RegisterForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm2));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            surname = new TextBox();
            login = new TextBox();
            name = new TextBox();
            password = new TextBox();
            dis = new TextBox();
            enter = new Button();
            text = new Label();
            checkBox1 = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Cursor = Cursors.Hand;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(146, 353);
            button1.Name = "button1";
            button1.Size = new Size(191, 60);
            button1.TabIndex = 33;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(54, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 22);
            label2.TabIndex = 32;
            label2.Text = "Введите пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(52, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 22);
            label1.TabIndex = 31;
            label1.Text = "Введите логин";
            // 
            // surname
            // 
            surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            surname.Location = new Point(3, 88);
            surname.Name = "surname";
            surname.Size = new Size(382, 31);
            surname.TabIndex = 30;
            surname.Enter += surname_Enter;
            surname.Leave += surname_Leave_1;
            // 
            // login
            // 
            login.Location = new Point(52, 42);
            login.Name = "login";
            login.Size = new Size(322, 31);
            login.TabIndex = 34;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name.Location = new Point(3, 3);
            name.Name = "name";
            name.Size = new Size(382, 31);
            name.TabIndex = 28;
            name.Enter += name_Enter_1;
            name.Leave += name_Leave;
            // 
            // password
            // 
            password.Location = new Point(54, 42);
            password.Name = "password";
            password.Size = new Size(322, 31);
            password.TabIndex = 27;
            password.UseSystemPasswordChar = true;
            // 
            // dis
            // 
            dis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dis.Location = new Point(3, 173);
            dis.Name = "dis";
            dis.Size = new Size(382, 31);
            dis.TabIndex = 26;
            dis.Enter += dis_Enter_1;
            dis.Leave += dis_Leave_1;
            // 
            // enter
            // 
            enter.Anchor = AnchorStyles.Top;
            enter.Cursor = Cursors.Hand;
            enter.ImeMode = ImeMode.NoControl;
            enter.Location = new Point(403, 353);
            enter.Name = "enter";
            enter.Size = new Size(265, 60);
            enter.TabIndex = 25;
            enter.Text = "Зарегистрироваться";
            enter.UseVisualStyleBackColor = true;
            enter.Click += register_Click;
            // 
            // text
            // 
            text.Anchor = AnchorStyles.Top;
            text.Font = new Font("Century", 24F, FontStyle.Regular, GraphicsUnit.Point);
            text.ImeMode = ImeMode.NoControl;
            text.Location = new Point(68, 24);
            text.Name = "text";
            text.Size = new Size(681, 57);
            text.TabIndex = 24;
            text.Text = "Регистрация преподавателя";
            text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.ImageAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(112, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 29);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "показать пароль";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Controls.Add(name, 0, 0);
            tableLayoutPanel1.Controls.Add(surname, 0, 1);
            tableLayoutPanel1.Controls.Add(dis, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 107);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(776, 231);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3507853F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.6492157F));
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(password, 1, 1);
            tableLayoutPanel3.Location = new Point(391, 88);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(382, 79);
            tableLayoutPanel3.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8272247F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.1727753F));
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(login, 1, 1);
            tableLayoutPanel2.Location = new Point(391, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(382, 79);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.65445F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.34555F));
            tableLayoutPanel4.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel4.Location = new Point(391, 173);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(382, 55);
            tableLayoutPanel4.TabIndex = 23;
            // 
            // RegisterForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(enter);
            Controls.Add(text);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(822, 506);
            Name = "RegisterForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация ";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox surname;
        private TextBox login;
        private TextBox name;
        private TextBox password;
        private TextBox dis;
        private Button enter;
        private Label text;
        private CheckBox checkBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
    }
}