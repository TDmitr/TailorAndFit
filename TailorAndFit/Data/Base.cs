using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailorAndFit
{
    [Serializable]
    public class Base<T> where T : Base<T>
    {
        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();

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

        public static void Serialize(string file)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                // сериализуем весь массив people
                formatter.Serialize(fs, Items);
                MessageBox.Show("Data is saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static Dictionary<Guid, T> Deserialize(string file)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                Dictionary<Guid, T> deserilizePeople = (Dictionary<Guid, T>) formatter.Deserialize(fs);

                return deserilizePeople;
            }
        }

        public static  IEnumerable<T> SearchByName(string value)
        {
            return  from item in Items.Values.ToList()
                           where item.Name == value
                           select item;
            //dataGridViewRep.DataSource = query.ToList();
        }

    }
}
