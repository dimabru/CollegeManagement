using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.StudentSubMenus
{
    public partial class Form_studentWatchEvents : Form
    {
        DBconnect connection;
        SqlCommand command;
        private string username;
        public Form_studentWatchEvents(string un)
        {
            username = un;
            InitializeComponent();
            Init();
            UpdateGrid();
        }
        private void Init()
        {
            connection = new DBconnect();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();
            command.CommandText = "SELECT * FROM Event";
        }

        private void UpdateGrid()
        {
            try
            {
                DataSet ds = connection.generalCommand(command);
                if (ds.Tables.Count > 0)
                {
                    EventsGridView.AutoGenerateColumns = true;
                    EventsGridView.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Record Found");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_studentWatchEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_studentMenu parent = (Form_studentMenu)this.Owner;
            parent.Show();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            int event_id = getEventRowID();
            if (event_id == 0)
                MessageBox.Show("No event selected");
            else
            {
                /*trying to add the event if it's not already signed up*/
                command.Parameters.Clear();
                command.CommandText = "SELECT COUNT(*) from StudentsEvents WHERE Student_UN = @username and Event_ID =  @event";
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("event", event_id);
                if (connection.ConnStatus() == false)
                    connection.OpenConn();
                int ResultCount = (int)command.ExecuteScalar();
                if (ResultCount == 0)
                {
                    command.CommandText = "INSERT into StudentsEvents values(@username, @event)";
                    try
                    {
                        if (connection.ConnStatus() == false)
                            connection.OpenConn();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Event Added.\n");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Already registered to this event!\n");
            }
        }
        private int getEventRowID()
        {
            if (EventsGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = EventsGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = EventsGridView.Rows[selectedrowindex];
                return Convert.ToInt32(selectedRow.Cells["EVENT_ID"].Value);
            }
            else
                return 0;
        }

        private void RemoveEventButton_Click(object sender, EventArgs e)
        {
            int event_id = getEventRowID();
            if (event_id == 0)
                MessageBox.Show("No event selected");
            else
            {
                /*trying to remove the event if it's not already signed up*/
                command.Parameters.Clear();
                command.CommandText = "SELECT COUNT(*) from StudentsEvents WHERE Student_UN = @username and Event_ID =  @event";
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("event", event_id);
                if (connection.ConnStatus() == false)
                    connection.OpenConn();
                int ResultCount = (int)command.ExecuteScalar();
                if (ResultCount > 0)
                {
                    command.CommandText = "DELETE FROM StudentsEvents WHERE Student_UN = @username and Event_ID =  @event";
                    try
                    {
                        if (connection.ConnStatus() == false)
                            connection.OpenConn();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Event Deleted.\n");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Not registered to this event!\n");
            }
        }

        private void EventsGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EventsGridView.ClearSelection();
        }
    }
}
