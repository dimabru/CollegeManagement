using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3
{
    public class instructor : user
    {
        private List<techingStaffConstraints> instrconstraints = new List<techingStaffConstraints>();

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
            if (index >= 0 && index <= instrconstraints.Count)
            {
                return instrconstraints[index];
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
            return instrconstraints;
        }

        /// <summary>
        /// this constructor set the id and update the user filds from the data base;
        /// </summary>
        /// <param name="id"></param>
        public instructor(ulong id) : base(id)
        {
            int[] toSaveConstraints = dbo.getConstraints(this.getid());
            try
            {
                for (int i = 4; i <= toSaveConstraints.Length; i += 4)
                {
                    instrconstraints.Add(new techingStaffConstraints(toSaveConstraints[i - 3], toSaveConstraints[i - 2], toSaveConstraints[i - 1]));
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
            instrconstraints.Clear();
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
            instrconstraints.Add(new techingStaffConstraints(start, ends, day));
            dbo.setConstraints(this.getid(), start, ends, day);
            return true;
        }

    }
}
