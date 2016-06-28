using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineController
{
    public class TripleInt
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
        {
            return string.Format(@"X{0} Y{1} Z{2}", X.ToString(), Y.ToString(), Z.ToString());
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || GetType() != obj.GetType())
                return false;

            TripleInt tripleInt = (TripleInt) obj;
            return (X == tripleInt.X) &&
                   (Y == tripleInt.Y) &&
                   (Z == tripleInt.Z);
        }

        public override int GetHashCode()
        {
            return X ^ Y ^ Z;
        }
    }
}
