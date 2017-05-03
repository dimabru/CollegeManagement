using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.GUI
{
    public partial class secretaryMenu : Form
    {
        public secretaryMenu(secretary sec)
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(760, 460);


        }

        string changedBoxProf;
        string changedBoxInst;

        private void checkConstraintStatus(object sender, EventArgs e)
        {
            bool statusProf = true, statusInst = true;
            //statusProf = getConstraintStatusProf();
            //statusInst = getConstraintStatusInst();
            MessageBox.Show("Professor: " + statusProf + "\nInstructor: " + statusInst + "\n");
        }

        private void changeConstraintStatus(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxProf = comboBox1.Text;
        }

        private void ApplyProf(object sender, EventArgs e)
        {
            if (changedBoxProf == null) MessageBox.Show("Must select value first");
            else
            {
                //if (changedBoxProf == "Open") setConstraintStatusProf(true);
                //else setConstraintStatusProf(false);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxInst = comboBox2.Text;
        }

        private void ApplyInst(object sender, EventArgs e)
        {
            if (changedBoxInst == null) MessageBox.Show("Must select value first");
            else
            {
                //if (changedBoxInst == "Open") setConstraintStatusInst(true);
                //else setConstraintStatusInst(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
