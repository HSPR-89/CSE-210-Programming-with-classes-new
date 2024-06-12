using System;
using System.IO;
using static Entry;
class Program
{
    static void Main(string[] args)
    {
        //Creates a new instance of Journal
        Journal journal = new Journal();

        //Welcome banner
        Console.WriteLine("Welcome to Your Daily Journal!");

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            //Requests user selection for action to take
            Console.Write("Please select an option (1-5) ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice)
            {
                //Adds new entry
                case "1":
                    journal.AddEntry();
                    break;

                //Displays added entries
                case "2":
                    journal.DisplayEntries();
                    break;

                //Loads entries from a file
                case "3":
                    journal.LoadFromFile();
                    break;

                //Saves entries to a file
                case "4":
                    journal.SaveToFile();
                    break;

                //Exits program
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                //Handles invalid input
                default:
                    Console.WriteLine("Invalid selection, please enter a number 1-5.");
                    break;
            }
        }
    }
}

public class PromptGenerator
{
    public List<string> Prompts { get; set; }

    public PromptGenerator()
    {
        Prompts = new List<string> {
            "What was the best part of your day?",
            "Write about an experience where you felt the spirit with you today:",
            "Who was the most interesting person you interacted with today?",
            "Write about something that happened for which you are grateful today:",
            "If you had one thing you could do over today, what would it be?",
            "What was the strongest emotion you felt today?",
            "Write about an act of service you either witnessed or performed today:>",
            "Write about something you learned today:",
            "Write about a tender mercy you noticed today:",
            "Write about a positive interaction you had with someone else today:",
            "Write about something you noticed that reminded you of Jesus Christ today:",
            "Write about something you learned about someone in your life today:",
            "Write about an experience you had that allowed you to teach someone else today:"
        };
    }

    //Generates a random prompt from the list
    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }

}

public class Entry
{
    public string DateCreated { get; }
    public string Content { get; }

    //Initializes the date and content of an entry from user input
    public Entry(string dateInput, string content)
    {
        DateCreated = dateInput;
        Content = content;
    }

    //Displays the content of an entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {DateCreated}");
        Console.WriteLine($"Content: {Content}\n");
    }
    public class Journal
    {
        public List<Entry> entries;
        public PromptGenerator promptGenerator;

        //Constructor initializes and empty list of entries
        public Journal()
        {
            entries = new List<Entry>();
            //Initializes the prompt generator
            promptGenerator = new PromptGenerator();
        }

        //Adds a new entry to the journal from user input
        public void AddEntry()
        {

            string prompt = promptGenerator.GenerateRandomPrompt();
            Console.Write("Please enter the date(mm/dd/yyyy): ");
            string dateInput = Console.ReadLine();
            Console.WriteLine($"Today's Prompt: {prompt}");
            Console.Write("> ");
            string content = Console.ReadLine();
        }

        //Displays data input this session
        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                entry.DisplayEntry();
            }
        }

        //Saves Entries to a file named by the user
        public void SaveToFile()
        {
            Console.Write("Please enter the filename you would like to save to: ");
            string filename = Console.ReadLine();
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine($"{entry.DateCreated}\n{entry.Content}");
                    }
                }
                Console.WriteLine($"Journal entries saved to {filename}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
            }
        }

        //Loads Entries from a file named by the user
        public void LoadFromFile()
        {
            Console.Write("Please enter the file name you would like to load from: ");
            String filename = Console.ReadLine();
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        string dateString = reader.ReadLine();
                        string content = reader.ReadLine();
                        Entry entry = new Entry(dateString, content);
                        entries.Add(entry);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error loading entries from :filename: {e.Message}");
            }
        }

    }
}