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
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public static int l;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProizvoAvto.Properties.Settings.Default.l = 1;
            WorkWindow workWindow = new WorkWindow();
            workWindow.Owner = this;
            workWindow.Show();
        }

        private void станкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProizvoAvto.Properties.Settings.Default.l = 2;
            WorkWindow workWindow = new WorkWindow();
            workWindow.Owner = this;
            workWindow.Show();
        }

        private void производственныеЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProizvoAvto.Properties.Settings.Default.l = 3;
            WorkWindow workWindow = new WorkWindow();
            workWindow.Owner = this;
            workWindow.Show();
        }

        private void датчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProizvoAvto.Properties.Settings.Default.l = 4;
            WorkWindow workWindow = new WorkWindow();
            workWindow.Owner = this;
            workWindow.Show();
        }
    }
}
