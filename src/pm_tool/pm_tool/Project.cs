using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm_tool
{
    class Project
    {
        private string name;
        private string dateCreated;
        private Schedule schedule;
        private List<TeamMember> members;

        public Project(string name = "", string dateCreated = "", Schedule schedule = null, List<TeamMember> members = null)
        {
            this.name = name;
            this.dateCreated = dateCreated;
            this.schedule = schedule;
            this.members = members;
        }

        public void addMember(TeamMember member)
        {
            members.Add(member);
        }

        public void addMember(string member)
        {
            members.Add(new TeamMember(member));
        }

        public void changeName(string name)
        {
            this.name = name; 
        }
        public string getName()
        {
            return name;
        }

        public Schedule getSchedule()
        {
            return schedule;
        }

        public List<TeamMember> getTeam()
        {
            return members
        }
    }
}
