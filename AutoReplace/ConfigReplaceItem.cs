using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AutoReplace
{
    [JsonObject(MemberSerialization.OptIn)]
    [Serializable()]
    public class ConfigReplaceItem
    {
        [JsonProperty()]
        public string mOld { get; set; }

        [JsonProperty()]
        public string mNew { get; set; }

        public ConfigReplaceItem()
        {

        }
        public ConfigReplaceItem(string pOld,string pNew)
        {
            mOld = pOld;
            mNew = pNew;
        }
    }
}
