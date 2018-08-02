using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importDBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.importDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.importDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'importDBDataSet.ImportDB' table. You can move, or remove it, as needed.
            this.importDBTableAdapter.Fill(this.importDBDataSet.ImportDB);
            dateTextBox.Text = DateTime.Now.Date.ToShortDateString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sunRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            weatherPictureBox.Image = weatherImageList.Images[0];
        }

        private void rainRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            weatherPictureBox.Image = weatherImageList.Images[1];
        }

        private void snowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            weatherPictureBox.Image = weatherImageList.Images[2];

        }

        private void loadAgendaButton_Click(object sender, EventArgs e)
        {
            String weather = null;
            if (sunRadioButton.Checked)
            {
                weather = "sun";
            }
            if(rainRadioButton.Checked)
                {
                weather = "rain";
                }
            if(snowRadioButton.Checked)
            {
                weather = "snow";
            }
            this.importDBTableAdapter.importCriteria(this.importDBDataSet.ImportDB, weather, dateTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'importDBDataSet.ImportDB' table. You can move, or remove it, as needed.
            this.importDBTableAdapter.Fill(this.importDBDataSet.ImportDB);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
