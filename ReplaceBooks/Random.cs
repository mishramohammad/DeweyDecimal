using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeweySystem.ReplaceBooks

{
    //generate random call numbers
    public class Random
    {
        private static System.Random random = new System.Random();
        ListClass listClass = new ListClass();

        //reference
        //URL: https://youtu.be/Zql7tz5Pzfg
        public string GenerateRandomNo(int stringLength)
        {
            //generate random String
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var randomString = new string(Enumerable.Repeat(allowedChars, stringLength)
                .Select(a => a[random.Next(a.Length)]).ToArray());

            //generate random numbers
            var randomNumber1 = random.Next(100, 999);
            var randomNumber2 = random.Next(10, 99);

            //make a call number
            string randomNumber = randomNumber1 + "." + randomNumber2 + " " + randomString;
            listClass.GetNoList().Add(randomNumber); 

            return randomNumber;
        }
    }
}
