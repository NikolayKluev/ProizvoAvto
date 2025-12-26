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

namespace ProizvoAvto
{
    public partial class FormAuth : MetroFramework.Forms.MetroForm
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            String login = textBoxLogin.Text;
            if (login.ToLower().Trim().Equals("login"))
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            String login = textBoxLogin.Text;
            if (login.ToLower().Trim().Equals("login") || login.Trim().Equals(""))
            {
                textBoxLogin.Text = "Login";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            String login = textBoxLogin.Text;
            String password = textBoxPassword.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM admins WHERE login = @log and password = @pass", dB.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                Menu mainForm = new Menu();
                mainForm.Show();
            }
            else MessageBox.Show("Непрвильный логин или пароль", "Errow", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
