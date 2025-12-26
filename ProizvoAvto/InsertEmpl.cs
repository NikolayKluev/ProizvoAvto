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
    public partial class InsertEmpl : MetroFramework.Forms.MetroForm
    {

        DB dB = new DB();
        public InsertEmpl()
        {
            InitializeComponent();
        }

        private void InsertEmpl_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("INSERT INTO `employees`" +
                "(`first_name`, `last_name`, `position`, `email`, `phone`) VALUES ('"+textBoxName.Text+"'," +
                "'"+textBoxSecName.Text+"','"+textBoxPosition.Text+"','"+textBoxEmail.Text+"','"+textBoxPhone.Text+"')", dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }
    }
}
