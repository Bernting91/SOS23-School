using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inlämningsuppgift
{
    internal class Location
    {
        public string Hideout { get; set; }
        public Item Loot { get; set; }
        public Location(String hideout, Item loot)
        {
            this.Hideout = hideout;
            this.Loot = loot;
        }
        public Item getLoot()
        {
            return this.Loot;
        }


    }
}
