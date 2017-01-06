using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmoticonMap
    {
        private static readonly Dictionary<string, string> Map = new Dictionary<string, string>();

        static EmoticonMap()
        {
            Map.Add("laugh", "bigsmile");
            Map.Add("sad", "sadsmile");
            Map.Add("worry", "worried");
            Map.Add("think", "thinking");
            Map.Add("blush", "blushing");
            Map.Add("wasntme", "itwasntme");
            Map.Add("cry", "crying");
            Map.Add("wonder", "wondering");
            Map.Add("clap", "clapping");
            Map.Add("puke", "puking");
            Map.Add("dance", "dancing");
        }

        public static string GetEmoticonFilename(string emo)
        {
            if(Map.Keys.Contains(emo))
            {
                return Map[emo];
            }
            return emo;
        }
    }
}
