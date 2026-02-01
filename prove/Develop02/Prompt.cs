using System;
using System.Collections.Generic;

//Prompt will hold a list of prompt strings
//randmomly show one or two to exceed requirements
//after the prompt appeared and the user responds with input it returns to Program
public class Prompts
{
    public List<string> prompts = new List<string>//I need a list of prompts that will show up to the user
        {
        "1. Who was the most interesting person I interacted with today?",
        "2. What was the best part of my day?",
        "3. How did I see the hand of the Lord in my life today?",
        "4. What was the strongest emotion I felt today?",
        "5. If I had one thing I could do over today, what would it be?"
        };

    public string GetRandomPrompt()//this will show ine at random
    {
        Random rnd = new Random();
        int prompt = rnd.Next(prompts.Count);
        return prompts[prompt];

    }

}