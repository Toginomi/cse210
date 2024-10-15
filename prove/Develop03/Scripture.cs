public class Scripture
{
    private Random random = new Random();
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        int totalWords = _words.Count;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(totalWords);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        displayWords.Add(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}
