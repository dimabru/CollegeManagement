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
    public partial class professorMenu : Form
    {
        professor prof;
        private List<techingStaffConstraints> prof_constraints_List = new List<techingStaffConstraints>();
        publicChecksAndOperations opration = new publicChecksAndOperations();


        //for page display;
        private static int constraintsPage = 0; 

        public professorMenu(professor prof)
        {
            InitializeComponent();
            //make reperance to the object we get
            this.prof = prof;
            //change this form size 
            //see also: https://msdn.microsoft.com/en-us/library/ms229606(v=vs.110).aspx 
            this.Size = new System.Drawing.Size(950, 450);

            //set position in the center;
            //see also: https://msdn.microsoft.com/en-us/library/system.windows.forms.form.startposition(v=vs.110).aspx
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void professorMenu_Load(object sender, EventArgs e)
        {

        }

        private void manageConstraintsButton(object sender, EventArgs e)
        {
            //more infromation here: https://msdn.microsoft.com/en-us/library/system.windows.forms.tabcontrol.selecttab(v=vs.110).aspx
            //show the constriants tab
            tabControl1.SelectTab(constraintsPage);
        }

        private void watch_your_constraints(object sender, EventArgs e)
        {

            prof_constraints_List = prof.getConstraintsList();

            //learn more about data table here: https://msdn.microsoft.com/en-us/library/system.data.datatable(v=vs.110).aspx
            //and here in the bottom you can find examples for data grid: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagrid(v=vs.110).aspx

            DataTable tempTable = new DataTable();
            tempTable.Columns.Add("start", typeof(string));
            tempTable.Columns.Add("ends", typeof(string));
            tempTable.Columns.Add("day", typeof(string));

            string conv1 = "";
            string conv2 = "";
            string conv3 = "";


            for (int i = 0; i < prof_constraints_List.Count; i++)
            {
                conv1 = opration.hourConvert(prof_constraints_List[i].getStart);
                conv2 = opration.hourConvert(prof_constraints_List[i].getEnds);
                conv3 = opration.dayConvert(prof_constraints_List[i].getEnds);

                tempTable.Rows.Add(conv1,conv2,conv3);
            }
            
            dataGridView1.DataSource = tempTable;
            
        }


        public void clearMyConstraints(object sender, EventArgs e)
        {
            prof.deleteAllConstraints();
        }

        private void addConstraintsButton(object sender, EventArgs e)
        {
            prof.insertConstrints(1, 1, 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
