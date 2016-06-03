using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit.Data
{
    public class Account : Base<Account>
    {
        public int StudentCount { get; set; }

        public Account(string name) : base(name)
        {

        }

        public List<Repair> Subjects
        {
            get
            {
                var res = new List<Repair>();
                foreach (var studing in Repairing.Items.Values)
                {
                    if (studing.Account == this)
                    {
                        res.Add(studing.Subject);
                    }
                }
                return res;
            }
        }
    }
}
