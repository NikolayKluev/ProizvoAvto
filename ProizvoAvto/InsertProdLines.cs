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
    public partial class InsertProdLines : MetroFramework.Forms.MetroForm
    {
        DB dB = new DB();
        public InsertProdLines()
        {
            InitializeComponent();
        }

        private void ProdLines_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("INSERT INTO `production_lines`(`name`, `description`) VALUES " +
                "('"+textBoxName.Text+"','"+richTextBoxDesc.Text+"')", dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }
    }
}
