using System;
using System.Collections.Generic;
using System.Text;

namespace DeweySystem.FindCalls
{
    public class CallNumbers
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public List<CallNumbers> Children { get; set; }
        public CallNumbers Parent { get; set; }

        public CallNumbers(string id, string label)
        {
            Id = id;
            Label = label;
            Children = new List<CallNumbers>();
        }
    }


}

//reference : Beginning Data Structures and Algorithms in C# : Basic Trees. 2018. [Online].
//Available at: https://youtu.be/K0-qs--naUo