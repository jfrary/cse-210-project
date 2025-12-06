using System;

public class ChecklistGoals : Goals
{
    private int _numCompleteTimes;
    private int _required;
    private int _bonus;

    public ChecklistGoals(string goal, int points, int required, int bonus) : base (goal, points)
    {
        _numCompleteTimes = 0;
        _required = required;
        _bonus = bonus;
    }

    public override bool IsComplete()
    {
        if (_numCompleteTimes >= _required)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

      public override string GetGoalType()
    {
        return "Checklist Goal";
    }
    public override int RecordEvent()
    {
        _numCompleteTimes++;
        if(_numCompleteTimes == _required)
        {
            return GetPoints() + _bonus;
        }
        else
        {
            return GetPoints();
        }
        
    }
    public override int UserScore()
    {
        int score = _numCompleteTimes * GetPoints();
        if (IsComplete())
        {
            score += _bonus;
        }
        return score;
      
    }
    public override string Save()
    {
        return $"Checklist Goal,{GetGoal()},{GetPoints()},{_required},{_bonus},{_numCompleteTimes}";
    }

    public string GetProgress()
    {
        return $"{_numCompleteTimes}/{_required}";
    }
}