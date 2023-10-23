using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift
{
    internal class Hero

    {
        public string Type { get; set; }
        List<Item> Items { get; set; } = new List<Item>();
        public Hero(String Type, Item item)
        {
            this.Type = Type;
            this.Items.Add(item);
        }
        public void AddItem(Item item)
        {
            Items.Add(item);

        }

        public List<Item> GetItems() { return Items;}

    }
}
