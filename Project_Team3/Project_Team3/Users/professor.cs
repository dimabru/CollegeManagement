using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3
{
    //it's important that the all users be public
    public class professor : user
    {
        private List<techingStaffConstraints> profconstraints = new List<techingStaffConstraints>();
        private List<string> profcourses = new List<string>();
        /// <summary>
        /// use this object to communicate with database;
        /// </summary>
        dataBaseOperations dbo = new dataBaseOperations();

        /// <summary>
        /// return constraint by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public techingStaffConstraints getConstraintByIndex(int index)
        {
            //arry and list are different
            //lern more about list size here: https://msdn.microsoft.com/en-us/library/27b47ht3(v=vs.110).aspx
            if (index >= 0 && index <= profconstraints.Count)
            {
                return profconstraints[index];
            }
            return null;
        }
        
        /// <summary>
        /// return List of constraints
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<techingStaffConstraints> getConstraintsList()
        {
            return profconstraints;
        }
        /// <summary>
        /// return list of courses
        /// </summary>
        /// <returns></returns>
        public List<string> getCoursesList()
        {
            return profcourses;
        }
        /// <summary>
        /// this constructor set the id and update the user filds from the data base;
        /// </summary>
        /// <param name="id"></param>
        public professor(ulong id) : base(id)
        {
            int[] toSaveConstraints = dbo.getConstraints(this.getid());
            string[] toSaveCourses = dbo.getCoursesByTId(this.getid());
            try
            {
                for (int i = 4; i <= toSaveConstraints.Length; i += 4)
                {
                    profconstraints.Add(new techingStaffConstraints(toSaveConstraints[i - 3], toSaveConstraints[i - 2], toSaveConstraints[i - 1]));
                }

                for (int i=0;i<toSaveCourses.Length;i++)
                {
                    profcourses.Add(toSaveCourses[i]);
                }
            }
            catch
            {
                MessageBox.Show("there was a problem with loading professor\n please check it with your admin");
            }
        }

        /// <summary>
        /// delete all prof constrints from calss and from database;
        /// </summary>
        public void deleteAllConstraints()
        {
            profconstraints.Clear();
            dbo.deleteConstrints(this.getid());
        }

        /// <summary>
        /// insert constaraints to this prof;
        /// </summary>
        /// <param name="start"></param>
        /// <param name="ends"></param>
        /// <param name="day"> send the day in int 1 for Sunday and etc...</param>
        /// <returns></returns>
        public Boolean insertConstrints(int start, int ends, int day)
        {
            profconstraints.Add(new techingStaffConstraints(start, ends, day));
            dbo.setConstraints(this.getid(), start, ends, day);
            return true;
        }
    }
}
