using System;

public class SimpleGoals : Goals
{
    private bool _isComplete;

    public SimpleGoals(string goal, int points) : base (goal, points)
    {
        _isComplete = false;
    }

    public override string GetGoalType()
    {
        return "Simple Goal";
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }
    public override int UserScore()
    {
        if (IsComplete() == true)
        {
            return GetPoints();
        }
        return 0;
    }
    public override string Save()
    {
        return $"Simple Goal,{GetGoal()},{GetPoints()},{_isComplete}";
    }
}