using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLab
{
    internal class EvenNumberCollection : IEnumerable<int>
    {
        List<int> list;
        public EvenNumberCollection()
        {
            list = new List<int>();
        }
        public EvenNumberCollection(List<int> list)
        {
            this.list = list;
        }


        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    yield return item;
                }
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
