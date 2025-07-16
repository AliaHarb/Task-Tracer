using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp14
{

    enum Status
    {
        pending,
        in_progress,
        completed
    }
    class Task_Tracker
    {

        public string title { get; set; }
        public string description { get; set; }
        public string due_date { get; set; }
        public string priority { get; set; }
        public Status TaskStatus { get; set; }

        

        public Task_Tracker(string title, string due_date, string description, string priority)
        {
            this.title = title;
            this.description = description;
            this.due_date = due_date;
            this.priority = priority;
            TaskStatus = Status.pending;
        }

        public void UpdateStatus(Status newStatus)
        {
            TaskStatus = newStatus;
        }
        public void DisplayTask()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Due Date: {due_date}");
            Console.WriteLine($"Priority: {priority}");
            Console.WriteLine($"Status: {TaskStatus}");
        }
       public void ViewTaskCategory()
{
    if (TaskStatus == Status.completed)
    {
        Console.WriteLine("Task is completed");
    }
    else
    {
        if (DueDate < DateTime.Today)
        {
            Console.WriteLine("Task is overdue");
        }
        else
        {
            Console.WriteLine("Task is active");
        }
    }
}

        

        
        ~Task_Tracker()
        {
            Console.WriteLine("this task is no longer needed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task_Tracker Task1 = new Task_Tracker("CIS TASK",
                "2025-05-5",
                "The Task Tracker project",
                "High"
            );
            Task1.DisplayTask();
            Task1.UpdateStatus(Status.in_progress);
            Console.WriteLine("After updating:");
            Task1.DisplayTask();
            Task1.UpdateStatus(Status.completed);
            Console.WriteLine("After completing:");
            Task1.DisplayTask();


            Console.Write("Do you want to exit?");
            string input = Console.ReadLine();
            if (input == "Yes")
            {
                Console.WriteLine("Exiting application safely.");

            }
            else if (input == "No")
            {
                Console.WriteLine("Exit canceled.");

            }
            else
            {
                Console.WriteLine("Please enter Yes or No.");
            }

            Console.ReadLine();
        }
    }
}
