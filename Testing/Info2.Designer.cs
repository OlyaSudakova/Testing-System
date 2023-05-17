namespace Testing
{
    partial class Info2
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
            exit = new Button();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top;
            exit.Location = new Point(209, 384);
            exit.MinimumSize = new Size(154, 54);
            exit.Name = "exit";
            exit.Size = new Size(154, 54);
            exit.TabIndex = 92;
            exit.Text = "Назад";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Info2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(566, 450);
            Controls.Add(exit);
            Name = "Info2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info2";
            ResumeLayout(false);
        }

        #endregion

        private Button exit;
    }
}