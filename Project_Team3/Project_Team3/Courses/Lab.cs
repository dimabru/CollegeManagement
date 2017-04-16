using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Courses
{
    class Lab
    {

        private ScheduledClass sched;
        private bool mandatoryPresence;

        public Lab(ScheduledClass s, bool mand)
        {
            sched = s;
            mandatoryPresence = mand;
        }

        public Lab(Lab lect)
        {
            sched = lect.sched;
            mandatoryPresence = lect.mandatoryPresence;
        }
        public ScheduledClass getSched() { return sched; }
        public bool getMandatoryPresence() { return mandatoryPresence; }

        public void setSched(ScheduledClass s) { sched = s; }

        public void setMandatoryPresence(bool mand) { mandatoryPresence = mand; }
    }
}
