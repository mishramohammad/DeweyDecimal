using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweySystem.FindCalls
{
    public class DataLoad
    {
        public CallNumbers LoadDataFromFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var root = JsonConvert.DeserializeObject<CallNumbers>(json);

            return root;
        }

        private CallNumbers FindNodeByCallNum(CallNumbers root, string callNum)
        {
            if (root.CallNum == callNum) return root;

            foreach (var child in root.Children)
            {
                var result = FindNodeByCallNum(child, callNum);
                if (result != null) return result;
            }

            return null;
        }
    }

}
