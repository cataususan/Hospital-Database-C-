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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.medicDataSet.Table);
            // TODO: This line of code loads data into the 'medicDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.medicDataSet.Pacienti);

            Form2 LogIn = new Form2();
            if (LogIn.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void pacientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 rad = new Form4();

            rad.TextBoxValue = (string)((DataRowView)pacientiBindingSource.Current)["CNP"];
            
            if(rad.ShowDialog()==DialogResult.OK)
            {

            }
            tableAdapterManager.UpdateAll(medicDataSet);
            tableTableAdapter.Fill(medicDataSet.Table);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 pac = new Form5();
           if(pac.ShowDialog()==DialogResult.OK)
            {

            }
            tableAdapterManager.UpdateAll(medicDataSet);
            pacientiTableAdapter.Fill(medicDataSet.Pacienti);
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string img= (string)((DataRowView)tableBindingSource.Current)["Image"];
            // display image in picture box  
            pictureBox1.Image = new Bitmap(img);
           

        }
    }
}
