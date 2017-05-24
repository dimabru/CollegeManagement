using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using Facebook.MiniJSON;
using System.Windows.Forms;

namespace Project_Team3
{
    class GetTheMail
    {
        private const string AppId = "239010066477815";
        private const string ExtendedPermissions = "public_profile,user_friends,email";
        private string _accessToken;
        FacebookClient fbClient = new FacebookClient();
        Analyze fbAnalyze;
        protected FacebookClient _fb;

        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    fbAnalyze = new Analyze(fb);
                    _fb = fb;
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }

        public void logout()
        {
            try
            {
                var webBrowser = new WebBrowser();
                var fb = new FacebookClient();
                var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
                webBrowser.Navigate(logouUrl);
                fbAnalyze.Close();
            }
            catch
            {

            }
        }

        public string getMail()
        {

            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);

            try
            {
                var result = _fb.Get("me", new { fields = new[] { "first_name", "last_name", "name", "gender", "id", "age_range" } });
   
            
            var cl = _fb;
            dynamic result1 = _fb.Get("me?fields=id,name,email");
            return result1.email;
            }
            catch (Exception e)
            {
                return "there was a problem";
            }
        }
    }
}
