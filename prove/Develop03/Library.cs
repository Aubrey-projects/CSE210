class Library
{
    // variables
    private List<ScriptureReference> _libraryOfReferences = new List<ScriptureReference>();
    private List<Scripture> _libraryOfScriptures = new List<Scripture>();
    private ScriptureReference _selectedReference;
    private Scripture _selectedScripture;
    private int _librarylength = 0;

    // constuctor
    public Library (ScriptureReference reference, Scripture scripture)
    {
        _libraryOfReferences.Add(reference);
        _libraryOfScriptures.Add(scripture);
        _librarylength += 1;
    }

    public void AddScripture(ScriptureReference reference, Scripture scripture)
    {
        _libraryOfReferences.Add(reference);
        _libraryOfScriptures.Add(scripture);
        _librarylength += 1;
    }

    public void SelectRandomScripture()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _librarylength);
        _selectedReference = _libraryOfReferences[randomIndex];
        _selectedScripture = _libraryOfScriptures[randomIndex];
    }

    public Scripture GetSelectedEntry()
    {
        return _selectedScripture;
    }

    public void ShowSelectedEntry()
    {
        _selectedReference.ShowScriptureReference();
        _selectedScripture.DisplayScripture();
    }
}