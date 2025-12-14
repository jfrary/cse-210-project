using System;


class CreateCharacter
{
    public static void CreateNewCharacter(List<Character> characters)
    {
              string type;
                         while (true)
                    {
                        
                         Console.Clear();
                         Console.WriteLine("Select a Character you want to create.");
                         Console.WriteLine("1: Fighter");
                         Console.WriteLine("2: Rouge");
                         Console.WriteLine("3: Wizard");
                         
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

                Console.Write("Enter a name for character.");
                string name = Console.ReadLine();
                int hp = 25;
                int armorClass = 15;
                int inventory = 5;
                Fighter fighter = new Fighter(name, hp, inventory, armorClass);
                characters.Add(fighter);

                Console.WriteLine("Your character is created!");
                Console.WriteLine($"Name: {fighter.Name}");
                Console.WriteLine($"Health: {fighter.HP}");
                Console.WriteLine($"Inventory: {fighter.Inventory}");
                Console.WriteLine($"ArmorClass: {fighter.ArmorClass}");
                Console.WriteLine($"Your character is created!");

                    
        }
}