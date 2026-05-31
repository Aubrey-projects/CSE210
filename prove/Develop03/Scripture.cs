class Scripture
{
    // variables
    private List<Word> _scripture = new List<Word>();
    private int _scriptureLength = 0;
    private bool _allHidden = false;
    
    // constructor
    public Scripture (string scripture)
    {
        List<string> stringList = scripture.Split(" ").ToList();
        foreach (string word in stringList)
        {
            Word myWord = new Word(word);
            _scripture.Add(myWord);
            _scriptureLength += 1;
        }
    }

    public int GetScriptureLength()
    {
        return _scriptureLength;
    }

    public bool IsHidden()
    {
        return _allHidden;
    }

    public void DisplayScripture()
    {
        foreach (Word word in _scripture)
        {
            word.DisplayWord();
        }
    }

    public void HideRandomWord()
    {
        Random randomGenerator = new Random();
        int randomIndex;
        // the while loop makes sure that each new word isn't already hidden
        do
        {
            randomIndex = randomGenerator.Next(0, _scriptureLength);
            CheckIfScriptureIsHidden();
        } while (_scripture[randomIndex].IsHidden() && _allHidden != true);
        _scripture[randomIndex].Hide();
    }

    public void CheckIfScriptureIsHidden()
    {
        int amountHidden = 0;
        foreach (Word word in _scripture)
        {
            if (word.IsHidden())
            {
                amountHidden += 1;
            }
        }
        if (amountHidden == _scriptureLength)
        {
            _allHidden = true;
        }
    }
}
