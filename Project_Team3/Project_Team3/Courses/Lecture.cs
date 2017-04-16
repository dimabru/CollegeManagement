using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Courses
{
    class Lecture
    {

        private ScheduledClass sched;
        private bool mandatoryPresence;

        public Lecture(ScheduledClass s, bool mand)
        {
            sched = s;
            mandatoryPresence = mand;
        }

        public Lecture(Lecture lect)
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
