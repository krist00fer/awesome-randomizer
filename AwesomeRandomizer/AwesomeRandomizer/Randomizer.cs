using System;

namespace AwesomeRandomizer
{
    public class Randomizer
    {
        public string GetRandomWord(string sentence)
        {
            if (sentence == string.Empty)
                return string.Empty;

            var words = sentence.Split(' ');
            Random r = new Random(System.DateTime.Now.Millisecond);
            var index = r.Next(0, words.Length);

            return words[index];
        }
    }
}
