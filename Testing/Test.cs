using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Testing
{
    public partial class Test : Form
    {
        /* MainWindow form = null;
             public Test(MainWindow main)
             {
                 form = main;
             }
         public void DoSomethingUsingComboItemValueFromForm1()
         {
             BD3 db = new BD3();
             MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=test");
             string cmdString = "SELECT name, question1, answer1, answer2, answer3, question2, answer21, answer22, answer23, question3, answer31, answer32, answer33, question4, answer41, answer42, answer43, question5, answer51, answer52, answer53, question6, answer61, answer62, answer63, question7, answer71, answer72, answer73, question8, answer81, answer82, answer83, question9, answer91, answer92, answer93, question10, answer101, answer102, answer103 FROM test";
             MySqlCommand cmd = new MySqlCommand(cmdString, connection);
             connection.Open();
         string comboSelectedValueOnForm1 = form.ComboSelectedItem;
             if (comboSelectedValueOnForm1 == "name")
             {

             }
     }*/
        public Test()
        {
            InitializeComponent();

            BD3 db = new BD3();
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=test");
            string cmdString = "SELECT name, question1, answer1, answer2, answer3, question2, answer21, answer22, answer23, question3, answer31, answer32, answer33," +
                " question4, answer41, answer42, answer43, question5, answer51, answer52, answer53, question6, answer61, answer62, answer63, " +
                "question7, answer71, answer72, answer73, question8, answer81, answer82, answer83, question9, answer91, answer92, answer93, " +
                "question10, answer101, answer102, answer103 FROM test WHERE `name` = \"Сложный выбор\"";
            MySqlCommand cmd = new MySqlCommand(cmdString, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            label1.Text = reader["name"].ToString();
            ans1_1.Text = reader["answer1"].ToString();
            ans1_2.Text = reader["answer2"].ToString();
            ans1_3.Text = reader["answer3"].ToString();
            q1.Text = reader["question1"].ToString();
            q2.Text = reader["question2"].ToString();
            q3.Text = reader["question3"].ToString();
            q4.Text = reader["question4"].ToString();
            q5.Text = reader["question5"].ToString();
            q6.Text = reader["question6"].ToString();
            q7.Text = reader["question7"].ToString();
            q8.Text = reader["question8"].ToString();
            q9.Text = reader["question9"].ToString();
            q10.Text = reader["question10"].ToString();
            ans2_1.Text = reader["answer21"].ToString();
            ans2_2.Text = reader["answer22"].ToString();
            ans2_3.Text = reader["answer23"].ToString();
            ans3_1.Text = reader["answer31"].ToString();
            ans3_2.Text = reader["answer32"].ToString();
            ans3_3.Text = reader["answer33"].ToString();
            ans4_1.Text = reader["answer41"].ToString();
            ans4_2.Text = reader["answer42"].ToString();
            ans4_3.Text = reader["answer43"].ToString();
            ans5_1.Text = reader["answer51"].ToString();
            ans5_2.Text = reader["answer52"].ToString();
            ans5_3.Text = reader["answer53"].ToString();
            ans6_1.Text = reader["answer61"].ToString();
            ans6_2.Text = reader["answer62"].ToString();
            ans6_3.Text = reader["answer63"].ToString();
            ans7_1.Text = reader["answer71"].ToString();
            ans7_2.Text = reader["answer72"].ToString();
            ans7_3.Text = reader["answer73"].ToString();
            ans8_1.Text = reader["answer81"].ToString();
            ans8_2.Text = reader["answer82"].ToString();
            ans8_3.Text = reader["answer83"].ToString();
            ans9_1.Text = reader["answer91"].ToString();
            ans9_2.Text = reader["answer92"].ToString();
            ans9_3.Text = reader["answer93"].ToString();
            ans10_1.Text = reader["answer101"].ToString();
            ans10_2.Text = reader["answer102"].ToString();
            ans10_3.Text = reader["answer103"].ToString();
            connection.Close();
        }
        /*public void Change(string cmdString)
        {
            BD3 db = new BD3();
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=test");
            cmdString = "SELECT name FROM test";
            MySqlCommand cmd = new MySqlCommand(cmdString, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            label1.Text = reader["name"].ToString();

            connection.Close();
        }*/

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow form = new MainWindow();
            form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void q1_Click(object sender, EventArgs e)
        {

        }

        private void ans6_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ans6_2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void q6_Click(object sender, EventArgs e)
        {
        }

        private void ans6_3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
