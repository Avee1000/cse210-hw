using System;

public class SimpleGoal : Goal
{
    private string _goalName = "Simpple Goal";
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (_isComplete ==  true)
        {
            Console.WriteLine($"Event recorded for the Simple Goal: {GetName()}");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalName}: {GetName()}\n{GetDescription()}\n{GetPoints()}";    
    }

}