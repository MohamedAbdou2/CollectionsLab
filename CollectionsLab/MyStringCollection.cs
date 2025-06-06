using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace CollectionsLab
{

    internal class MyStringCollection
    {

        List<string> list;
        public MyStringCollection() { }

        public MyStringCollection(List<string> list) {
            this.list = list;

        }

        public void Add(string item) {
            list.Add(item);

        }

        public void Remove(string item) {
            list.Remove(item);

        }

        public bool Contains(string item)
        {
            return list.Contains(item);

        }

        public void PrintAll()
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

       
    }
}
