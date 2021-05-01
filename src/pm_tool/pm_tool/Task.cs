using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm_tool
{
    class Task
    {
        // getAssignedMember
        public static void getAssignedMember(string[] names)
        {
            string[] newMember = names;
        }

        // updated member info
        public static string[] update(string[] names)
        {
            string[] updatedMember = names;

            return updatedMember;
        }

        // Return percentage of completeness
        public static double taskCompleteness(int totalTasks, int completeTasks)
        {
        
            double completeness = (completeTasks / totalTasks) * 100;

            return completeness;
        }

        public static void task(string[] name, string[] info, int[] priority, int[] date)
        {
            string[] taskName = name;
            string[] taskInfo = info;
            int[] taskPriority = priority;
            int[] taskDate = date;

            // Ask users for number of tasks and store it
            // WriteLine("Please enter the number of tasks: ");
            // int numberOfTasks = Convert.ToInt32(Console.ReadLine());

            //bool addTask = true;

            //string[] name = new string[numberOfTasks]; // Task name
            //string[] info = new string[numberOfTasks]; // Task description
            //int[] priority = new int[numberOfTasks];// Task priority



            //while (addTask == true)
            //{
            //    string tempName = "";
            //    string tempInfo = "";
            //    int tempPriority = 0;
            //    int i = 0;
            //    int j = 0;
            //    int k = 0;

            //    // Ask users to input task names
            //    Console.WriteLine("Enter the task names (enter 'quit' if done):");
            //    tempName = Console.ReadLine();
            //    if (!tempName.Equals("quit"))
            //    {
            //        name[i] = tempName;
            //        i++;
            //    }
            //    else
            //    {
            //        addTask = false;
            //        break;
            //    }

            //    // Ask users to input task info
            //    Console.WriteLine("Enter the task info (enter 'quit' if done):");
            //    tempInfo = Console.ReadLine();
            //    if (!tempInfo.Equals("quit"))
            //    {
            //        info[j] = tempInfo;
            //        j++;
            //    }
            //    else
            //    {
            //        addTask = false;
            //        break;
            //    }

            //    // Ask users to input task priorities
            //    Console.WriteLine("Enter the task priority (enter 'quit' if done):");
            //    tempPriority = Convert.ToInt32(Console.ReadLine());
            //    if (tempPriority >= 0)
            //    {
            //        priority[k] = tempPriority;
            //        k++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Priority cannot be string or negative int!");
            //        break;
            //    }
            //}

        }

    }
}
