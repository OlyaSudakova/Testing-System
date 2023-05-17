using MySql.Data.MySqlClient;
using System.Data;

namespace Testing
{
    public partial class RegisterForm2 : Form
    {
        public RegisterForm2()
        {
            InitializeComponent();

            name.Text = "Введите имя";
            name.ForeColor = Color.Gray;
            surname.Text = "Введите фамилию";
            surname.ForeColor = Color.Gray;
            dis.Text = "Введите дисциплину";
            dis.ForeColor = Color.Gray;
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя" || name.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (surname.Text == "Введите фамилию" || surname.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (dis.Text == "")
            {
                MessageBox.Show("Введите дисциплину");
                return;
            }
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
            if (isTeacherExist())
                return;
            DB2 db1 = new DB2();


            MySqlCommand command = new MySqlCommand("INSERT INTO `teacher` (`login`, `pass`, `name`, `surname`, `dis`) VALUES (@login, @pass, @name, @surname, @dis)", db1.getConnection1());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@dis", MySqlDbType.VarChar).Value = dis.Text;

            db1.openConnection1();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db1.closeConnection1();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void name_Enter_1(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя")
            {
                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Введите имя";
                name.ForeColor = Color.Gray;
            }
        }

        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.Text == "Введите фамилию")
            {
                surname.Text = "";
                surname.ForeColor = Color.Black;
            }
        }

        private void surname_Leave_1(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "Введите фамилию";
                surname.ForeColor = Color.Gray;
            }
        }

        private void dis_Enter_1(object sender, EventArgs e)
        {
            if (dis.Text == "Введите дисциплину")
            {
                dis.Text = "";
                dis.ForeColor = Color.Black;
            }
        }

        private void dis_Leave_1(object sender, EventArgs e)
        {
            if (dis.Text == "")
            {
                dis.Text = "Введите дисциплину";
                dis.ForeColor = Color.Gray;
            }

        }
        public Boolean isTeacherExist()
        {
            DB2 db = new DB2();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `teacher` WHERE `login` = @uL", db.getConnection1());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
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
