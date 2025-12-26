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
    public partial class InsertSensors : MetroFramework.Forms.MetroForm
    {
        DB dB = new DB();
        public InsertSensors()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void Sensors_Load(object sender, EventArgs e)
        {

        }

        public void LoadComboBox()
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select  * from machines", dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxMachName.DataSource = table;
            comboBoxMachName.DisplayMember = "type";
            comboBoxMachName.ValueMember = "id";            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("INSERT INTO " +
                "`sensors`(`machine_id`, `sensor_type`, `location`) VALUES " +
                "('"+comboBoxMachName.SelectedValue+"','"+textBoxType.Text+"','"+textBoxlocation.Text+"')", dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }
    }
}
