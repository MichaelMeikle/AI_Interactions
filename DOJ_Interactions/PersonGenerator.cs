using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOJ_Interactions
{
    class PersonGenerator
    {
        //List of previously searched people
        ArrayList generatedPeople = new ArrayList();
        //Occupations List
        ArrayList occupations = new ArrayList();

        public PersonGenerator()
        {
            occupations.Add("Store Clerk");
            occupations.Add("Assistant");
            occupations.Add("Unknown");
            occupations.Add("Firefighter");
            occupations.Add("Police Officer");
            occupations.Add("Lawyer");
            occupations.Add("Teacher");
            occupations.Add("Accountant");
            occupations.Add("Unemployed");
            occupations.Add("Paralegal");
            occupations.Add("Salesman");
        }
        public Person generatePersonObj(string name, string dob)
        {
            //Returns previously searched person based off of name/dob sent
            foreach (Person person in generatedPeople)
            {
                if(name.CompareTo(person.Name) == 0 && dob.CompareTo(person.DOB) == 0)
                {
                    return person;
                }
            }
            Person newPerson = new Person(name, dob, generateOccupation(), generateAddress(), generateLicense(), generateCitations(), generateWarrantStatus());
            generatedPeople.Add(newPerson);
            return newPerson;
        }
        //Helper methods
        private string generateOccupation()
        {
            Random gen = new Random();
            int num = gen.Next(occupations.Count);
            return (string) occupations[num];
        }
        private string generateAddress()
        {
            return "Unknown";
        }
        private string generateLicense()
        {
            Random gen = new Random();
            int num = gen.Next(100);
            if (num <= 85)
            {
                return "Valid";
            }
            else if (85 < num && num < 90)
            {
                return "Suspended";
            }
            else if (num >= 90)
            {
                return "Expired";
            }
            else
            {
                return "Valid";
            }
        }
        private int generateCitations()
        {
            Random gen = new Random();
            int num = gen.Next(100);
            if (num <= 90)
            {
                return gen.Next(10);
            }
            else
                return gen.Next(25);
        }
        private string generateWarrantStatus()
        {
            Random gen = new Random();
            int num = gen.Next(100);
            if(num <= 90)
            {
                return "Clear";
            }
            else
            {
                return "Active Warrant";
            }
        }
    }
    //Helper Class
    class Person
    {
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string LicenseStatus { get; set; }
        public int CitationCount { get; set; }
        public string WarrantStatus { get; set; }

        public Person(string name, string DOB, string occupation, string address, string licenseStatus, int citationCount, string warrantStatus)
        {
            Name = name;
            this.DOB = DOB;
            Occupation = occupation;
            Address = address;
            LicenseStatus = licenseStatus;
            CitationCount = citationCount;
            WarrantStatus = warrantStatus;
        }
    }
}
