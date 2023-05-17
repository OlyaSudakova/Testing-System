using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            name.Text = "Введите имя";
            name.ForeColor = Color.Gray;
            surname.Text = "Введите фамилию";
            surname.ForeColor = Color.Gray;
            number.Text = "Введите номер группы";
            number.ForeColor = Color.Gray;
        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == '\b');

        }

        private void enter_Click(object sender, EventArgs e)
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
            if (number.Text == "")
            {
                MessageBox.Show("Введите номер группы");
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
            if (isUserExist())
                return;
            DB db = new DB();


            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`, `number`) VALUES (@login, @pass, @name, @surname, @number)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@number", MySqlDbType.Int64).Value = number.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void name_Enter(object sender, EventArgs e)
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

        private void surname_Leave(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "Введите фамилию";
                surname.ForeColor = Color.Gray;
            }
        }

        private void number_Enter(object sender, EventArgs e)
        {
            if (number.Text == "Введите номер группы")
            {
                number.Text = "";
                number.ForeColor = Color.Black;
            }
        }

        private void number_Leave(object sender, EventArgs e)
        {
            if (number.Text == "")
            {
                number.Text = "Введите номер группы";
                number.ForeColor = Color.Gray;
            }

        }
        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            number.MaxLength = 8;
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
