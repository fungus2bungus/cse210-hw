class Word
{
    private string _text;
    private bool _isHidden = false;
    
    public Word(string text){
        _text = text;
    }
    
    public void Hide()
    {
        // DONE TODO: write the code that will actually hide words in the string? list maybe?
        // _isHidden is used here I think?
        // I think this works perfectly fine now
        if (_isHidden == false)
        {
            // int kl = _text.Length;
            // replaces each character in the _text object. source from: https://www.perplexity.ai/search/c-list-length-aHjRsPC_S6GdSuKC_ii_xg
            for (char c = char.MinValue; c < char.MaxValue; c++)
            {
                _text = _text.Replace(c, '_');
            }
            // _text = "___";
            _isHidden = true;
        }
        
    }
    public string GetText()
    {
        return _text;
    }
    
    public bool GetHidden()
    {
        return _isHidden;
    }
    // TODO: Do I really need this function for anything?
    // would it make it easier for to have this display be called into scripture?
    public string GetDisplayContent()
    {
        string epic = "epic";
        return epic;
        
    }

    
// a word display function? although Hide() might be the more accurate title    
/*     private void DisplyWords()
    {

    } */
}