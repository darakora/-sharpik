using System;
using System.Collections;
using System.Collections.Generic;

namespace LAB_12_13
{
    class FlatEnumerator : IEnumerator<Flat>
    {
        private List<Flat> flats;

        public int index;

        public Flat Current => flats[index];

        object IEnumerator.Current => flats[index];

        public FlatEnumerator(List<Flat> flats)
        {
            this.flats = flats;
            this.index = -1;
        }

        public void Dispose()
        {
            this.flats = null;
        }

        public bool MoveNext()
        {
            return ++index < flats.Count && index >= 0;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
