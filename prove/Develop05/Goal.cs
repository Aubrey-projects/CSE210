class Goal
{
    private string _goalType;
    private string _goalDescription;
    private int _goalPoints;


    public Goal(string goalType, string goalDescription, int goalPoints)
    {
        _goalType = goalType;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }
    
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }
}