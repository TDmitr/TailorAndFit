using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    [Serializable]
    public class Consist : Base<Consist>
   {
        private Guid _materialId;

        public Material Material
        {
            get { return Material.Items[_materialId]; }
            set { _materialId = value.Id; }
        }

        private Guid _repairId;

        public Repair Repair
        {
            get { return Repair.Items[_repairId]; }
            set { _repairId = value.Id; }
        }

        public Consist(Material m, Repair r)
        {
            Material = m;
            Repair = r;
        }

        public override string ToString()
        {
            return Repair + " " + Material;
        }
    }
}
