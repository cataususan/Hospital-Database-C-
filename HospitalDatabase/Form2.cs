using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.medicDataSet.Doctors);

            Form3 LogIn = new Form3();
            if (LogIn.ShowDialog() == DialogResult.OK)
            {

            }
            tableAdapterManager.UpdateAll(medicDataSet);
            doctorsTableAdapter.Fill(medicDataSet.Doctors);

        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(DataRowView drv in doctorsBindingSource.List)
            {
                int id = (int)drv["Id"];
                string pass = (string)drv["Password"];
                if(id==Convert.ToInt32(textBox1.Text) && pass==textBox2.Text)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }

        private void doctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
