using System;
using System.Collections.Generic;
using System.Linq;
public class Reference
{
 private string _book;
 private int _chapter;
 private int _verse;
 private int _secondVerse;
 
public Reference(string book, int chapter, int verse, int secondVerse)
    {
       _book = book;
       _chapter = chapter;
       _verse = verse;
       _secondVerse = secondVerse; 
    }

public string DisplayReference()
    {
        if (_verse == _secondVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
            return $"{_book} {_chapter}:{_verse}-{_secondVerse}";
    }
}