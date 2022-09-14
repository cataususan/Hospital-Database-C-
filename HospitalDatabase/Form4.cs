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
    public partial class Form4 : Form
    {
        public string TextBoxValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableTableAdapter.Insert(Convert.ToInt32(textBox4.Text),textBox1.Text,textBox2.Text,dateTimePicker1.Value,textBox3.Text,richTextBox1.Text);
            tableAdapterManager.UpdateAll(medicDataSet);
            tableTableAdapter.Fill(medicDataSet.Table);
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.medicDataSet.Table);

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicDataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
