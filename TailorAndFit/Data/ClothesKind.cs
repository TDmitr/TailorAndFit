using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    public class ClothesKind : Base<ClothesKind>
    {
        public string Description { get; set; }
        public double Price { get; set; }

        public ClothesKind(string name, string description, double price) : base(name)
        {
            Description = description;
            Price = price;
        }
    }
}
