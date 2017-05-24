﻿using System;
using System.Windows.Forms;
using Facebook;

namespace Project_Team3
{
    public partial class FB_Analyze : Form
    {
        private const string AppId = "239010066477815";
        private const string ExtendedPermissions= "public_profile,user_friends,email";
        private string _accessToken;
        //private Uri loginUrl;
        FacebookClient fbClient = new FacebookClient();
        //private bool _authorized;
        //private string _currentName;
        //private string _currentEmail;
        Analyze fbAnalyze;

        public FB_Analyze()
        {
            InitializeComponent();
        }

        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    fbAnalyze = new Analyze(fb);
                    fbAnalyze.Show();

                    btnLogout.Visible = true;
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var webBrowser = new WebBrowser();
            var fb = new FacebookClient();
            var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            webBrowser.Navigate(logouUrl);
            fbAnalyze.Close();
            btnLogout.Visible = false;
        }

    }
}
