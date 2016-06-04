using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    [Serializable]
    public class RepGroup:Base<RepGroup>
    {
        public string Description { get; set; }


        public List<Repair> Repairs
        {
            get
            {
                List<Repair> res = new List<Repair>();
                res.AddRange(Repair.Items.Values);
                return res;
            }
        }
        public double Price { get; set; }


        public RepGroup(string name) : base(name)
        {
            
        }


        public RepGroup(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString() => Name + " " + Description +  " " + Price;
    }
}
