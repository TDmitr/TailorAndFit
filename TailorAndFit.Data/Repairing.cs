using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit.Data
{
    public class Repairing : Base<Repairing>
    {
        private Guid _groupId;

        public Account Account
        {
            get { return Account.Items[_groupId]; }
            set { _groupId = value.Id; }
        }

        private Guid _subjectId;

        public Repair Subject
        {
            get { return Repair.Items[_subjectId]; }
            set { _subjectId = value.Id; }
        }

        public Repairing(Account g, Repair s)
        {
            Account = g;
            Subject = s;
        }

        public override string ToString()
        {
            return Subject + "" + Account;
        }
    }
}
