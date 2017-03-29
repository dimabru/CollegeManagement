using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //TEMP: Uncomment Relevant form to check your form works  [Jonathan Leon @29.3.17]
            //Application.Run(new Form1());
            Application.Run(new Form_secretaryMenu());
            //Application.Run(new Form_studentAssociationMenu());
            //Application.Run(new Form_studentMenu());
            //Application.Run(new Form_studentRequestMenu());
        }
    }
}
