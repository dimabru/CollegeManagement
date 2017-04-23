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
            this.Size = new System.Drawing.Size(760, 460);

            //set position in the center;
            //see also: https://msdn.microsoft.com/en-us/library/system.windows.forms.form.startposition(v=vs.110).aspx
            this.StartPosition = FormStartPosition.CenterScreen;

            //set the item in the combo boxes
            setComboBoxes();


        }

        private void professorMenu_Load(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// initialize all comboBox items
        /// </summary>
        private void setComboBoxes()
        {
            //learn more form here https://social.msdn.microsoft.com/Forums/windows/en-US/c7a82a6a-763e-424b-84e0-496caa9cfb4d/how-add-a-item-to-combobox?forum=winforms
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
            comboBox1.Items.Add("Wednesday");
            comboBox1.Items.Add("Thursday");
            comboBox1.Items.Add("Friday");
            comboBox1.Items.Add("Saturday");

            comboBox2.Items.Add("00:00");
            comboBox2.Items.Add("01:00");
            comboBox2.Items.Add("02:00");
            comboBox2.Items.Add("03:00");
            comboBox2.Items.Add("04:00");
            comboBox2.Items.Add("05:00");
            comboBox2.Items.Add("06:00");
            comboBox2.Items.Add("07:00");
            comboBox2.Items.Add("08:00");
            comboBox2.Items.Add("09:00");
            comboBox2.Items.Add("10:00");
            comboBox2.Items.Add("11:00");
            comboBox2.Items.Add("12:00");
            comboBox2.Items.Add("13:00");
            comboBox2.Items.Add("14:00");
            comboBox2.Items.Add("15:00");
            comboBox2.Items.Add("16:00");
            comboBox2.Items.Add("17:00");
            comboBox2.Items.Add("18:00");
            comboBox2.Items.Add("19:00");
            comboBox2.Items.Add("20:00");
            comboBox2.Items.Add("21:00");
            comboBox2.Items.Add("22:00");
            comboBox2.Items.Add("23:00");

            comboBox3.Items.Add("00:00");
            comboBox3.Items.Add("01:00");
            comboBox3.Items.Add("02:00");
            comboBox3.Items.Add("03:00");
            comboBox3.Items.Add("04:00");
            comboBox3.Items.Add("05:00");
            comboBox3.Items.Add("06:00");
            comboBox3.Items.Add("07:00");
            comboBox3.Items.Add("08:00");
            comboBox3.Items.Add("09:00");
            comboBox3.Items.Add("10:00");
            comboBox3.Items.Add("11:00");
            comboBox3.Items.Add("12:00");
            comboBox3.Items.Add("13:00");
            comboBox3.Items.Add("14:00");
            comboBox3.Items.Add("15:00");
            comboBox3.Items.Add("16:00");
            comboBox3.Items.Add("17:00");
            comboBox3.Items.Add("18:00");
            comboBox3.Items.Add("19:00");
            comboBox3.Items.Add("20:00");
            comboBox3.Items.Add("21:00");
            comboBox3.Items.Add("22:00");
            comboBox3.Items.Add("23:00");
        }
    }
}
