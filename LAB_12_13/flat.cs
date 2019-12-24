using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_12_13
{
    class Flat : IComparable<Flat>
    {
        public string Adress { get; set; }
        public double Square { get; set; }
        public int RoomsCount { get; set; }

        public Flat(string adress, double square, int roomsCount)
        {
            this.Adress = adress;
            this.Square = square;
            this.RoomsCount = roomsCount;
        }

        public override string ToString()
        {
            return Adress + " " + Square + " " + RoomsCount;
        }

        public int CompareTo(Flat other)
        {
            return RoomsCount.CompareTo(other.RoomsCount);
        }


    }
}
