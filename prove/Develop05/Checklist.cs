class Checklist : Goal
{
    private int _amountTillBonus;
    private int _amountDone;
    private int _bonusPoints;
    private bool _isComplete;

    public Checklist(string goalType, string goalDescription, int goalPoints, int amountTillBonus, int bonusPoints) : base (goalType, goalDescription, goalPoints)
    {
        _amountTillBonus = amountTillBonus;
        _bonusPoints = bonusPoints;
        _amountDone = 0;
    }

    public int GetAmountTillBonus()
    {
        return _amountTillBonus;
    }

    public int GetAmountDone()
    {
        return _amountDone;
    }
}