using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm_tool
{
    class Schedule
    {
        DateTime date;
        Task taskName;


        void setDate(DateTime newDate)
        {
            date = newDate;
        }


        Task getTask()
        {
            return taskName;
        }

        /*
        // Wondering how the schedule class ended up having a getMember function.
        // The project class is the one to have it, isn't it?
        TeamMember getMember()
        {

        }*/


        // Does update mean updating the Date?
        void updateDate(DateTime newDate)
        {
            date = newDate;

        }
    }
}
