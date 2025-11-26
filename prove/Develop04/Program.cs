using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        

         ReflectionActivity reflectionActivity = new ReflectionActivity();
         ListingActivity listingActivity = new ListingActivity();

        bool open = true;
        while (open)
        {
            Console.Clear();
            Console.WriteLine("Welcome to this Activity!");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("4: Exit");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                        Console.Write("Enter duration in seconds:");
                        int duration1 = int.Parse(Console.ReadLine());
                        breathingActivity.SetDuration(duration1);

                        breathingActivity.Start();
                break;
                
                 case  "2":
                         Console.WriteLine("Welcome to this activity");
                         Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                         Console.WriteLine("Enter duration in seconds:");
                         int duration2 = int.Parse(Console.ReadLine());
                         reflectionActivity.SetDuration(duration2);
                         reflectionActivity.Start();
                 break;
                
                 case  "3":
                         Console.WriteLine("Welcome to this Activity");
                         Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                         Console.WriteLine("Enter Duration in seconds");
                         int duration3 = int.Parse(Console.ReadLine());
                         listingActivity.SetDuration(duration3);
                         listingActivity.Start();
                 break;
                
                 case "4":
                        open = false;
                        Console.WriteLine("May you have a blessed day.");
                 break;
                
                default:
                    Console.WriteLine("Thats not an option, try again");
                break;
            }
        }

        
    }
}