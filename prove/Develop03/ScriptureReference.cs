class ScriptureReference
{
    // variables
    private string _bookName;
    private int _chapter;
    private string _verse;

    // constructor
    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = $"{verse}";
    }

    // constructor
    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = $"{startVerse}-{endVerse}";
    }

    public void ShowScriptureReference()
    {
        Console.Write($"{_bookName} {_chapter}:{_verse} ");
    }

    public string GetScriptureReference()
    {
        return $"{_bookName} {_chapter}:{_verse}";
    }
}