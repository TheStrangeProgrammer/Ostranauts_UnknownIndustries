using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownIndustries
{
    public class LootOverride
    {
        public string strName { get; set; }
        public string strTargetLoot { get; set; }

        public string strType;

        public bool bSuppress;

        public bool bNested;

        
        
        public string[] aCOs;
        public string[] aLoots;
    }
}
