using System;

namespace Lab_1_task_1
{
    public class address
    {
        private string postalCode;
        private string nation;
        private string cityName;
        private string streetName;
        private string buildingNumber;
        private string unitNumber;

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string Nation
        {
            get { return nation; }
            set { nation = value; }
        }

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        public string BuildingNumber
        {
            get { return buildingNumber; }
            set { buildingNumber = value; }
        }

        public string UnitNumber
        {
            get { return unitNumber; }
            set { unitNumber = value; }
        }

        public address(string postalCode, string nation, string cityName, string streetName, string buildingNumber, string unitNumber)
        {
            this.postalCode = postalCode;
            this.nation = nation;
            this.cityName = cityName;
            this.streetName = streetName;
            this.buildingNumber = buildingNumber;
            this.unitNumber = unitNumber;
        }

        public void DisplayAddress()
        {
            Console.WriteLine("Custom Address:");
            Console.WriteLine($"Postal Code: {PostalCode}");
            Console.WriteLine($"Nation: {Nation}");
            Console.WriteLine($"City: {CityName}");
            Console.WriteLine($"Street: {StreetName}");
            Console.WriteLine($"Building Number: {BuildingNumber}");
            Console.WriteLine($"Unit Number: {UnitNumber}");
        }
    }
}