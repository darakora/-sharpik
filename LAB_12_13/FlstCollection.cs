using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_12_13
{
    class FlstCollection : ICollection<Flat>
    {
        private List<Flat> flats;

        public int Count => flats.Count;

        public bool IsReadOnly => false;

        public FlstCollection()
        {
            flats = new List<Flat>();
        }

        public void Add(Flat item)
        {
            flats.Add(item);
        }

        public void Clear()
        {
            flats.Clear();
        }

        public bool Contains(Flat item)
        {
            return flats.Contains(item);
        }

        public void CopyTo(Flat[] array, int arrayIndex)
        {
            flats.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Flat> GetEnumerator()
        {
            return new FlatEnumerator(flats);
        }

        public bool Remove(Flat item)
        {
            return flats.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FlatEnumerator(flats);
        }
    }
}
