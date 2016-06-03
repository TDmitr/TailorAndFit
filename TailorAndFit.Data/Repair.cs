using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit.Data
{
    public class Repair : Base<Repair>
    {
        public Repair(string name) : base(name)
        {

        }

        public List<Account> Account
        {
            get
            {
                var res = new List<Account>();
                foreach (var studing in Repairing.Items.Values)
                {
                    if (studing.Subject == this)
                    {
                        res.Add(studing.Account);
                    }
                }
                return res;
            }
        }
    }
}
