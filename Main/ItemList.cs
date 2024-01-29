using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class ItemList
    {
        List<int> _items;

        public ItemList(List<int> items)
        {
            _items = items;
        }

        public List<int> this[int index]
        {
            get
            {
                var validItems = new List<int>();

                foreach (int i in _items)
                {
                    if (i == 0) continue;

                    if (i % index == 0) validItems.Add(i);
                }

                return validItems;
            }
        }
    }
}
