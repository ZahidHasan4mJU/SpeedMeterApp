using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedometerApp5
{
    class Vehicle
    {
        public string Name { private get; set; }
        public string RegNo { private get; set; }
        private double speed;
        private double minSpeed;
        private double maxSpeed;
        private double totalSpeed;
        private double count;
        private double avg;

        public Vehicle(string Name, string RegNo):this()
        {
            this.Name = Name;
            this.RegNo = RegNo;
        }

        public Vehicle()
        {
            totalSpeed = 0;
            minSpeed = 0;
            maxSpeed = 0;
            count = 0;

        }

        public double Speed
        {
            set
            {
                speed = value;

            }
            get
            {
                return speed;
            }
        }

        public double getMinSpeed()
        {
            if (speed < minSpeed || minSpeed == 0)
            {
                minSpeed = speed;
            }
            return minSpeed;
        }

        public double getMaxSpeed()
        {
            if (speed > maxSpeed)
            {
                maxSpeed = speed;
            }
            return maxSpeed;
        }

        public void incrementCount()
        {
            count++;
        }

        public double getTotal()
        {
            totalSpeed += speed;
            return totalSpeed;
        }

        public double getAverage()
        {
            avg = totalSpeed / count;
            return avg;
        }


    }
}
