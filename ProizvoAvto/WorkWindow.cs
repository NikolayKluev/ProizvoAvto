using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class WorkWindow : MetroFramework.Forms.MetroForm
    {

        private DB dB = new DB();
        public WorkWindow()
        {
            InitializeComponent();
            refresh();
        }

        private void WorkWindow_Load(object sender, EventArgs e)
        {

        }

        void refresh()
        {

            switch (ProizvoAvto.Properties.Settings.Default.l)
            {
                case 1:
                    {
                        dB.openConnection();
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`, `last_name` as 'Фамилия', " +
                            "`first_name` as 'Имя', `position` as 'Должность', `email`, `phone` as 'Телефон' FROM `employees`",
                            dB.getConnection());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[0].Visible = false;
                        dB.closeConnection();
                        break;
                    }
                case 2:
                    {
                        dB.openConnection();
                        MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT machines.id , " +
                            "production_lines.name as 'Линия производства' , machines.type as 'Тип', " +
                            "machines.manufacturer as 'Производитель' , machines.model as 'Модель', " +
                            "machines.serial_number as 'Серийный номер', machines.install_date as 'Дата установки' FROM " +
                            "`machines`, production_lines WHERE machines.production_lines_id = production_lines.id",
                            dB.getConnection());
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        dataGridView1.DataSource = table1;
                        dataGridView1.Columns[0].Visible = false;
                        dB.closeConnection();
                        break;
                    }
                case 3:
                    {
                        dB.openConnection();
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT `id`, `name` as 'Наименование', " +
                            "`description` as 'Описание' FROM `production_lines`",
                           dB.getConnection());
                        DataTable table2 = new DataTable();
                        adapter2.Fill(table2);
                        dataGridView1.DataSource = table2;
                        dataGridView1.Columns[0].Visible = false;
                        dB.closeConnection();
                        break;
                    }
                case 4:
                    {
                        dB.openConnection();
                        MySqlDataAdapter adapter3 = new MySqlDataAdapter("SELECT sensors.id , machines.type as 'Станок', " +
                            "sensors.sensor_type as 'Тип' , sensors.location as 'Расположение' FROM `sensors`, `machines` " +                            
                            "WHERE sensors.machine_id = machines.id", dB.getConnection());
                        DataTable table3 = new DataTable();
                        adapter3.Fill(table3);
                        dataGridView1.DataSource = table3;
                        dataGridView1.Columns[0].Visible = false;
                        dB.closeConnection();
                        break;
                    }
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            switch (ProizvoAvto.Properties.Settings.Default.l)
            {
                case 1:
                    {
                        InsertEmpl insertEmpl = new InsertEmpl();
                        insertEmpl.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        InsertMachines insertMachines = new InsertMachines();
                        insertMachines.ShowDialog();
                        break;
                    }
                case 3:
                    {
                        InsertProdLines insertProdLines = new InsertProdLines();
                        insertProdLines.ShowDialog();
                        break;
                    }
                case 4:
                    {
                        InsertSensors insertSensors = new InsertSensors();
                        insertSensors.ShowDialog();
                        break;
                    }

            }
            refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    switch (ProizvoAvto.Properties.Settings.Default.l)
                    {
                        case 1:
                            {
                                EmplUpDel emplUpDel = new EmplUpDel();
                                emplUpDel.setTextBoxId(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                                emplUpDel.setTextBoxSecName(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                                emplUpDel.setTextBoxName(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                                emplUpDel.setTextBoxPos(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                                emplUpDel.setTextBoxEmail(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                                emplUpDel.setTextBoxPhone(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                                emplUpDel.ShowDialog();
                                break;
                            }
                        case 2:
                            {
                                MachinesUpDel machinesUpDel = new MachinesUpDel();
                                machinesUpDel.setTextBoxId(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                                machinesUpDel.setComboBoxPLName(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                                machinesUpDel.setTextBoxType(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                                machinesUpDel.setTextBoxManuf(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                                machinesUpDel.setTextBoxModel(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                                machinesUpDel.setTextBoxSerNum(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                                DateTime dateTime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                                machinesUpDel.setDate(dateTime);                                
                                machinesUpDel.ShowDialog();
                                break;
                            }
                        case 3:
                            {
                                ProdLinesUpDel prodLinesUpDel = new ProdLinesUpDel();
                                prodLinesUpDel.setTextBoxId(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                                prodLinesUpDel.setTextBoxName(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                                prodLinesUpDel.setRichTextBoxDesc(dataGridView1.CurrentRow.Cells[2].Value.ToString());                                
                                prodLinesUpDel.ShowDialog();
                                break;
                            }
                        case 4:
                            {
                                SensorsUpDel sensorsUpDel = new SensorsUpDel();
                                sensorsUpDel.setTextBoxId(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                                sensorsUpDel.setComboBoxMachName(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                                sensorsUpDel.setTextBoxType(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                                sensorsUpDel.setTextBoxLocation(dataGridView1.CurrentRow.Cells[3].Value.ToString());                                                             
                                sensorsUpDel.ShowDialog();
                                break;
                            }
                        
                    }
                    refresh();
            }
                catch
                {
                MessageBox.Show("Произошла ошибка" +
                    "", "Errow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            switch (ProizvoAvto.Properties.Settings.Default.l)
            {
                case 1:
                    {
                        dB.openConnection();
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`, `last_name` as 'Фамилия'," + 
                            "`first_name` as 'Имя', `position` as 'Должность', `email`, `phone` as 'Телефон' FROM `employees`" +
                            "WHERE employees.last_name LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "employees.first_name LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "employees.position LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "employees.email LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "employees.phone LIKE '%"+textBoxSearch.Text+"%'", dB.getConnection());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                        dB.closeConnection();
                        break;
                    }

                case 2: 
                    {
                        dB.openConnection();
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT machines.id , " +
                            "production_lines.name as 'Линия производства' , machines.type as 'Тип', " +
                            "machines.manufacturer as 'Производитель' , machines.model as 'Модель', " +
                            "machines.serial_number as 'Серийный номер', machines.install_date as 'Дата установки' FROM " +
                            "`machines`, production_lines WHERE machines.production_lines_id = production_lines.id AND " +
                            "(production_lines.name LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "machines.type LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "machines.manufacturer LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "machines.model LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "machines.serial_number LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "machines.install_date LIKE '%"+textBoxSearch.Text+"%')", dB.getConnection());
                        DataTable table2 = new DataTable();
                        adapter2.Fill(table2);
                        dataGridView1.DataSource = table2;
                        dB.closeConnection();
                        break;
                    }
                case 3:
                    {
                        dB.openConnection();
                        MySqlDataAdapter adapter3 = new MySqlDataAdapter("SELECT `id`, `name` as 'Наименование', " +
                            "`description` as 'Описание' FROM `production_lines` WHERE " +
                            "production_lines.name LIKE '%"+textBoxSearch.Text+"%' OR " +
                            "production_lines.description LIKE '%"+textBoxSearch.Text+"%'", dB.getConnection());
                        DataTable table3 = new DataTable();
                        adapter3.Fill(table3);
                        dataGridView1.DataSource = table3;
                        dB.closeConnection();
                        break;
                    }

                case 4:
                    {
                        dB.openConnection();
                        MySqlDataAdapter adapter4 = new MySqlDataAdapter("SELECT sensors.id , machines.type as 'Станок', " +
                           "sensors.sensor_type as 'Тип' , sensors.location as 'Расположение' FROM `sensors`, `machines` " +
                           "WHERE sensors.machine_id = machines.id AND (machines.type LIKE '%"+textBoxSearch.Text+"%' OR " +
                           "sensors.sensor_type LIKE '%"+textBoxSearch.Text+"%' OR " +
                           "sensors.location LIKE '%"+textBoxSearch.Text+"%')", dB.getConnection());
                        DataTable table4 = new DataTable();
                        adapter4.Fill(table4);
                        dataGridView1.DataSource = table4;                        
                        dB.closeConnection();
                        break;
                    }

            }
        }
    }

}
