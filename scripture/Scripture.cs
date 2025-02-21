class Scripture
{
    private List<Word> _words;
    private Reference _ref;

    public Scripture(Reference re, string text)
    {
        Console.WriteLine($" {text}");
        _words = new List<Word>();

        // foreach (string m = "" in text)
        List<string> morg = text.Split(' ').ToList();
        for (int i =0; i<morg.Count; i++)
        {
            Word jor = new Word(morg[i]);
            _words.Add(jor);
        }
        
    }
    Random random = new Random();
    public void HideRandomWords()
    {
        // int gr =_words[mn].Count;
        // _words[mn]=
        // so this will call hide?
        for (int i=0; i < 3; i++)
        {
            // set a random number

            int mn = random.Next(_words.Count);
            //run the Hide() function at the index
            if (_words[mn].GetHidden() == true)
            {
                // I have no idea how to make it select a different index that isn't hidden. I looked for something but it looked extremely in-depth and decided it was more than likely out of scope of the assignment
                int g = random.Next(_words.Count);
                _words[g].Hide();
            }
            else
            {
                _words[mn].Hide();
            }
            // TODO: add code to Hide() or here to make it ignore already hidden Words
        }
    }
    // DONE TODO: make this code actually do something, checks the _isHidden attribute I guess?
    // Okay, now where do I put it?
    public bool AllHidden()
    {
        int tg = 0;
        foreach(Word go in _words)
        {
            // needs to check the isHidden attribute
            // if go.GetHidden() == true; then do something?
            // I need it to check every Word object and be able to check the _words length?
            if (go.GetHidden() == true)
            {
                tg++;
            }
        }

        if (tg == _words.Count)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    // DONE TODO make this a void, probably doesn't need to return anything
    public void GetDisplayContent()
    {
        // I think this is supposed to return the updated hidden words?

        // okay, so I need to get the _text from _words... somehow

        foreach (Word m in _words)
        {
            Console.Write($"{m.GetText()} ");
        }
    }
    
}