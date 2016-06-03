using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorAndFit
{
    public class Base<T> where T : Base<T>
    {
        public static readonly Dictionary<Guid, T> Items = new Dictionary<Guid, T>();
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public Base() : this("")
        {

        }

        public Base(string name)
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
            Name = name;
        }

        public virtual void Add()
        {
            
        }

        public virtual void Delete()
        {
            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
