using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        bool open = true;
        while (open)
        {
            Console.Clear();
            Console.WriteLine("Welcome to this Goal Activity");
            Console.WriteLine("1: Create Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Record Event");
            Console.WriteLine("6: Quit");
            string choose = Console.ReadLine();

            switch (choose)
            {
                  case "1":
                         //This loop is to validate a number input instead of text.
                         string type;
                         while (true)
                    {
                        
                    
                         Console.WriteLine("Select the Goal you want to do:");
                         Console.WriteLine("1: Simple Goal");
                         Console.WriteLine("2: Eternal Goal");
                         Console.WriteLine("3: Checklist Goal");
                         
                         Console.WriteLine("Your Choice: ");
                        type = Console.ReadLine();

                        if (type == "1" || type == "2" || type == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Only enter a number please, try again");
                        }
                        
                    }
                        // string type = Console.ReadLine();
                         

                         Console.WriteLine("Goal Name?");
                         string name = Console.ReadLine();

                         int points;
                         while (true)
                    {
                        
                    
                         Console.WriteLine("Amount of points?");
                         string inputPoints = Console.ReadLine();
                         if (int.TryParse(inputPoints, out points) && points >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number, not text.");
                        }
                        
                    }
                         if (type == "1")
                    {
                        SimpleGoals simpleGoal = new SimpleGoals(name, points);
                        goalManager.AddGoal(simpleGoal);
                    }
                        
                        else if (type == "2")
                    {
                        EternalGoals eternalGoal = new EternalGoals(name, points);
                        goalManager.AddGoal(eternalGoal);    
                    }
                        else if (type == "3")
                    {
                        int required;
                        while (true) 
                        {
                        Console.Write("How many times to complete? ");
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out required) && required > 0)
                            {
                                break;
                            }
                        else
                            {
                                Console.WriteLine("Please Enter a number my dude, try again.");

                            }
                        
                        }

                        int bonus;
                        while (true)
                        {
                            
                        
                        Console.Write("How many bonus points? ");
                           string input = Console.ReadLine();
                        if (int.TryParse(input, out bonus) && bonus >= 0)
                            {
                                break;
                            }
                        else
                            {
                                Console.WriteLine("Please Enter a number my dude, try again.");

                            }
                        }
                        ChecklistGoals checklistGoal = new ChecklistGoals(name, points, required, bonus);
                        goalManager.AddGoal(checklistGoal);
                    }
                    
                    Console.WriteLine("Your Goal is created, press Enter to Continue");
                    Console.ReadKey();

                        
                break;
                
                 case  "2":
                      Console.WriteLine("Your Goals: ");
                      goalManager.DisplayGoals();
                      Console.WriteLine("Press Enter to Continue");
                      Console.ReadKey();

                      
                 break;
                
                 case  "3":
                      Console.WriteLine("Enter a filename: ");
                      string saveFile = Console.ReadLine();
                      goalManager.Save(saveFile);
                      Console.WriteLine("Press Enter to Continue");
                      Console.ReadKey();

                     
                 break;
                
                 case "4":
                        string saveFolder = "Saved Files";
                        if (!Directory.Exists(saveFolder))
                    {
                        Console.WriteLine("No saves here.");
                        Console.ReadKey();
                        break;
                    }
                    
                        string[] files = Directory.GetFiles(saveFolder, "*.txt");

                        if (files.Length == 0)
                    {
                        Console.WriteLine("No saves here");
                        Console.ReadKey();
                        break;
                    }
                    
                        Console.WriteLine("Available Files: ");
                        for (int i = 0; i < files.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} {Path.GetFileName(files[i])}");
                    }
                        Console.WriteLine("Enter the number associated to the file to load.");
                        if (int.TryParse(Console.ReadLine(), out int fileChoice) &&
                        fileChoice >= 1 && fileChoice <= files.Length)
                    {
                        string loadFile = files[fileChoice - 1];
                        goalManager.Load(loadFile);
                        Console.WriteLine($"File Loaded....{Path.GetFileName(loadFile)}");
                    }
                    else
                    {
                        Console.WriteLine("Not a Choice, try again.");
                    }

                        Console.WriteLine("Press Enter to Continue.");
                        Console.ReadKey();
                 break;
                
                 case "5":
                      Console.WriteLine("Enter the number next to the goal to record your progress on the goal: ");
                      goalManager.DisplayGoals();
                      Console.WriteLine("Enter number: ");
                      int index = int.Parse(Console.ReadLine()) - 1;
                      goalManager.RecordEvent(index);
                      Console.WriteLine("Goal Recorded! Press Enter to Continue");
                      Console.ReadKey(); 
                
                 break;

                 case "6":
                        open = false;
                        Console.WriteLine("Exiting......");
                        Console.WriteLine("Have a Wonderful time.");
                 break;
                default:
                    Console.WriteLine("Thats not an option, try again");
                break;
            }
            }
    }
}

