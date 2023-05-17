namespace Testing
{
    partial class MainWindow2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow2));
            label1 = new Label();
            exit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 10);
            label1.Name = "label1";
            label1.Size = new Size(483, 57);
            label1.TabIndex = 9;
            label1.Text = "Добро пожаловать!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exit.Cursor = Cursors.Hand;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(483, 406);
            exit.Name = "exit";
            exit.Size = new Size(94, 33);
            exit.TabIndex = 5;
            exit.Text = "выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button4_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Location = new Point(137, 116);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(301, 231);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 155);
            button3.Name = "button3";
            button3.Size = new Size(295, 73);
            button3.TabIndex = 13;
            button3.Text = "Просмотр оценок";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(295, 70);
            button1.TabIndex = 11;
            button1.Text = "Добавить тест";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 79);
            button2.Name = "button2";
            button2.Size = new Size(295, 70);
            button2.TabIndex = 12;
            button2.Text = "Посмотр тестов";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // MainWindow2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(585, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(exit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(607, 506);
            Name = "MainWindow2";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button exit;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}