using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Christian Rouhana
// PM-Tool Group

namespace PM_Tool_Console
{
    class Project
    {
        private string name;
        private string dateCreated;
        public Schedule schedule;
        private List<TeamMember> members;

        public Project(string name = "", string dateCreated = "")
        {
            this.name = name;
            this.dateCreated = dateCreated;
            this.schedule = new Schedule();
            this.members = new List<TeamMember>();
        }

        public void addMember(TeamMember member)
        {
            members.Add(member);
        }

        public void addMember(string member, string email = "")
        {
            members.Add(new TeamMember(member, email));
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

        public void viewSchedule()
        {
            List<Task> list = schedule.getTasks();
            foreach (Task elem in list)
            {
                Console.WriteLine("Task: " + elem.taskName() + 
                    " assigned to " + elem.getAssignedMember().getName() + 
                    " with priority " +  elem.taskPriority() + 
                    " expected to complete " +  elem.getCompletionDate()
                    );
            }
        }

        public void viewMembers()
        {
            foreach (TeamMember member in members)
            {
                Console.WriteLine("Name: " + member.getName() + " Email: " + member.getEmail());
            }
        }
        public List<TeamMember> getTeam()
        {
            return members;
        }

        public bool memberExists(string name)
        {
            foreach(TeamMember member in members)
            {
                if (member.getName() == name)
                {
                    return true;
                }
            }
            return false;
        }

        public bool memberExists(TeamMember member)
        {
            return members.Contains(member);
        }

        public TeamMember getMember(string name)
        {
            foreach(TeamMember member in members)
            {
                if (member.getName() == name)
                {
                    return member;
                }
            }

            TeamMember temp = new TeamMember(name);
            addMember(temp);
            return temp;
        }
    }
}
