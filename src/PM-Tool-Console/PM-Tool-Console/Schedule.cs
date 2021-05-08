using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Tool_Console
{
    class Schedule
    {
        private List<Task> tasks;

        public Schedule()
        {
            tasks = new List<Task>();
        }

        public Schedule(List<Task> inputTasks)
        {
            tasks = inputTasks;
        }

        public Schedule(Task task)
        {
            tasks = new List<Task>();
            tasks.Add(task);
        }

        public void addTask(Task task)
        {
            tasks.Add(task);
        }

        public List<Task> getTasks()
        {
            return tasks;
        }

        public List<Task> fetchTaskList()
        {
            return tasks;
        }
    }
}
