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
    public partial class MachinesUpDel : MetroFramework.Forms.MetroForm
    {
        DB dB = new DB();
        public MachinesUpDel()
        {
            InitializeComponent();
            LoadComboBox();
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

        private void MachinesUpDel_Load(object sender, EventArgs e)
        {

        }

        public void setTextBoxId(string id)
        {
            this.textBoxId.Text = id;
        }

        public void setComboBoxPLName(string plName)
        {
            this.comboBoxPLName.Text = plName;
        }

        public void setTextBoxType(string type)
        {
            this.textBoxType.Text = type;
        }

        public void setTextBoxManuf(string manuf)
        {
            this.textBoxManuf.Text = manuf;
        }

        public void setTextBoxModel(string model)
        {
            this.textBoxModel.Text = model;
        }


        public void setTextBoxSerNum(string serNum)
        {
            this.textBoxSerNum.Text = serNum;
        }

        public void setDate(DateTime date)
        {
            this.dateTimePicker1.Value = date;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("UPDATE `machines` SET " +
                "`production_lines_id`='"+comboBoxPLName.SelectedValue+"',`type`='"+textBoxType.Text+"'," +
                "`manufacturer`='"+textBoxManuf.Text+"',`model`='"+textBoxModel.Text+"'," +
                "`serial_number`='"+textBoxSerNum.Text+"',`install_date`='"+dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm")+"' " +
                "WHERE `id`='"+textBoxId.Text+"'",
                dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("DELETE FROM `machines` WHERE `id`='"+textBoxId.Text+"'",
                dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }
    }
}
