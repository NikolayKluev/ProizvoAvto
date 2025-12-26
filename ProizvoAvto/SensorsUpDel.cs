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
using System.Windows.Forms.VisualStyles;

namespace ProizvoAvto
{
    public partial class SensorsUpDel : MetroFramework.Forms.MetroForm
    {
        DB dB = new DB();
        public SensorsUpDel()
        {
            InitializeComponent();            
            LoadComboBox();
        }

        private void SensorsUpDel_Load(object sender, EventArgs e)
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

        public void setTextBoxId(string id)
        {
            this.textBoxId.Text = id;
        }

        public void setComboBoxMachName(string name)
        {
            this.comboBoxMachName.Text = name;
        }

        public void setTextBoxType(string type)
        {
            this.textBoxType.Text = type;
        }

        public void setTextBoxLocation(string location)
        { 
            this.textBoxLocation.Text = location;
        }       

        

        private void buttonUp_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("UPDATE `sensors` SET `machine_id`='"+comboBoxMachName.SelectedValue+"', " +
                "`sensor_type`='"+textBoxType.Text+"',`location`='"+textBoxLocation.Text+"' " +
                " WHERE `id`='"+textBoxId.Text+"'",
                dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("DELETE FROM `sensors` WHERE `id`='"+textBoxId.Text+"'",
                dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }
        
    }
}
