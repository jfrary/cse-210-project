using System;


class LightingBolt : Spells
{
        public LightingBolt() : base("Lighting Bolt", 8, 30, 1)
    {

    }
     public override string Spell()
    {
        return "Lighting Bolt";
    }
        public override int Dmg()
    {
        DiceRollers dice = new DiceRollers(3, 8, 0);
        return dice.RollDice();
    }
    
    public override int Range()
    {
        return 30;
    } 

    public override int SpellSlotMinus()
    {
        return 1;
    }   
}