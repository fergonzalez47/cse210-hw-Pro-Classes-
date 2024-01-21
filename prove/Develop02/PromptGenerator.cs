using System;
using System.Collections.Generic;

public class PrompGenerator {
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt() {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, _prompts.Count);

        if (_prompts.Count > 0)
        {
            return _prompts[index];
        }
        else
        {
            return "No prompts";
        }

    }
}