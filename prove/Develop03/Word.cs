class Word
{
    private string _word;
    private bool _hidden;

    public Word (string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetWordString()
    {
        string tempWord = _word;
        if (_hidden)
        {
            foreach(char c in _word)
            {
                tempWord 
            }
        }
        return _word;
    }

    public void Hide()
    {
        _hidden = true;
    }
}