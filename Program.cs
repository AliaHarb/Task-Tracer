class Task_Tracker
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public string Priority { get; set; }
    public Status TaskStatus { get; set; }

    public Task_Tracker(string title, DateTime dueDate, string description, string priority)
    {
        Title = title;
        DueDate = dueDate;
        Description = description;
        Priority = priority;
        TaskStatus = Status.pending;
    }

    public void UpdateStatus(Status newStatus)
    {
        TaskStatus = newStatus;
    }

    public void DisplayTask()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Due Date: {DueDate.ToShortDateString()}");
        Console.WriteLine($"Priority: {Priority}");
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
        Console.WriteLine("This task is no longer needed");
    }
}

   class Program
{
    static void Main(string[] args)
    {
        Task_Tracker Task1 = new Task_Tracker(
            "CIS TASK",
            new DateTime(2025, 5, 5),  
            "The Task Tracker project",
            "High"
        );

        Task1.DisplayTask();
        Task1.ViewTaskCategory();

        Task1.UpdateStatus(Status.in_progress);
        Console.WriteLine("\nAfter updating status to in_progress:");
        Task1.DisplayTask();
        Task1.ViewTaskCategory();

        Task1.UpdateStatus(Status.completed);
        Console.WriteLine("\nAfter updating status to completed:");
        Task1.DisplayTask();
        Task1.ViewTaskCategory();

        Console.Write("\nDo you want to exit? (Yes/No): ");
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
