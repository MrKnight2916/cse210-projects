using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "";
        }

        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> ad99efa6f8e411b08149ee4c2762427bc2df0ca3
