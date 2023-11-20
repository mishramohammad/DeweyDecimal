using System;
using System.Collections.Generic;
using System.Text;

namespace DeweySystem.FindCalls
{
    public class CallNumbers
    {
        public string CallNum { get; set; }
        public string Description { get; set; }

        public CallNumbers() { }

        public CallNumbers(string callNum, string description)
        {
            CallNum = callNum;
            Description = description;
        }
    }
}

//reference : Beginning Data Structures and Algorithms in C# : Basic Trees. 2018. [Online].
//Available at: https://youtu.be/K0-qs--naUo