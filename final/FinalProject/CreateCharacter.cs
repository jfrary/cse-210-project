using System;
using System.Collections;



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
                         Console.WriteLine("2: Wizard");
                         Console.WriteLine("3: Rouge");
                         
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
                Console.Write("Enter a name for character: ");
                string name = Console.ReadLine();
                Character newCharacter = null;
                int inventory = 5;
                string knownSpells = "Fireball, Lighting Bolt";
                switch (type)
                {
                case "1":
                newCharacter = new Fighter(
                name , 
                hp: 25 , 
                armorClass: 15 , 
                inventory
                
                );
                

                // Console.WriteLine("Your character is created!");
                // Console.WriteLine($"Name: {fighter.Name}");
                // Console.WriteLine($"Health: {fighter.HP}");
                // Console.WriteLine($"Inventory: {fighter.Inventory}");
                // Console.WriteLine($"ArmorClass: {fighter.ArmorClass}");
                // Console.WriteLine($"Your character is created!");
                break;


                case "2":
                newCharacter = new Wizard(
                name ,
                hp: 25 ,
                spellSlots: 3 ,
                knownSpells ,
                inventory
                
                

                // Console.WriteLine("Your character is created!");
                // Console.WriteLine($"Name: {wizard.Name}");
                // Console.WriteLine($"Health: {wizard.HP}");
                // Console.WriteLine($"Inventory: {wizard.Inventory}");
                // Console.WriteLine($"ArmorClass: {wizard.ArmorClass}");
                // Console.WriteLine($"Your character is created!");
                );
                break;
               
                
                case "3":
                 bool isStealthed = true;
                newCharacter = new Rouge(
                name , 
                hp: 20 ,
                inventory ,
                IsStealthed: isStealthed
                );
                break;
            default:
               return;
                }  
            characters.Add(newCharacter);
            Console.WriteLine("Character Created!");
            newCharacter.DisplayCharacter();
            Console.ReadLine();
                     
        }
}


