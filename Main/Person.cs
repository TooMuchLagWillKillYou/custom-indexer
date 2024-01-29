using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public object this[string propertyName]
        {
            get
            {
                return this.GetType()
                    .GetProperty(propertyName)
                    .GetValue(this);
            }
        }
    }
}
