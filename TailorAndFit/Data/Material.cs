using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    public class Material:Base<Material>
    {
  
        public string Description { get; set; }

        public List<Repair> Repair
        {
            get
            {
                var res = new List<Repair>();
                foreach (var consist in Consist.Items.Values)
                {
                    if (consist.Material == this)
                    {
                        res.Add(consist.Repair);
                    }
                }
                return res;
            }
        }
        public double Price { get; set; }

        public Material(string name, string description, double price):base(name)
        {
            Description = description;
            Price = price;
        }

        public Material()
        {
            
        }
    }


}
