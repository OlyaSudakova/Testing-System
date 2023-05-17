using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Testing
{
    public partial class AddTest : Form
    {
        public AddTest()
        {
            InitializeComponent();
            name.Text = "Введите название теста";
            name.ForeColor = Color.Gray;

            disc.Text = "Введите дисциплину";
            disc.ForeColor = Color.Gray;

            q1_1.Text = "Введите правильный ответ";
            q1_1.ForeColor = Color.Gray;
            q1_2.Text = "Введите ответ";
            q1_2.ForeColor = Color.Gray;
            q1_3.Text = "Введите ответ";
            q1_3.ForeColor = Color.Gray;

            q2_1.Text = "Введите правильный ответ";
            q2_1.ForeColor = Color.Gray;
            q2_2.Text = "Введите ответ";
            q2_2.ForeColor = Color.Gray;
            q2_3.Text = "Введите ответ";
            q2_3.ForeColor = Color.Gray;

            q3_1.Text = "Введите правильный ответ";
            q3_1.ForeColor = Color.Gray;
            q3_2.Text = "Введите ответ";
            q3_2.ForeColor = Color.Gray;
            q3_3.Text = "Введите ответ";
            q3_3.ForeColor = Color.Gray;

            q4_1.Text = "Введите правильный ответ";
            q4_1.ForeColor = Color.Gray;
            q4_2.Text = "Введите ответ";
            q4_2.ForeColor = Color.Gray;
            q4_3.Text = "Введите ответ";
            q4_3.ForeColor = Color.Gray;

            q5_1.Text = "Введите правильный ответ";
            q5_1.ForeColor = Color.Gray;
            q5_2.Text = "Введите ответ";
            q5_2.ForeColor = Color.Gray;
            q5_3.Text = "Введите ответ";
            q5_3.ForeColor = Color.Gray;

            q6_1.Text = "Введите правильный ответ";
            q6_1.ForeColor = Color.Gray;
            q6_2.Text = "Введите ответ";
            q6_2.ForeColor = Color.Gray;
            q6_3.Text = "Введите ответ";
            q6_3.ForeColor = Color.Gray;

            q7_1.Text = "Введите правильный ответ";
            q7_1.ForeColor = Color.Gray;
            q7_2.Text = "Введите ответ";
            q7_2.ForeColor = Color.Gray;
            q7_3.Text = "Введите ответ";
            q7_3.ForeColor = Color.Gray;

            q8_1.Text = "Введите правильный ответ";
            q8_1.ForeColor = Color.Gray;
            q8_2.Text = "Введите ответ";
            q8_2.ForeColor = Color.Gray;
            q8_3.Text = "Введите ответ";
            q8_3.ForeColor = Color.Gray;

            q9_1.Text = "Введите правильный ответ";
            q9_1.ForeColor = Color.Gray;
            q9_2.Text = "Введите ответ";
            q9_2.ForeColor = Color.Gray;
            q9_3.Text = "Введите ответ";
            q9_3.ForeColor = Color.Gray;

            q10_1.Text = "Введите правильный ответ";
            q10_1.ForeColor = Color.Gray;
            q10_2.Text = "Введите ответ";
            q10_2.ForeColor = Color.Gray;
            q10_3.Text = "Введите ответ";
            q10_3.ForeColor = Color.Gray;

            q1.Text = "Введите вопрос";
            q1.ForeColor = Color.Gray;
            q2.Text = "Введите вопрос";
            q2.ForeColor = Color.Gray;
            q3.Text = "Введите вопрос";
            q3.ForeColor = Color.Gray;
            q4.Text = "Введите вопрос";
            q4.ForeColor = Color.Gray;
            q5.Text = "Введите вопрос";
            q5.ForeColor = Color.Gray;
            q6.Text = "Введите вопрос";
            q6.ForeColor = Color.Gray;
            q7.Text = "Введите вопрос";
            q7.ForeColor = Color.Gray;
            q8.Text = "Введите вопрос";
            q8.ForeColor = Color.Gray;
            q9.Text = "Введите вопрос";
            q9.ForeColor = Color.Gray;
            q10.Text = "Введите вопрос";
            q10.ForeColor = Color.Gray;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (name.Text == "Введите название теста" || name.Text == "")
            {
                MessageBox.Show("Введите название теста");
                return;
            }
            if (q1.Text == "Введите вопрос" || q2.Text == "Введите вопрос" || q3.Text == "Введите вопрос" || q4.Text == "Введите вопрос" || q5.Text == "Введите вопрос" || q6.Text == "Введите вопрос" ||
                q7.Text == "Введите вопрос" || q8.Text == "Введите вопрос" || q9.Text == "Введите вопрос" || q10.Text == "Введите вопрос")
            {
                MessageBox.Show("Введите вопрос");
                return;
            }
            if (q1_1.Text == "Введите ответ" || q1_2.Text == "Введите ответ" || q1_3.Text == "Введите ответ" || q2_1.Text == "Введите ответ" || q3_2.Text == "Введите ответ" ||
                q2_3.Text == "Введите ответ" || q3_1.Text == "Введите ответ" || q3_2.Text == "Введите ответ" || q3_3.Text == "Введите ответ" || q4_1.Text == "Введите ответ" || q4_2.Text == "Введите ответ" ||
                q4_3.Text == "Введите ответ" || q5_1.Text == "Введите ответ" || q5_2.Text == "Введите ответ" || q5_3.Text == "Введите ответ" || q6_1.Text == "Введите ответ" || q6_2.Text == "Введите ответ" ||
                q6_3.Text == "Введите ответ" || q7_1.Text == "Введите ответ" || q7_2.Text == "Введите ответ" || q7_3.Text == "Введите ответ" || q8_1.Text == "Введите ответ" || q8_2.Text == "Введите ответ" ||
                q8_3.Text == "Введите ответ" || q9_1.Text == "Введите ответ" || q9_2.Text == "Введите ответ" || q9_3.Text == "Введите ответ" || q10_1.Text == "Введите ответ" || q10_2.Text == "Введите ответ" ||
                q10_3.Text == "Введите ответ")
            {
                MessageBox.Show("Введите ответ");
                return;
            }
            if (disc.Text == "Введите дисциплину")
            {
                MessageBox.Show("Введите дисциплину");
                return;
            }

            BD3 db = new BD3();


            MySqlCommand command = new MySqlCommand("INSERT INTO `test` (`name`, `question1`, `answer1`, `answer2`, `answer3`, `question2`, `answer21`, `answer22`, `answer23`," +
           " `question3`, `answer31`, `answer32`, `answer33`, `question4`, `answer41`, `answer42`, `answer43`, `question5`, `answer51`, `answer52`, `answer53`," +
           " `question6`, `answer61`, `answer62`, `answer63`, `question7`, `answer71`, `answer72`, `answer73`, `question8`, `answer81`, `answer82`, `answer83`," +
           " `question9`, `answer91`, `answer92`, `answer93`, `question10`, `answer101`, `answer102`, `answer103`, `disc`)" +
           " VALUES (@name, @question1, @answer1, @answer2, @answer3, @question2, @answer21, @answer22, @answer23, @question3, @answer31, @answer32, @answer33, @question4," +
           " @answer41, @answer42, @answer43, @question5, @answer51, @answer52, @answer53, @question6, @answer61, @answer62, @answer63, @question7, @answer71, @answer72, @answer73," +
           " @question8, @answer81, @answer82, @answer83, @question9, @answer91, @answer92, @answer93, @question10, @answer101, @answer102, @answer103, @disс)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@question1", MySqlDbType.VarChar).Value = q1.Text;
            command.Parameters.Add("@answer1", MySqlDbType.VarChar).Value = q1_1.Text;
            command.Parameters.Add("@answer2", MySqlDbType.VarChar).Value = q1_2.Text;
            command.Parameters.Add("@answer3", MySqlDbType.VarChar).Value = q1_3.Text;

            command.Parameters.Add("@question2", MySqlDbType.VarChar).Value = q2.Text;
            command.Parameters.Add("@answer21", MySqlDbType.VarChar).Value = q2_1.Text;
            command.Parameters.Add("@answer22", MySqlDbType.VarChar).Value = q2_2.Text;
            command.Parameters.Add("@answer23", MySqlDbType.VarChar).Value = q2_3.Text;

            command.Parameters.Add("@question3", MySqlDbType.VarChar).Value = q3.Text;
            command.Parameters.Add("@answer31", MySqlDbType.VarChar).Value = q3_1.Text;
            command.Parameters.Add("@answer32", MySqlDbType.VarChar).Value = q3_2.Text;
            command.Parameters.Add("@answer33", MySqlDbType.VarChar).Value = q3_3.Text;

            command.Parameters.Add("@question4", MySqlDbType.VarChar).Value = q4.Text;
            command.Parameters.Add("@answer41", MySqlDbType.VarChar).Value = q4_1.Text;
            command.Parameters.Add("@answer42", MySqlDbType.VarChar).Value = q4_2.Text;
            command.Parameters.Add("@answer43", MySqlDbType.VarChar).Value = q4_3.Text;

            command.Parameters.Add("@question5", MySqlDbType.VarChar).Value = q5.Text;
            command.Parameters.Add("@answer51", MySqlDbType.VarChar).Value = q5_1.Text;
            command.Parameters.Add("@answer52", MySqlDbType.VarChar).Value = q5_2.Text;
            command.Parameters.Add("@answer53", MySqlDbType.VarChar).Value = q5_3.Text;

            command.Parameters.Add("@question6", MySqlDbType.VarChar).Value = q6.Text;
            command.Parameters.Add("@answer61", MySqlDbType.VarChar).Value = q6_1.Text;
            command.Parameters.Add("@answer62", MySqlDbType.VarChar).Value = q6_2.Text;
            command.Parameters.Add("@answer63", MySqlDbType.VarChar).Value = q6_3.Text;

            command.Parameters.Add("@question7", MySqlDbType.VarChar).Value = q7.Text;
            command.Parameters.Add("@answer71", MySqlDbType.VarChar).Value = q7_1.Text;
            command.Parameters.Add("@answer72", MySqlDbType.VarChar).Value = q7_2.Text;
            command.Parameters.Add("@answer73", MySqlDbType.VarChar).Value = q7_3.Text;

            command.Parameters.Add("@question8", MySqlDbType.VarChar).Value = q8.Text;
            command.Parameters.Add("@answer81", MySqlDbType.VarChar).Value = q8_1.Text;
            command.Parameters.Add("@answer82", MySqlDbType.VarChar).Value = q8_2.Text;
            command.Parameters.Add("@answer83", MySqlDbType.VarChar).Value = q8_3.Text;

            command.Parameters.Add("@question9", MySqlDbType.VarChar).Value = q9.Text;
            command.Parameters.Add("@answer91", MySqlDbType.VarChar).Value = q9_1.Text;
            command.Parameters.Add("@answer92", MySqlDbType.VarChar).Value = q9_2.Text;
            command.Parameters.Add("@answer93", MySqlDbType.VarChar).Value = q9_3.Text;

            command.Parameters.Add("@question10", MySqlDbType.VarChar).Value = q10.Text;
            command.Parameters.Add("@answer101", MySqlDbType.VarChar).Value = q10_1.Text;
            command.Parameters.Add("@answer102", MySqlDbType.VarChar).Value = q10_2.Text;
            command.Parameters.Add("@answer103", MySqlDbType.VarChar).Value = q10_3.Text;

            command.Parameters.Add("@disс", MySqlDbType.VarChar).Value = disc.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тест был создан");
            else
                MessageBox.Show("Тест не был создан");

            db.closeConnection();
        }

        private void AddTest_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow2 mainWindow2 = new MainWindow2();
            mainWindow2.Show();
        }
        public void Enter(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "Введите ответ")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public void Enter1(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "Введите вопрос")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public void Enter2(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "Введите название теста")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public void Leave(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Введите ответ";
                textBox.ForeColor = Color.Gray;
            }
        }
        public void Leave1(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Введите вопрос";
                textBox.ForeColor = Color.Gray;
            }
        }
        public void Leave2(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Введите название теста";
                textBox.ForeColor = Color.Gray;
            }
        }
        public void Leave4(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Введите правильный ответ";
                textBox.ForeColor = Color.Gray;
            }
        }
        public void Enter4(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "Введите правильный ответ")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        private void q1_1_Enter(object sender, EventArgs e)
        {
            Enter4(q1_1);
        }

        private void q1_1_Leave(object sender, EventArgs e)
        {
            Leave4(q1_1);
        }

        private void q1_2_Enter(object sender, EventArgs e)
        {
            Enter(q1_2);
        }

        private void q1_2_Leave(object sender, EventArgs e)
        {
            Leave(q1_2);
        }
        private void q1_3_Enter(object sender, EventArgs e)
        {
            Enter(q1_3);
        }

        private void q1_3_Leave(object sender, EventArgs e)
        {
            Leave(q1_3);
        }

        private void name_Enter(object sender, EventArgs e)
        {
            Enter2(name);
        }

        private void name_Leave(object sender, EventArgs e)
        {
            Leave2(name);
        }

        private void q1_Enter(object sender, EventArgs e)
        {
            Enter1(q1);
        }

        private void q1_Leave(object sender, EventArgs e)
        {
            Leave1(q1);
        }

        private void q2_1_Enter(object sender, EventArgs e)
        {
            Enter4(q2_1);
        }

        private void q2_1_Leave(object sender, EventArgs e)
        {
            Leave4(q2_1);
        }

        private void q2_2_Enter(object sender, EventArgs e)
        {
            Enter(q2_2);
        }

        private void q2_2_Leave(object sender, EventArgs e)
        {
            Leave(q2_2);
        }

        private void q2_3_Enter(object sender, EventArgs e)
        {
            Enter(q2_3);
        }

        private void q2_3_Leave(object sender, EventArgs e)
        {
            Leave(q2_3);
        }

        private void q2_Enter(object sender, EventArgs e)
        {
            Enter1(q2);
        }

        private void q2_Leave(object sender, EventArgs e)
        {
            Leave1(q2);
        }

        private void q3_1_Enter(object sender, EventArgs e)
        {
            Enter4(q3_1);
        }

        private void q3_1_Leave(object sender, EventArgs e)
        {
            Leave4(q3_1);
        }

        private void q3_2_Enter(object sender, EventArgs e)
        {
            Enter(q3_2);
        }

        private void q3_2_Leave(object sender, EventArgs e)
        {
            Leave(q3_2);
        }

        private void q3_3_Enter(object sender, EventArgs e)
        {
            Enter(q3_3);
        }

        private void q3_3_Leave(object sender, EventArgs e)
        {
            Leave(q3_3);
        }

        private void q3_Enter(object sender, EventArgs e)
        {
            Enter1(q3);
        }

        private void q3_Leave(object sender, EventArgs e)
        {
            Leave1(q3);
        }

        private void q4_1_Enter(object sender, EventArgs e)
        {
            Enter4(q4_1);
        }

        private void q4_1_Leave(object sender, EventArgs e)
        {
            Leave4(q4_1);
        }

        private void q4_2_Enter(object sender, EventArgs e)
        {
            Enter(q4_2);
        }

        private void q4_2_Leave(object sender, EventArgs e)
        {
            Leave(q4_2);
        }

        private void q4_3_Enter(object sender, EventArgs e)
        {
            Enter(q4_3);
        }

        private void q4_3_Leave(object sender, EventArgs e)
        {
            Leave(q4_3);
        }

        private void q4_Enter(object sender, EventArgs e)
        {
            Enter1(q4);
        }

        private void q4_Leave(object sender, EventArgs e)
        {
            Leave1(q4);
        }

        private void q5_1_Enter(object sender, EventArgs e)
        {
            Enter4(q5_1);
        }

        private void q5_1_Leave(object sender, EventArgs e)
        {
            Leave4(q5_1);
        }

        private void q5_2_Enter(object sender, EventArgs e)
        {
            Enter(q5_2);
        }

        private void q5_2_Leave(object sender, EventArgs e)
        {
            Leave(q5_2);
        }

        private void q5_3_Enter(object sender, EventArgs e)
        {
            Enter(q5_3);
        }

        private void q5_3_Leave(object sender, EventArgs e)
        {
            Leave(q5_3);
        }

        private void q5_Enter(object sender, EventArgs e)
        {
            Enter1(q5);
        }

        private void q5_Leave(object sender, EventArgs e)
        {
            Leave1(q5);
        }

        private void q6_1_Enter(object sender, EventArgs e)
        {
            Enter4(q6_1);
        }

        private void q6_1_Leave(object sender, EventArgs e)
        {
            Leave4(q6_1);
        }

        private void q6_2_Enter(object sender, EventArgs e)
        {
            Enter(q6_2);
        }

        private void q6_2_Leave(object sender, EventArgs e)
        {
            Leave(q6_2);
        }

        private void q6_3_Enter(object sender, EventArgs e)
        {
            Enter(q6_3);
        }

        private void q6_3_Leave(object sender, EventArgs e)
        {
            Leave(q6_3);
        }

        private void q6_Enter(object sender, EventArgs e)
        {
            Enter1(q6);
        }

        private void q6_Leave(object sender, EventArgs e)
        {
            Leave1(q6);
        }

        private void q7_1_Enter(object sender, EventArgs e)
        {
            Enter4(q7_1);
        }

        private void q7_1_Leave(object sender, EventArgs e)
        {
            Leave4(q7_1);
        }

        private void q7_2_Enter(object sender, EventArgs e)
        {
            Enter(q7_2);
        }

        private void q7_2_Leave(object sender, EventArgs e)
        {
            Leave(q7_2);
        }

        private void q7_3_Enter(object sender, EventArgs e)
        {
            Enter(q7_3);
        }

        private void q7_3_Leave(object sender, EventArgs e)
        {
            Leave(q7_3);
        }

        private void q7_Enter(object sender, EventArgs e)
        {
            Enter1(q7);
        }

        private void q7_Leave(object sender, EventArgs e)
        {
            Leave1(q7);
        }

        private void q8_1_Enter(object sender, EventArgs e)
        {
            Enter4(q8_1);
        }

        private void q8_1_Leave(object sender, EventArgs e)
        {
            Leave4(q8_1);
        }

        private void q8_2_Enter(object sender, EventArgs e)
        {
            Enter(q8_2);
        }

        private void q8_2_Leave(object sender, EventArgs e)
        {
            Leave(q8_2);
        }

        private void q8_3_Enter(object sender, EventArgs e)
        {
            Enter(q8_3);
        }

        private void q8_3_Leave(object sender, EventArgs e)
        {
            Leave(q8_3);
        }

        private void q8_Enter(object sender, EventArgs e)
        {
            Enter1(q8);
        }

        private void q8_Leave(object sender, EventArgs e)
        {
            Leave1(q8);
        }


        private void q9_3_Leave(object sender, EventArgs e)
        {
            Leave(q9_3);
        }

        private void q9_2_Leave(object sender, EventArgs e)
        {
            Leave(q9_2);
        }

        private void q9_1_Leave(object sender, EventArgs e)
        {
            Leave4(q9_1);
        }

        private void q9_Leave(object sender, EventArgs e)
        {
            Leave1(q9);
        }

        private void q9_1_Enter(object sender, EventArgs e)
        {
            Enter4(q9_1);
        }

        private void q9_2_Enter(object sender, EventArgs e)
        {
            Enter(q9_2);
        }

        private void q9_3_Enter(object sender, EventArgs e)
        {
            Enter(q9_3);
        }

        private void q9_Enter(object sender, EventArgs e)
        {
            Enter1(q9);
        }

        private void q10_1_Enter(object sender, EventArgs e)
        {
            Enter4(q10_1);
        }

        private void q10_1_Leave(object sender, EventArgs e)
        {
            Leave4(q10_1);
        }

        private void q10_2_Enter(object sender, EventArgs e)
        {
            Enter(q10_2);
        }

        private void q10_2_Leave(object sender, EventArgs e)
        {
            Leave(q10_2);
        }

        private void q10_3_Enter(object sender, EventArgs e)
        {
            Enter(q10_3);
        }

        private void q10_3_Leave(object sender, EventArgs e)
        {
            Leave(q10_3);
        }

        private void q10_Enter(object sender, EventArgs e)
        {
            Enter1(q10);
        }

        private void q10_Leave(object sender, EventArgs e)
        {
            Leave1(q10);
        }

        private void dis_Enter(object sender, EventArgs e)
        {
            if (disc.Text == "Введите дисциплину")
            {
                disc.Text = "";
                disc.ForeColor = Color.Black;
            }
        }

        private void dis_Leave(object sender, EventArgs e)
        {
            if (disc.Text == "")
            {
                disc.Text = "Введите дисциплину";
                disc.ForeColor = Color.Gray;
            }
        }

        private void q7_TextChanged(object sender, EventArgs e)
        {

        }

        private void q7_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void AddTest_Load_1(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void q3_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void q1_2_TextChanged(object sender, EventArgs e)
        {
        }

        private void q1_3_TextChanged(object sender, EventArgs e)
        {
        }

        private void q2_1_TextChanged(object sender, EventArgs e)
        {
        }

        private void q2_2_TextChanged(object sender, EventArgs e)
        {
        }

        private void q2_3_TextChanged(object sender, EventArgs e)
        {
        }

        private void q3_1_TextChanged(object sender, EventArgs e)
        {
        }

        private void q3_2_TextChanged(object sender, EventArgs e)
        {
        }

        private void q1_1_TextChanged(object sender, EventArgs e)
        {
        }

        private void q4_1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
