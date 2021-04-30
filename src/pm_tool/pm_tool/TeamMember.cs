/**
 * This is the part done by Daniel Lee XD
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Personal note on this project - ignore it
 * contorl + k + c to comment(after type comment), control + shift + / to /**
 */

namespace pm_tool
{
    class TeamMember
    {
        //initialize 
        public string member; 
        public string email;
        public Dictionary<string, Task> workedAssigned = new Dictionary<string, Task>();


        //update name of teamMember
        public void update_name(string new_name)
        {
            member = new_name;
        }

        //update email of teamMember
        public void update_email(string new_email)
        {
            email = new_email;
        }

        // assign task
        public void add_task(string role, Task new_task)
        {
            workedAssigned.Add(role, new_task);
        }

        // remove task
        public void remove_task(string role)
        {
            workedAssigned.Remove(role);
        }

    }

}
