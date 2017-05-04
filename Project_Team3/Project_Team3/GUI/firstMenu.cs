using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Courses;

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

            secretaryLoginMenu secretaryLoginForm = new secretaryLoginMenu();
            professorLoginMenu professorLoginForm = new professorLoginMenu();
            instructorLoginMenu instructorLoginForm = new instructorLoginMenu();
            adminLoginMenu adminLoginForm = new adminLoginMenu();

            publicChecksAndOperations checkIfUserExit = new publicChecksAndOperations();

            if (comboBox1.Text == "secretary")
            {
                this.Hide();
                secretaryLoginForm.ShowDialog();
                if (!checkIfUserExit.didUserExit())
                {
                    this.Show();
                }
            }

            else if (comboBox1.Text == "professor")
            {
                this.Hide();
                professorLoginForm.ShowDialog();
                if (!checkIfUserExit.didUserExit())
                {
                    this.Show();
                }
            }
            else if (comboBox1.Text == "instructor")
            {
                this.Hide();
                instructorLoginForm.ShowDialog();
                if (!checkIfUserExit.didUserExit())
                {
                    this.Show();
                }
            }
            else if (comboBox1.Text == "Admin")
            {
                this.Hide();
                adminLoginForm.ShowDialog();
                if (!checkIfUserExit.didUserExit())
                {
                    this.Show();
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
