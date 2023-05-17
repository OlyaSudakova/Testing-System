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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Testing
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            load("SELECT name FROM test", "name", tests);
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        public void load(string stringQuery, string column, System.Windows.Forms.ComboBox tests)
        {
            List<string> items = GetColumnValues(stringQuery, column);
            if (items.Count() > 0)
            {
                tests.Items.AddRange(GetColumnValues(stringQuery, column).ToArray());

            }
            else
            {

                tests.Items.Add("Тестов нет");
            }
        }
        public List<string> GetColumnValues(string query, string columnName)
        {
            List<string> columnValues = new List<string>();

            MySqlConnection myCon = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=test");
            myCon.Open();
            using (MySqlCommand command = new MySqlCommand(query, myCon))
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object columnValueObject = reader.GetValue(reader.GetOrdinal(columnName));
                    string columnValue = columnValueObject != DBNull.Value ? columnValueObject.ToString() : "";
                    columnValues.Add(columnValue);
                }
            }
            return columnValues;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = tests.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Тест не выбран");
            }
            /*else if (tests.Items[index].ToString() != "name")
            {
                MessageBox.Show("бубубу");
            }*/
            else
            {
                this.Hide();
                Test form = new Test();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        /*public string ComboSelectedItem
{
   get
   {
       if (tests == null || tests.SelectedItem == null)
           return null;

       return tests.SelectedItem as string;
   }
}*/

    }
}
