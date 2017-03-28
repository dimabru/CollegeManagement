using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3
{
    public partial class firstMenu : Form
    {
        public firstMenu()
        {
            InitializeComponent();
        }

        private void firstMenu_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("team: 3\nyear 2\nsoftware engineering\n\ndolev ben aharon\nelon avisror\ndima brusilovski\nreut shukron ", "software project managing");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secretaryFirstMenu secForm = new secretaryFirstMenu();
            if      (comboBox1.Text == "secretary")  { secForm.ShowDialog(); }
            else if (comboBox1.Text == "professor")  { }
            else if (comboBox1.Text == "instructor") { }
            else if (comboBox1.Text == "Admin")      { }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
