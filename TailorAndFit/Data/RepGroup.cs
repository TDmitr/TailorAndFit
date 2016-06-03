using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    public class RepGroup:Base<RepGroup>
    {
        public string Description { get; set; }

        //public ClothesKind ClothesKind
        //{
        //    get { return ClothesKind.Items[_clothesId]; }
        //    set { _clothesId = value.Id; }
        //}
        public ClothesKind ClothesKind;
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

       // private Guid _clothesId;


        public RepGroup(string name) : base(name)
        {
            
        }

        public RepGroup()
        {
            
        }

        public RepGroup(string name, string description, ClothesKind clothesKind, double price)
        {
            Name = name;
            Description = description;
            ClothesKind = clothesKind;
            Price = price;
        }

        public override void Add()
        {


        }

        public override void Delete()
        {
            
        }

        public override string ToString() => Name + " " + Description +  " " + Price;
    }
}
