using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    public class Repairing : Base<Repairing>
    {
        private Guid _accountId;

        public Account Account
        {
            get { return Account.Items[_accountId]; }
            set { _accountId = value.Id; }
        }

        private Guid _repairId;

        public Repair Repair
        {
            get { return Repair.Items[_repairId]; }
            set { _repairId = value.Id; }
        }

        public Repairing(Account a, Repair r)
        {
            Account = a;
            Repair = r;
        }

        public override string ToString()
        {
            return Repair + " " + Account;
        }
    }
}
