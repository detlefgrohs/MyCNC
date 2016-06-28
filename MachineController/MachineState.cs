using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineController
{
    public class MachineState
    {
        public bool UnitsAreMM { get; set; }
        public TripleDouble Minimum { get; set; }
        public TripleDouble Maximum { get; set; }

        public TripleInt StepperPosition { get; set; }
        public TripleDouble StepperIncrement { get; set; }
    
        public TripleInt TargetStepperPosition { get; set; }

        public TripleInt CurrentStepperDelay { get; set; }

        public MachineState()
        {
            UnitsAreMM = false;
            Minimum = new TripleDouble();
            Maximum = new TripleDouble();
            StepperPosition = new TripleInt();
            TargetStepperPosition = new TripleInt();
            CurrentStepperDelay = new TripleInt();
            StepperIncrement = new TripleDouble
            {
                X = 0.0125,
                Y = 0.0125,
                Z = 0.0250
            };
        }


        public override string ToString()
        {
            return string.Format(@"Units: {0}
Minimum: {1}
Maximum: {2}",   UnitsAreMM ? "MM" : "Inches",
                Minimum.ToString(),
                Maximum.ToString()
                );
        }
    }
}
