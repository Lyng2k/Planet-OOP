using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>();

            Planet Merkur = new Planet {Name = "Merkur", Mass = 0.330, Diameter =  4879, Density = 5427, Gravity = 3.7, Rotation_period = 1407.6, Lenght_of_days = 4222.6, Distance_from_sun = 57.9, Orbital_period = 88, Orbital_velocity = 47.4, Mean_tempature = 167, Number_of_moons = 0, Ring_system = "No"};
            Planet Jorden = new Planet {Name = "Jorden", Mass =  5.97, Diameter = 12756, Density = 5514, Gravity = 9.8, Rotation_period = 23.9, Lenght_of_days = 24, Distance_from_sun = 149.6, Orbital_period = 365.2, Orbital_velocity = 29.8, Mean_tempature = 15, Number_of_moons = 1, Ring_system = "No"};
            Planet Mars = new Planet {Name = "Mars", Mass = 0.642, Diameter = 6792, Density = 3933, Gravity = 3.7, Rotation_period = 24.6, Lenght_of_days = 24.7, Distance_from_sun = 227.9, Orbital_period = 687.0, Orbital_velocity = 24.1, Mean_tempature = -65, Number_of_moons = 2, Ring_system = "No" };
            Planet Jupiter = new Planet {Name = "Jupiter", Mass = 1898, Diameter = 142.984, Density = 1326, Gravity = 23.1, Rotation_period = 9.9, Lenght_of_days = 9.9, Distance_from_sun = 778.6, Orbital_period = 4331, Orbital_velocity = 13.1, Mean_tempature = -110, Number_of_moons = 67, Ring_system = "Yes"};
            Planet Saturn = new Planet {Name = "Saturn", Mass =  568, Diameter = 120536, Density = 687, Gravity = 9.0, Rotation_period = 10.7, Lenght_of_days = 10.7, Distance_from_sun = 1433.5, Orbital_period = 10747, Orbital_velocity = 9.7, Mean_tempature = -140, Number_of_moons = 62, Ring_system = "Yes"};
            Planet Uranus = new Planet {Name = "Uranus",  Mass = 86.8, Diameter = 51118, Density = 1271, Gravity = 8.7, Rotation_period = -17.2, Lenght_of_days = 17.2, Distance_from_sun = 2872.5, Orbital_period = 30589, Orbital_velocity = 6.8, Mean_tempature = -195, Number_of_moons = 27, Ring_system = "Yes"};
            Planet Neptun = new Planet {Name = "Neptun", Mass =  102, Diameter = 49528, Density = 1638, Gravity = 11.0, Rotation_period = 16.1, Lenght_of_days = 16.1, Distance_from_sun = 4495.1, Orbital_period = 59.8, Orbital_velocity = 5.4, Mean_tempature = -200, Number_of_moons = 14, Ring_system = "Yes"};
            Planet Pluto = new Planet {Name = "Pluto",  Mass = 0.0146, Diameter = 2370, Density = 2095, Gravity = 0.7, Rotation_period = -153.3, Lenght_of_days = 153.3, Distance_from_sun = 5906.4, Orbital_period = 90.56, Orbital_velocity = 4.7, Mean_tempature = -225, Number_of_moons = 5, Ring_system = "No"};
            Planet Venus = new Planet { Name = "Venus", Mass = 4.87, Diameter = 12104, Density = 5243, Gravity = 8.9, Rotation_period = -5832.5, Lenght_of_days = 2802.0, Distance_from_sun = 108.2, Orbital_period = 224.7, Orbital_velocity = 35.0, Mean_tempature = 464, Number_of_moons = 0, Ring_system = "No" };

            planets.Add(Merkur);
            planets.Add(Jorden);
            planets.Add(Mars);
            planets.Add(Jupiter);
            planets.Add(Saturn);
            planets.Add(Uranus);
            planets.Add(Neptun);
            planets.Add(Pluto);

            planets.Insert(1, Venus);
            planets.RemoveAt(8);
            planets.Add(Pluto);

            planets.Clear();

            
            foreach(Planet name in planets)
            {
                Console.WriteLine(name.Name);
            }
            Console.WriteLine(planets.Count + "\r\n");
            
            List<Planet> planetsv2 = new List<Planet>();

            planetsv2.Add(Merkur);
            planetsv2.Add(Jorden);
            planetsv2.Add(Mars);
            planetsv2.Add(Jupiter);
            planetsv2.Add(Saturn);
            planetsv2.Add(Uranus);
            planetsv2.Add(Neptun);
            planetsv2.Add(Pluto);
            planetsv2.Insert(1, Venus);
            
            foreach(Planet name in planetsv2)
            {
                if (name.Mean_tempature < 0)
                {
                    Console.WriteLine(name.Name);
                }
            }
            Console.WriteLine("\r\n");

            List<Planet> planetsv3 = new List<Planet>();

            planetsv3.Add(Merkur);
            planetsv3.Add(Jorden);
            planetsv3.Add(Mars);
            planetsv3.Add(Jupiter);
            planetsv3.Add(Saturn);
            planetsv3.Add(Uranus);
            planetsv3.Add(Neptun);
            planetsv3.Add(Pluto);
            planetsv3.Insert(1, Venus);
            

            foreach (Planet name in planetsv3)
            {
                if (name.Diameter > 10000)
                {
                    if(name.Diameter <50000)
                    {
                        Console.WriteLine(name.Name + " ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
