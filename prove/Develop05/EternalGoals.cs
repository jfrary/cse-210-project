using System;

public class EternalGoals : Goals
{
    private int _score;

    public EternalGoals(string goal, int points) : base (goal, points)
    {
        
    }

      public override string GetGoalType()
    {
        return "Eternal Goal";
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        _score += GetPoints();
        return GetPoints();
    }
    public override int UserScore()
    {
        return _score;
    }
    public override string Save()
    {
        return $"Eternal Goal,{GetGoal()},{GetPoints()}";
    }
}