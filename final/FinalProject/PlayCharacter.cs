using System;



class PlayCharacter
{
   private Character _character;
   public PlayCharacter(Character character)
    {
        _character = character;
    }

    public void StartPlay()
    {
        bool play = true;
        while (play)
        {
            Console.Clear();
            DisplayStart();
            DisplayPlayerStats();
            ShowMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Attack();
                    break;
                
                case "2":
                    CastSpell();
                    break;
                
                case "3":
                    _character.DisplayCharacter();
                    ExitBacktoMenu();
                    break;
                
                case "4":
                    RollThemDice();
                    break;
                
                case "5":
                    play = false;
                    break;
                
                default:
                Console.WriteLine("Not an option, please choose again");
                ExitBacktoMenu();
                break;
                
            }
        }
    }

    private void DisplayStart()
    {
        Console.WriteLine("Welcome to Play as the character");
        Console.WriteLine($"{_character.Name()} ({_character.GetType().Name})");
        Console.WriteLine("...................................");
    }

    private void DisplayPlayerStats()
    {
        Console.WriteLine($"HP: {_character.HP()}");
        
        if (_character is Fighter f)
            Console.WriteLine($"Armor Class: {f.ArmorClass()}");

        if (_character is Wizard w)
             Console.WriteLine($"Spell Slots: {w.SpellSlots()}");
        
        if (_character is Rouge r)
             Console.WriteLine($"Stealth: {r.IsStealthed}");



         Console.WriteLine();
    }

    private void ShowMenu()
    {
         Console.WriteLine("1: Attack");
         Console.WriteLine("2: Cast Spell");
         Console.WriteLine("3: Show Stats");
         Console.WriteLine("4: Manual Roll Dice");
         Console.WriteLine("5: Quit");
         Console.WriteLine("Choose what action: ");
    }

    private void Attack()
    {
        WeaponAttack attack;

        if (_character is Fighter)
        {
            DiceRollers attackRoll = new DiceRollers(1, 20, 0);
            DiceRollers damageRoll = new DiceRollers(2, 8, 0);
            attack = new WeaponAttack("Short Sword", attackRoll, damageRoll);
             Console.WriteLine($"{_character.Name()} slashes with his weapon!");
        }
        else if (_character is Rouge)
        {
            DiceRollers attackRoll = new DiceRollers(1, 20, 0);
            DiceRollers damageRoll = new DiceRollers(2, 8, 0);
            attack = new WeaponAttack("Bow", attackRoll, damageRoll);
            Console.WriteLine($"{_character.Name()} hits from the shadows like a wuss!");
        }   
        else if (_character is Wizard)
        {
            DiceRollers attackRoll = new DiceRollers(1, 20, 0);
            DiceRollers damageRoll = new DiceRollers(1, 4, 0);
            attack = new WeaponAttack("Staff", attackRoll, damageRoll);
            Console.WriteLine($"{_character.Name()} blasts with some basic magic!");
        }
        else
        {
            Console.WriteLine("Too weak to attack");
            ExitBacktoMenu();
            return;
        }
        int AttackResult = attack.AttackThem();
        int DamageResult = attack.Damage();

        Console.WriteLine($"{_character.Name()} Rolls a {AttackResult} on his attack roll.");
        Console.WriteLine($"{_character.Name()} Rolls {DamageResult} on damage.");
        ExitBacktoMenu();
    }
    
    // private void Special()
    // {
    //     if (_character is Fighter)
    //     {
    //         Console.WriteLine("Your next attack, roll 2 more d6 for damage");
    //     }
    //     else if (_character is Wizard)
    //     {
    //         Console.WriteLine("You Cast a spell. Choose which.");
    //     }
    //     else if (_character is Rouge)
    //     {
    //         Console.WriteLine("You cloak your self in shadows, you are hidden!");
    //     }
    //     ExitBacktoMenu();
    // }
    
    private void CastSpell()
    {
        if (!(_character is Wizard))
        {
            Console.WriteLine("Your not a Wizard, stop trying already");
            ExitBacktoMenu();
            return;
        }
        Wizard w = (Wizard)_character;

        if (w.SpellSlots() <= 0)
        {
            Console.WriteLine("Out of Spell slots!");
            ExitBacktoMenu();
            return;
        }

        Console.WriteLine("Choose which spell to cast");
        Console.WriteLine("1: Fireball");
        Console.WriteLine("2: Lighting Bolt");

        string choice = Console.ReadLine();
        Spells spell;

        Fireball fireball = new Fireball();
        if (choice == "1") spell = new Fireball();
        else if (choice == "2") spell = new LightingBolt();
        else
        {
            Console.WriteLine("Not an option");
            ExitBacktoMenu();
            return;
        }
        
        DiceRollers attackRoll = new DiceRollers(1, 20, 0);
        DiceRollers damageRoll = new DiceRollers(3, 8, 0);

        SpellAttack spellAttack = new SpellAttack(spell.Spell(), attackRoll, damageRoll);

        int AttackResult = spellAttack.AttackThem();
        int DamageResult = spellAttack.Damage();
        
        Console.WriteLine($"{w.Name()} Casts {spell.Spell()}!! Rolls a {AttackResult} on his Spell attack roll.");
        Console.WriteLine($"{w.Name()} Rolls {DamageResult} on damage.");

        w.UseSpellSlot(fireball.SpellSlotMinus());
        
        
        ExitBacktoMenu();
    }
    private void RollThemDice()
    {
        Console.Write("How many do you want to roll? ");
        int count = int.Parse(Console.ReadLine());

        Console.Write("Sides? ");
        int sides = int.Parse(Console.ReadLine());

        Console.Write("Player Modifier? ");
        int modifier = int.Parse(Console.ReadLine());

        DiceRollers dice = new DiceRollers(count, sides, modifier);
        int total = dice.RollDice();

        Console.WriteLine($"{total}");
        Console.ReadLine();
    }


    private void ExitBacktoMenu()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
    }
}


