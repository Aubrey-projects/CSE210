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
        return _word;
    }
}