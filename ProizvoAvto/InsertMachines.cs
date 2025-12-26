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
    public partial class InsertMachines : MetroFramework.Forms.MetroForm
    {
        DB dB = new DB();
        public InsertMachines()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void InsertMachines_Load(object sender, EventArgs e)
        {

        }

        public void LoadComboBox()
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select  * from production_lines", dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxPLName.DataSource = table;
            comboBoxPLName.DisplayMember = "name";
            comboBoxPLName.ValueMember = "id";           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("INSERT INTO `machines`(`production_lines_id`, `type`, " +
                "`manufacturer`, `model`, `serial_number`, `install_date`) VALUES ('"+comboBoxPLName.SelectedValue+"'," +
                "'"+textBoxType.Text+"','"+textBoxManuf.Text+"','"+textBoxModel.Text+"','"+textBoxSerNum.Text+"'," +
                "'"+dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm")+"')", dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }
    }
}
