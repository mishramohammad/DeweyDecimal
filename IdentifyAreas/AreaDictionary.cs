using System;
using System.Collections.Generic;
using System.Linq;

namespace DeweySystem.IdentifyAreas
{
    public class AreaDictionary
    {
        public static Dictionary<string, string> newAreas = new Dictionary<string, string>();
        public static Dictionary<string, string> areas = new Dictionary<string, string>();

        public Dictionary<string, string> GetAreaDict()
        {
            return areas;
        }

        public Dictionary<string, string> GetNewDict()
        {
            return newAreas;
        }

        public void AddAreas()
        {
            areas.Add("000", "General Knowledge");
            areas.Add("100", "Philosophy & Psycology");
            areas.Add("200", "Religion");
            areas.Add("300", "Social Sciences");
            areas.Add("400", "Languages");
            areas.Add("500", "Science");
            areas.Add("600", "Technology");
            areas.Add("700", "Arts & Recreation");
            areas.Add("800", "Literature");
            areas.Add("900", "History & Geography");
        }

        public Tuple<List<string>, List<string>> GenerateQuestion()
        {
            Random rand = new Random();
            var keys = new List<string>(areas.Keys);
            var values = new List<string>(areas.Values);

            var questionKeys = new List<string>();
            var questionValues = new List<string>();

            if (keys.Count < 4)
            {
                throw new InvalidOperationException("Not enough to generate a question.");
            }

            for (int i = 0; i < 4; i++)
            {
                int index = rand.Next(keys.Count);
                questionKeys.Add(keys[index]);
                questionValues.Add(areas[keys[index]]);
                keys.RemoveAt(index);
                values.RemoveAt(index);
            }

            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(values.Count);
                questionValues.Add(values[index]);
                values.RemoveAt(index);
            }

            return new Tuple<List<string>, List<string>>(questionKeys, questionValues.OrderBy(x => rand.Next()).ToList());
        }

    }
}

//code attribute: Rath, M. 2020. Using List tuples in c#. [Online]. [Acessed: 20 November 2023].
//reference: https://blog.matrixpost.net/using-list-tuples-in-c/

//reference: https://stackoverflow.com/questions/69897203/match-the-columns-using-a-data-dictionary-in-c-sharp-winform
