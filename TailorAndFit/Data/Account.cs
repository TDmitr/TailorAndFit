using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    public class Account : Base<Account>
    {
        //public int StudentCount { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AccountDate { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }


        public Account(string name) : base(name)
        {

        }

        public Account()
        {
            
        }

        public Account(string personName, string personSurname, DateTime birth, string email, string mobile)
        {
            PersonSurname = personSurname;
            PersonName = personName;
            Name = PersonName + " " + PersonSurname;
            BirthDate = birth;
            AccountDate = DateTime.Today;
            Email = email;
            MobilePhone = mobile;
        }


        public List<Repair> Subjects
        {
            get
            {
                var res = new List<Repair>();
                foreach (var repairing in Repairing.Items.Values)
                {
                    if (repairing.Account == this)
                    {
                        res.Add(repairing.Repair);
                    }
                }
                return res;
            }
        }

        public override string ToString()
        {
            return Name + " "
                   + PersonName + " "
                   + PersonSurname + " "
                   + BirthDate + " "
                   + AccountDate + " "
                   + Email + " "
                   + MobilePhone;
        }
    }
}