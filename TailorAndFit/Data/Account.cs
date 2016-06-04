using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    [Serializable]
    public class Account : Base<Account>
    {
 
        public string PersonName { get; set; }

        public string PersonSurname { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime AccountDate { get; set; }

        public string Email { get; set; }

        public string MobilePhone { get; set; }

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

        public static IEnumerable<Account> SearchByPersonName(string value)
        {
            return from item in Items.Values.ToList()
                   where item.PersonName == value
                   select item;
        }

        public static IEnumerable<Account> SearchBySurname(string value)
        {
            return from item in Items.Values.ToList()
                   where item.PersonSurname == value
                   select item;
        }

        public static IEnumerable<Account> SearchByBirthday(DateTime a, DateTime b)
        {
            return from item in Items.Values.ToList()
                    where item.BirthDate > a && item.BirthDate < b
                    select item;
        }

        public static IEnumerable<Account> SearchByAccDate(DateTime a, DateTime b)
        {
            return from item in Items.Values.ToList()
                   where item.AccountDate > a && item.AccountDate < b
                   select item;
        }

        public static IEnumerable<Account> SearchByEmail(string value)
        {
            return from item in Items.Values.ToList()
                   where item.Email == value
                   select item;
        }

        public static IEnumerable<Account> SearchByPhone(string value)
        {
            return from item in Items.Values.ToList()
                   where item.MobilePhone == value
                   select item;
        }

    }
}