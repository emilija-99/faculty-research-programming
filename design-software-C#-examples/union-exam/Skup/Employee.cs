using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal record Momento {string Name, int Age, string Phone };
namespace Skup
{
    public class Employee
    {

        public string Name { get; set; }
        public int Age { get; set; }    
        public string Phone { get; set; }

        public Momento Create() => new Momento(Name, Age, Phone);

        public void restore(Momento momento)
        {
            Name = momento.Name;    
            Age = momento.Age;
            Phone= momento.Phone;
        }
    }
}
