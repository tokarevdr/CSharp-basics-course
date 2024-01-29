using System;

namespace PracticalExercise10
{
    internal class Angle
    {
        private uint degrees;
        private uint minutes;
        private uint seconds;

        public uint Degrees
        {
            get
            {
                return degrees;
            }

            set
            {
                if (value > 360)
                    throw new ArgumentException();

                degrees = value;
            }
        }

        public uint Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                if (value > 60)
                    throw new ArgumentException();

                minutes = value;
            }
        }

        public uint Seconds
        {
            get
            {
                return seconds;
            }

            set 
            {
                if (value > 60)
                    throw new ArgumentException();

                seconds = value; 
            }
        }

        public Angle(uint degrees, uint minutes, uint seconds) 
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        public double ToRadians()
        {
            return (degrees + minutes / 60.0 + seconds / 360.0) / 180.0 * Math.PI;
        }
    }
}
