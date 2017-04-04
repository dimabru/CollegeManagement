using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


    namespace Project_Team3.Menus___forms.AssociateSubMenus
{
    public partial class Form_associateDefineNewEvent : Form
    {
        public Form_associateDefineNewEvent()
        {
            InitializeComponent();
        }

        private void Form_associateDefineNewEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_associateMenu parent = (Form_associateMenu) this.Owner;
            parent.Show();
        }

        private void clearNameButton_Click(object sender, EventArgs e)
        {
            eventNameTextBox.Text = "";
        }

        private void clearDescription_Click(object sender, EventArgs e)
        {
            eventDescriptionRichTextBox.Text = "";
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            int startHour = startTimePicker.Value.Hour ,endHour = endTimePicker.Value.Hour;
            string day = dayPickerListBox.Text, eventName = eventNameTextBox.Text, eventDescription = eventNameTextBox.Text;

            DBconnect db = new DBconnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "INSERT into EVENT (EVENT_NAME,CREATOR_ID,EVENT_START,EVENT_END,EVENT_DAY,EVENT_DESCRIPTION) VALUES(@eventName,111,@startHour,@endHour,@day,@eventDescription)";
            cmd.Parameters.AddWithValue("eventName", eventName);
            cmd.Parameters.AddWithValue("startHour", startHour);
            cmd.Parameters.AddWithValue("endHour", endHour);
            cmd.Parameters.AddWithValue("day", day);
            cmd.Parameters.AddWithValue("eventDescription", eventDescription);
            db.OpenConn();
            if (db.ConnStatus()) 
            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
