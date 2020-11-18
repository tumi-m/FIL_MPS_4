using System;
using System.Collections.Generic;
using System.Text;
public static class Words

    {                                                      
        public static string CountCharactersInSentence(string inputString)

        {
            Dictionary<char, int> Newstring = new Dictionary<char, int>();
            string nothing = inputString;
            foreach (char characters in nothing.Replace(" ", string.Empty))
            {
                if (Newstring.ContainsKey(characters))
                {
                    Newstring[characters] = Newstring[characters] + 1;
                }
                else
                {
                    Newstring.Add(characters, 1);
                }
            }
            foreach (var item in Newstring.Keys)
            {
                nothing += " " + item + " -> " + Newstring[item]+ " ";
            }
            return nothing;
            
        }
            

    }
