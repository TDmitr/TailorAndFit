using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    public class Repair : Base<Repair>
    {

        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public Account Account { get; set; }
        public ClothesKind Clothes { get; set; }
        public RepGroup RepGroup { get; set; }
        public double Price { get; set; }

        public List<Material> Material
        {
            get
            {
                var res = new List<Material>();
                foreach (var consist in Consist.Items.Values)
                {
                    if (consist.Repair == this)
                    {
                        res.Add(consist.Material);
                    }
                }
                return res;
            }
        }

        public Repair()
        {
            
        }

        public Repair(string name, DateTime dateTime, string description, Account account, RepGroup group, ClothesKind clothes) : base(name)
        {
            Name = name;
            Date = dateTime;
            Description = description;
            IsDone = false;
            Account = account;
            RepGroup = group;
            Clothes = clothes;
            Price = CalculatePrice(group, clothes);
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public double CalculatePrice(RepGroup g, ClothesKind k )
        {
            return g.Price + k.Price;
        }
    }
}
