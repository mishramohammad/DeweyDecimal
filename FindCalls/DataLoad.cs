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

    }

}
