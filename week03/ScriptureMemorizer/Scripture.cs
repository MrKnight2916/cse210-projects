using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    // Ocultar palabras aleatorias
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int count = 0;

        List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());
        while (count < numberToHide && visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            count++;
        }
    }

    // Mostrar texto con palabras ocultas
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word w in _words)
        {
            displayWords.Add(w.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(' ', displayWords)}";
    }

    // Comprobar si todas las palabras están ocultas
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}
