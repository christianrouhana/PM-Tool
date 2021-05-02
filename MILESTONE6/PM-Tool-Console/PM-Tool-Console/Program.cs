using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Christian Rouhana
// PM-Tool group
// 5/2/2021

namespace PM_Tool_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please enter Project name");
            string projectName = Console.ReadLine();
            Console.WriteLine("Please enter today's date");
            string creationDate = Console.ReadLine();
            Project project = new Project(projectName, creationDate);
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please enter your command. Type 'help' for accepted commands");
                string command = Console.ReadLine();
                switch(command)
                {
                    case "newTask":
                        Console.WriteLine("Please enter taskName");
                        string newTaskName = Console.ReadLine();
                        Console.WriteLine("Please enter task priority");
                        int enterTaskPriority = int.Parse(Console.ReadLine());
                        Console.WriteLine("Who is this assigned to? (enter exact name)");
                        string memberName = Console.ReadLine();
                        TeamMember member = project.getMember(memberName);
                        Console.WriteLine("When is this task expected to finish?");
                        string completion = Console.ReadLine();
                        Task newTask = new Task(newTaskName, enterTaskPriority, member, completion);
                        project.schedule.addTask(newTask);
                        Console.WriteLine("Task Created!");
                        break;
                    case "newMember":
                        Console.WriteLine("Please enter member name");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Please enter member email");
                        string newEmail = Console.ReadLine();
                        project.addMember(newName, newEmail);
                        Console.WriteLine("Member added!");
                        break;
                    case "seeSchedule":
                        project.viewSchedule();
                        break;
                    case "seeTeam":
                        project.viewMembers();
                        break;
                    case "exit":
                        exit = true;
                        break;
                    case "help":
                        Console.WriteLine("Currently accepted commands \n" +
                            "newTask \n" +
                            "newMember \n" +
                            "seeSchedule \n" +
                            "seeTeam \n" +
                            "exit \n" +
                            "help \n");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid command. Type 'help' for acceptable commands.");
                        break;
                }
            }
        }
    }
}
