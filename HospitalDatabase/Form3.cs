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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctorsTableAdapter.Insert(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
            tableAdapterManager.UpdateAll(medicDataSet);
            doctorsTableAdapter.Fill(medicDataSet.Doctors);
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.medicDataSet.Doctors);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
