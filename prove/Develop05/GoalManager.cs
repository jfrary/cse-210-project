using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goals> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goals>();
        _score = 0;
    }

    public void AddGoal(Goals goals)
    {
        _goals.Add(goals);
    }
    
    public List<Goals> GetGoals()
    {
        return _goals;
    }

    public int GetScore()
    {
        return _score;
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
        }
    }
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals set yet.");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
           string checkbox = _goals[i].IsComplete() ? "[X]" : "[ ]";
           string type = _goals[i].GetType().Name;
           string showProg = $"{i + 1}: {checkbox} {_goals[i].GetGoalType()}: {_goals[i].GetGoal()}: Current Score: {_goals[i].UserScore()}";

           if (_goals[i] is ChecklistGoals checklist)
            {
                showProg += $" Progress: {checklist.GetProgress()}";
            }
            Console.WriteLine(showProg);
        }
    }
    
    public void Save(string filename) {

        string saveFolder = "Saved Files";
        if (!Directory.Exists(saveFolder))
        {
            Directory.CreateDirectory(saveFolder);
        }
        string filePath = Path.Combine(saveFolder, filename + ".txt");

    using (StreamWriter outputFile = new StreamWriter(filePath))
    {
    foreach (Goals g in _goals)
            {
                outputFile.WriteLine(g.Save());
            }
    Console.WriteLine($"Saved! {filePath}");
    }
}
    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist");
            return;
        }
        

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string type = parts[0];

            if (type == "Simple Goal")
            {
                string goal = parts[1];
                int points = int.Parse(parts[2]);
                bool complete = bool.Parse(parts[3]);

                SimpleGoals g = new SimpleGoals(goal, points);
                if (complete)
                g.RecordEvent();
                _goals.Add(g);
            }
            else if (type == "Eternal Goal")
            {
                string goal = parts[1];
                int points = int.Parse(parts[2]);
                EternalGoals g = new EternalGoals(goal, points);
                _goals.Add(g);
            }
            else if (type == "Checklist Goal")
            {
                string goal = parts[1];
                int points = int.Parse(parts[2]);
                int required = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int numCompleteTimes = int.Parse(parts[5]);

                ChecklistGoals g = new ChecklistGoals(goal, points, required, bonus);
                for (int i = 0; i < numCompleteTimes; i++)
                g.RecordEvent();
                _goals.Add(g);
            }
        }
      }
    }

        



    


