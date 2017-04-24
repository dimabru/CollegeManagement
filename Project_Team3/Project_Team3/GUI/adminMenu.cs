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
    public partial class adminMenu : Form
    {
        admin ad;

        //font size
        //learn more here: https://msdn.microsoft.com/en-us/library/system.drawing.font.size(v=vs.110).aspx
        const float fSize = 12.0F;

        public adminMenu(admin ad)
        {
            InitializeComponent();
            this.ad = ad;


            //change this form size 
            //see also: https://msdn.microsoft.com/en-us/library/ms229606(v=vs.110).aspx 
            this.Size = new System.Drawing.Size(760, 460);

            //set position in the center;
            //see also: https://msdn.microsoft.com/en-us/library/system.windows.forms.form.startposition(v=vs.110).aspx
            this.StartPosition = FormStartPosition.CenterScreen;

            set_account_Management();

            setUserManagement();
        }

        public void setUserManagement()
        {
            numOfSecretaryLabelConst.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            numOfSecretaryLabelDinamic.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);

            numOfSecretaryLabelDinamic.Text = ad.how_many_from_this_type("Secretary").ToString();

        }

        private void set_account_Management()
        {
            //here you can learn how to set fonts: https://msdn.microsoft.com/en-us/library/system.drawing.font.size(v=vs.110).aspx
            nameLable.Text = "name:";
            lastNameLabel.Text = "last name:";

            lNameLable.Text = ad.getUserLastName;
            UnameLable.Text = ad.getUserName;


            lastNameLabel.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            nameLable.Font = new Font(nameLable.Font.Name, fSize, nameLable.Font.Style, nameLable.Font.Unit);
        }

        private void changeMyPassbutton_Click(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text == "" || newPassTextBox.Text == "" || confPassTextBox.Text == "")
            {
                MessageBox.Show("you have to fill all fields");
                return;
            }
            if (newPassTextBox.Text != confPassTextBox.Text)
            {
                MessageBox.Show("Password does not match the confirm password.");
                return;
            }

            
            if (oldPassTextBox.Text == ad.getPassword())
            {
                ad.changePassword(newPassTextBox.Text);
                MessageBox.Show("the password has changed");
                return;
            }
            MessageBox.Show("the old password is not correct");
            return;
        }
    }
}
