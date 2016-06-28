using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineController
{
    public class MachineController
    {
        private MachineState _MachineState = null;


        public bool IsMoving
        {
            get { return !_MachineState.StepperPosition.Equals(_MachineState.TargetStepperPosition); }
        }


        public MachineController()
        {
            _MachineState = new MachineState {};

            InitializeGPIO();
            MotorsEnabled = false;
        }

        public void MoveToOrigin()
        {
            // Move the Z Axis to it's limit first to move the tool out of the way
            MoveToOrigin(Axis.Z);
            // Now move the X & Y axis to end stops
            MoveToOrigin(Axis.X);
            MoveToOrigin(Axis.Y);
        }

        public void MoveToOrigin(Axis axis)
        {
            if (MotorsEnabled)
            {
                while (!GetEndStopState(axis))
                {

                }

                
                // Now set the position to the origin
                switch (axis)
                {
                    case Axis.X:
                        _MachineState.StepperPosition.X = 0;
                        break;
                    case Axis.Y:
                        _MachineState.StepperPosition.Y = 0;
                        break;
                    case Axis.Z:
                        _MachineState.StepperPosition.Z = 0;
                        break;
                }
            }
        }

        public string GetEndStopStatus()
        {
            return string.Format(@"X:{0} Y:{1} Z:{2}",
                GetEndStopState(Axis.X) ? "1" : "0",
                GetEndStopState(Axis.Y) ? "1" : "0",
                GetEndStopState(Axis.Z) ? "1" : "0");
        }

        public bool GetEndStopState(Axis axis)
        {
            return false;
        }
        
        public bool MotorsEnabled
        {
            get { return false; }
            set { }
        }

        public void SetStepperDirection(Axis axis, Direction direction)
        {
            if (GetStepperDirection(axis) != direction)
            {
                
            }
        }

        public Direction GetStepperDirection(Axis axis)
        {
            
            return Direction.Forward;
        }

        public void StepStepper(Axis axis, Direction direction)
        {   // Make sure we are going to go the right way...
            SetStepperDirection(axis, direction);

            if ((direction == Direction.Backward) ||
                (!GetEndStopState(axis)))
            {   // Only step if we are not at the end-stop or we are backing up...
                // Now step by setting the GPIO pin high...

                // Wait a minimum amount of time...
                // Not sure if this is necessary...

                // Now sett the GPIO low...

            }
        }

        private void InitializeGPIO()
        {
            // Stepper Motor Enabled

            // Endstop X

            // Endstop Y

            // Endstop Z 

            // X Direction & Step

            // Y Direction & Step

            // Z Direction & Step   

        }

        public enum Axis
        {
            X,
            Y,
            Z
        }

        public enum Direction
        {
            Forward,
            Backward
        }

        /*

        Maximum stepper rate for each axis.

        3 Speeds for each axis:
        1) Move to Origin - Fast as possible (600 steps/sec) (3 RPM)
        2) Jog Speed (settable)
        3) Tool speed (settable)

        There will be an interrupt/thread that will run at the maximum rate * 2 to allow for a square wave
                        _   _                     
        1200 / sec -> _| |_| |

        Move to Origin speed would be 1 cycle on and 1 cycle off.

        Other speed would be deciding the factor of how my pulses a second and then setting the on / off cycles per axis.

        Move to origin (On = 1 & Off = 1)


        So if 1 revolution is 20 mm to maximum moving rate is 60 mm/sec

        So if maximum is 60 mm/sec

        60 mm/sec => On 1 / Off 1 (100% speed) Pulse at 600 Hz (1200/2 => 600)

        30 mm/sec => On 2 / Off 2 ( 50% speed) Pulse at 300 Hz (1200/4 => 300)
                     On 1 / Off 3
                     On 3 / Off 1

        15 mm/sec => On 4 / Off 4 ( 25% speed) Pulse at 150 Hz (1200/8 => 150)

         6 mm/sec => On ? / Off ? ( 10% speed) Pulse at  60 Hz (1200/20 =? 60)       

        */
    }
}
