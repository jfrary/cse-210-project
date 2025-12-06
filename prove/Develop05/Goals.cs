using System;
using System.IO;
using System.Collections.Generic;


public abstract class Goals
{
    private string _goal;
    private int _points;
    
    public Goals(string goal, int points)
    {
        _goal = goal;
        _points = points;
    }

    public string GetGoal()
    {
        return _goal;
    }

    public int GetPoints()
    {
        return _points;
    }
    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public abstract int UserScore();
    public abstract string Save();
    public abstract string GetGoalType();
}

    // private string _UserGoal;
    // private int _UserScore;

    // public Goals(string UserGoal)
    // {
    //     _UserGoal = UserGoal;
    //     _UserScore = 0;
    // }

    // public SetUserGoal()
    // {
    //     _UserGoal = UserGoal;
    // }
    // public GetUserGoal()
    // {
    //     return _UserGoal;
    // }

    // public int DisplayUserScore()
    // {
    //     return _UserScore;
    // }

    // public void AddScore(int points)
    // {
    //     _UserScore += points;
    // }