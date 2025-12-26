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
    public partial class ProdLinesUpDel : MetroFramework.Forms.MetroForm
    {
        DB dB = new DB();

        public ProdLinesUpDel()
        {
            InitializeComponent();
        }

        private void ProdLinesUpDel_Load(object sender, EventArgs e)
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

        public void setRichTextBoxDesc(string text)
        {
            this.richTextBoxDesc.Text = text;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("UPDATE `production_lines` SET `name`='"+textBoxName.Text+"'," +
                "`description`='"+richTextBoxDesc.Text+"' WHERE `id`='"+textBoxId.Text+"'",
                dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("DELETE FROM `production_lines` WHERE `id`='"+textBoxId.Text+"'",
                dB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dB.closeConnection();
            Close();
        }
    }
}
