using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOJ_Interactions
{
    class VehicleGenerator
    {
        private ArrayList generatedVehicles;
        private ArrayList vehicleFlags;
        private static char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        public VehicleGenerator()
        {
            generatedVehicles = new ArrayList();
            vehicleFlags = new ArrayList();
            vehicleFlags.Add("None");
            vehicleFlags.Add("Gang Affiliated");
            vehicleFlags.Add("Registered Firearm");
            vehicleFlags.Add("Registered Firearm");
            vehicleFlags.Add("RO Suspended License");
            vehicleFlags.Add("RO Expired License");
            vehicleFlags.Add("Previous Evasion");
            vehicleFlags.Add("Prior Violent Felony");
        }
        public Vehicle generateVehicle(string licensePlate, string stateRegistration, string vin, string makeModel)
        {
            foreach (Vehicle vehicle in generatedVehicles)
            {
                if ((vehicle.LicensePlate.CompareTo(licensePlate) == 0 && vehicle.StateRegistration.CompareTo(stateRegistration) == 0))
                {
                    if (vehicle.LicensePlate.CompareTo("N/A") != 0 || vehicle.StateRegistration.CompareTo("N/A") != 0)
                        return vehicle;
                }
                else if (vehicle.Vin.CompareTo(vin) == 0)
                {
                    if (vehicle.Vin.CompareTo("N/A") != 0)
                        return vehicle;
                }
            }

            if(vin.Length == 0)
                vin = generateVIN();
            if (licensePlate.Length == 0)
                licensePlate = "N/A";
            if (stateRegistration.Length == 0)
                stateRegistration = "N/A";
            if (makeModel.Length == 0)
                makeModel = "N/A";


            Vehicle newVehicle = new Vehicle(licensePlate, stateRegistration, makeModel, vin, generateInsurance(), generateRegistration(), generateFlag());
            generatedVehicles.Add(newVehicle);
            return newVehicle;
        }
        private string generateInsurance()
        {
            Random random = new Random();
            int num = random.Next(100);
            return (num <= 88) ? "Valid" : "Expired";
        }
        private string generateRegistration()
        {
            Random random = new Random();
            int num = random.Next(100);
            return (num <= 90) ? "Valid" : "Expired";
        }
        private string generateFlag()
        {
            Random random = new Random();
            int num = random.Next(100);
            return (num <= 85) ? "None" : (string) vehicleFlags[random.Next(vehicleFlags.Count)];
        }
        private string generateVIN()
        {
            string generatedVin = "";
            Random random = new Random();
            for(int i = 0; i < 17; i++)
            {
                if(random.Next(100) <= 50)
                    generatedVin += random.Next(9).ToString();
                else
                    generatedVin += alphabet[random.Next(alphabet.Length)];   
            }
            return generatedVin;
        }

    }

    //Helper Class
    class Vehicle
    {
        public string LicensePlate { get; set; }
        public string StateRegistration { get; set; }
        public string Vin { get; set; }
        public string MakeModel { get; set; }
        public string InsuranceStatus { get; set; }
        public string RegistrationStatus { get; set; }
        public string Flag { get; set; }

        public Vehicle(string licensePlate, string stateRegistration, string makeModel, string vin, string insuranceStatus, string registrationStatus, string flag)
        {
            this.LicensePlate = licensePlate;
            this.StateRegistration = stateRegistration;
            this.MakeModel = makeModel;
            this.Vin = vin;
            this.InsuranceStatus = insuranceStatus;
            this.RegistrationStatus = registrationStatus;
            this.Flag = flag;
        }
    }
    
}
