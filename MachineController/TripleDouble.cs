using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineController
{
    public class TripleDouble
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString()
        {
            var format = "0.0##";
            return string.Format(@"X{0} Y{1} Z{2}", X.ToString(format), Y.ToString(format), Z.ToString(format));
        }
    }
}
