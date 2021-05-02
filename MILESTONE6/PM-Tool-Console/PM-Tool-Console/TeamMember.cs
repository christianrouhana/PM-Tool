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

namespace PM_Tool_Console
{
    class TeamMember
    {
        //initialize 
        private string member; 
        private string email;

        public TeamMember(string member = "", string email = "")
        {
            this.member = member;
            this.email = email;
        }

        public string getName()
        {
            return member;
        }

        public string getEmail()
        {
            return email;
        }
        //update name of teamMember
        public void updateName(string new_name)
        {
            member = new_name;
        }

        //update email of teamMember
        public void updateEmail(string new_email)
        {
            email = new_email;
        }

    }

}
