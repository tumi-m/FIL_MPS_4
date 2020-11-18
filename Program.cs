using System;
//using system means you gonna use application out side of the vscode or vs2019
using System.Text;

using System.Collections.Generic;


namespace mps_assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
    
            string charCounts = Words.CountCharactersInSentence("Hello world");
         
            Console.WriteLine(charCounts);
          
        }
    }
}
