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
            Map.Add("smile", "");
        }

        public string GetEmoticonFilename(string emo)
        {
            if(Map.Keys.Contains(emo))
            {
                return Map[emo];
            }
            throw new Exception("Key not found");
        }
    }
}
