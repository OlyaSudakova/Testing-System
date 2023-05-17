namespace Testing
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            password = new TextBox();
            number = new TextBox();
            register = new Button();
            text = new Label();
            name = new TextBox();
            login = new TextBox();
            surname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
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
            // password
            // 
            resources.ApplyResources(password, "password");
            password.Name = "password";
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // number
            // 
            resources.ApplyResources(number, "number");
            number.Name = "number";
            number.TextChanged += number_TextChanged;
            number.Enter += number_Enter;
            number.KeyPress += login_KeyPress;
            number.Leave += number_Leave;
            // 
            // register
            // 
            resources.ApplyResources(register, "register");
            register.Cursor = Cursors.Hand;
            register.Name = "register";
            register.UseVisualStyleBackColor = true;
            register.Click += enter_Click;
            // 
            // text
            // 
            resources.ApplyResources(text, "text");
            text.Name = "text";
            text.Click += text_Click;
            // 
            // name
            // 
            resources.ApplyResources(name, "name");
            name.Name = "name";
            name.Enter += name_Enter;
            name.Leave += name_Leave;
            // 
            // login
            // 
            resources.ApplyResources(login, "login");
            login.Name = "login";
            // 
            // surname
            // 
            resources.ApplyResources(surname, "surname");
            surname.Name = "surname";
            surname.Enter += surname_Enter;
            surname.Leave += surname_Leave;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Cursor = Cursors.Hand;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(name, 0, 0);
            tableLayoutPanel1.Controls.Add(surname, 0, 1);
            tableLayoutPanel1.Controls.Add(number, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(password, 1, 1);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(login, 1, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(register);
            Controls.Add(text);
            Name = "RegisterForm";
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

        private TextBox password;
        private TextBox number;
        private Button register;
        private Label text;
        private TextBox name;
        private TextBox login;
        private TextBox surname;
        private Label label1;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}