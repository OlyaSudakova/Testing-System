using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Xml.Linq;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click_1(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (password.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            String loginUser = login.Text;
            String passUser = password.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB2 db2 = new DB2();
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `teacher` WHERE `login` = @uL AND `pass` = @uP", db2.getConnection1());
            command2.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command2.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command2;
            adapter.Fill(table2);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else if (table2.Rows.Count > 0)
            {
                this.Hide();
                MainWindow2 mainWindow2 = new MainWindow2();
                mainWindow2.Show();
            }
            else
            {
                MessageBox.Show("Пользователя не существует");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm2 registerForm2 = new RegisterForm2();
            registerForm2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
                password.UseSystemPasswordChar = true;
        }
    }
}