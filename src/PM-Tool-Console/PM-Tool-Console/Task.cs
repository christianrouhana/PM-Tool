using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Tool_Console
{
    class Task
    {
        private string name;
        private int priority;
        private TeamMember assignedTo;
        private string expectedCompletion;
        private bool complete;

        public Task(string name = "", int priority = 0, TeamMember assignedTo = null, string expectedCompletion = "", bool complete = false)
        {
            this.name = name;
            this.priority = priority;
            this.assignedTo = assignedTo;
            this.expectedCompletion = expectedCompletion;
            this.complete = complete;
        }

        // getAssignedMember
        public TeamMember getAssignedMember()
        {
            return assignedTo;
        }

        // Return percentage of completeness
        public bool isComplete()
        {
            return complete;
        }

        public string taskName()
        {
            return name;
        }

        public int taskPriority()
        {
            return priority;
        }

        public string getCompletionDate()
        {
            return expectedCompletion;
        }

        public void updateName(string name)
        {
            this.name = name;
        }

        public void updatePriority(int priority)
        {
            this.priority = priority;
        }

        // updated member info
        public void updateAssigned(TeamMember member)
        {
            assignedTo = member;
        }

        public void updateCompletion(bool completion)
        {
            this.complete = completion;
        }
    }
}
