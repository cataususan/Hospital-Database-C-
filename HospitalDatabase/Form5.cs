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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pacientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.medicDataSet.Pacienti);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pacientiTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text);
            tableAdapterManager.UpdateAll(medicDataSet);
            pacientiTableAdapter.Fill(medicDataSet.Pacienti);
            this.DialogResult = DialogResult.OK;
            this.Hide();

        }
    }
}
