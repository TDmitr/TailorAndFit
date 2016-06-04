using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailorAndFit
{
    public static class IControl<T>
    {
        public static void RefreshTable(DataGridView table)
        {
            table.DataSource = Account.Items.Values.ToList();
        }

        public static void RefreshTable(DataGridView table, bool isDone)
        {
            IEnumerable<Repair> query = from item in Repair.Items.Values.ToList()
                where item.IsDone == isDone
                select item;
            table.DataSource = query.ToList();
        }

        public static void Serialize(string file, Dictionary<Guid,T> dictionary )
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                // сериализуем весь массив people
                formatter.Serialize(fs, dictionary);
                MessageBox.Show("Data is saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static Dictionary<Guid, T> Deserialize(string file)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                Dictionary<Guid, T> deserilizePeople = (Dictionary<Guid, T>)formatter.Deserialize(fs);

                return deserilizePeople;
            }
        }


        public static void Import(string file, string consist, string materials, DataGridView table, bool isDone)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Title = "Repair File";
                // f.ShowDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    file = f.FileName;
                    Repair.Items = Repair.Deserialize(file);
                    // RefreshTable();

                    OpenFileDialog f2 = new OpenFileDialog();
                    f2.Title = "Consist File";
                    // f.ShowDialog();
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        consist = f2.FileName;
                        Consist.Items = Consist.Deserialize(consist);
                        //RefreshTable();

                        OpenFileDialog f3 = new OpenFileDialog();
                        f3.Title = "Materials File";
                        // f.ShowDialog();
                        if (f3.ShowDialog() == DialogResult.OK)
                        {
                            consist = f3.FileName;
                            Material.Items = Material.Deserialize(materials);
                            //RefreshTable();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshTable(table,isDone);
        }

        public static Dictionary<Guid,T> Import(string file, Dictionary<Guid,T> dictionary )
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                // f.ShowDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    file = f.FileName;
                    dictionary = Deserialize(file);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dictionary;

            
        }

        public static string Export(string file, Dictionary<Guid,T> dictionary )
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = f.FileName;
                Serialize(file,dictionary);
            }

            return file;
        }





    }
}
