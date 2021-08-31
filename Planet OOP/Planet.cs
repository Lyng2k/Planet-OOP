using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet_OOP
{
    class Planet
    {
        public Planet()
        {
            
        }

        private string name;
        private double mass;
        private double diameter;
        private double density;
        private double gravity;
        private double rotation_period;
        private double lenght_of_days;
        private double distance_from_sun;
        private double orbital_period;
        private double orbital_velocity;
        private double mean_tempature;
        private double number_of_moons;
        private string ring_system;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

        public double Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }

        public double Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }

        public double Rotation_period
        {
            get
            {
                return rotation_period;
            }
            set
            {
                rotation_period = value;
            }
        }

        public double Lenght_of_days
        {
            get
            {
                return lenght_of_days;
            }
            set
            {
                lenght_of_days = value;
            }
        }

        public double Distance_from_sun
        {
            get
            {
                return distance_from_sun;
            }
            set
            {
                distance_from_sun = value;
            }
        }

        public double Orbital_period
        {
            get
            {
                return orbital_period;
            }
            set
            {
                orbital_period = value;
            }
        }

        public double Orbital_velocity
        {
            get
            {
                return orbital_velocity;
            }
            set
            {
                orbital_velocity = value;
            }
        }

        public double Mean_tempature
        {
            get
            {
                return mean_tempature;
            }
            set
            {
                mean_tempature = value;
            }
        }

        public double Number_of_moons
        {
            get
            {
                return number_of_moons;
            }
            set
            {
                number_of_moons = value;
            }
        }

        public string Ring_system
        {
            get
            {
                return ring_system;
            }
            set
            {
                ring_system = value;
            }
        }
    }
}
