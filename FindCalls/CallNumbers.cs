using System;
using System.Collections.Generic;
using System.Text;

namespace DeweySystem.FindCalls
{
    public class CallNumbers
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public List<CallNumbers> Children { get; set; }

        public CallNumbers(string code, string description)
        {
            Code = code;
            Description = description;
            Children = new List<CallNumbers>();
        }
    }
}

//reference : Beginning Data Structures and Algorithms in C# : Basic Trees. 2018. [Online].
//Available at: https://youtu.be/K0-qs--naUo