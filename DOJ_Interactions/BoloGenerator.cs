using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOJ_Interactions
{
    class BoloGenerator
    {
        ArrayList reasons;
        ArrayList colors;
        public BoloGenerator()
        {
            reasons = new ArrayList();
            colors = new ArrayList();
            colors.Add("Red");
            colors.Add("Black");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("White");
            colors.Add("Orange");
            colors.Add("Pink");
            colors.Add("Silver");
            colors.Add("Beige");
        }
        public BoloVehicle generateVehicle()
        {
            BoloVehicle newVehicle = new BoloVehicle(generateColor(), generateType(), generateDoors(), "");
            return newVehicle;
        }
        private string generateDoors()
        {
            Random random = new Random();
            int num = random.Next(100);
            return (num <= 75) ? "4 Door" : "2 Door";
        }
        private string generateType()
        {
            Random random = new Random();
            int num = random.Next(100);
            if (num <= 15)
            {
                return "Motorcycle";
            }
            else if (num <= 55)
            {
                return "Sedan";
            }
            else if (num <= 68)
            {
                return "Pickup";
            }
            else if (num <= 100)
            {
                return "SUV";
            }
            else
                return "Sedan";
        }
        private string generateColor()
        {
            Random random = new Random();
            return (string) colors[random.Next(colors.Count)];
        }
    }

    class BoloVehicle
    {
        public string timeBolo { get; set; }
        public string color { get; set; }
        public string type { get; set; }
        public string doorCount { get; set; }
        public string reason { get; set; }

        public BoloVehicle(string color, string type, string doorCount, string reason)
        {
            this.timeBolo = DateTime.Now.ToString("h:mm:ss tt");
            this.color = color;
            this.type = type;
            this.doorCount = doorCount;
            this.reason = reason;
        }
        override
        public string ToString()
        {
            if (type.CompareTo("Motorcycle") == 0)
            {
                return (timeBolo + ": "+ color + " " + type).ToUpper();
            }
            else
                return (timeBolo + ": " + doorCount + " " + color + " " + type).ToUpper();
        }
        public bool Equals(BoloVehicle vehicle)
        {
            bool different = false;

            if (!color.Equals(vehicle.color))
                different = true;
            else if (!type.Equals(vehicle.type))
                different = true;
            else if (!doorCount.Equals(vehicle.doorCount))
                different = true;

            return !different;
        }
    }
}
