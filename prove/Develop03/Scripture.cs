using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
 private Reference _reference;
 private List<Word> _text;

public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _text = words;
    }
public Scripture()
    {
         _reference = new Reference ("John", 1, 12, 13);
         _text = new List<Word>();       
    }

public void HideRandWords(int count)
{
    
    Random text = new  Random();
    
    for (int i = 0; i < count; i++) 
    {
        int index = text.Next(_text.Count);
        _text[index].Hide();
    }
}

public string RenderDisplay()
    {
        return string.Join(" ", _text.Select(j=> j.GetDisplayText()));
    }

public bool IsCompleteHidden()
{
   return _text.All(j => j.IsHidden());
}

public string RefCheck()
    {
        return _reference.DisplayReference();
    }
}