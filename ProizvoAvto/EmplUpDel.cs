using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using Word = Microsoft.Office.Interop.Word;
using LibreOfficeLibrary;
using DataTable = System.Data.DataTable;


namespace ProizvoAvto
{
    public partial class EmplUpDel : MetroFramework.Forms.MetroForm
    {
        private DB dB = new DB();        

        public EmplUpDel()
        {
            InitializeComponent();
        }

        private void EmplUpDel_Load(object sender, EventArgs e)
        {

        }

        public void setTextBoxId(string id) 
        {
            this.textBoxId.Text = id;
        }

        public void setTextBoxName(string name) 
        {
            this.textBoxName.Text = name;
        }

        public void setTextBoxSecName(string name)
        {
            this.textBoxSecName.Text = name;
        }

        public void setTextBoxPos(string pos)
        {
            this.textBoxPos.Text = pos;
        }

        public void setTextBoxEmail(string email)
        { 
            this.textBoxEmail.Text = email; 
        }

        public void setTextBoxPhone(string phone) 
        { 
            this.textBoxPhone.Text = phone; 
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("UPDATE `employees` SET `first_name`='"+textBoxName.Text+"'," +
                "`last_name`='"+textBoxSecName.Text+"',`position`='"+textBoxPos.Text+"'," +
                "`email`='"+textBoxEmail.Text+"',`phone`='"+textBoxPhone.Text+"' WHERE `id`='"+textBoxId.Text+"'",
                dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("DELETE FROM `employees` WHERE `id`='"+textBoxId.Text+"'",
                dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }      


    }
}
