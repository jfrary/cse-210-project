using System;
using System.Numerics;

class DiceRollers
{
    private int _count;
    private int _sides;
    private int _characterModifier;
    private static Random _rng = new Random();

    public DiceRollers(int Count, int Sides, int Modifier)
    {
        _count = Count;
        _sides = Sides;
        _characterModifier = Modifier;
    }

    public int Rolldice()
    {
        int total = 0;
        
        for (int i = 0; i < _count; i++)
        {
            total += _rng.Next(1, _sides + 1);
        }
        total += _characterModifier;
        return total;
    }
}