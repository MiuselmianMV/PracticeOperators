using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOperators
{
    public class City
    {
        private string CityName { get; set; }
        private string CountryName { get; set; }
        private int NumberOfPeople { get; set; }
        private string PhoneCode { get; set; }
        private string Regions { get; set; }

        public City(string CityName, string CountryName, int NumberOfPeople, string PhoneCode, string Regions)
        {
            this.CityName = CityName;
            this.CountryName = CountryName;
            this.NumberOfPeople = NumberOfPeople;
            this.PhoneCode = PhoneCode;
            this.Regions = Regions;
        }

        public void Show()
        {
            Console.WriteLine("Name of the city: {0}", CityName);
            Console.WriteLine("Name of the country: {0}", CountryName);
            Console.WriteLine("Number of people: {0}", NumberOfPeople);
            Console.WriteLine("Phone code: {0}", PhoneCode);
            Console.WriteLine("Regions: {0}", Regions);
        }

        public string GetCityName() { return CityName; }

        public string GetCountryName() { return CountryName; }

        public string GetPhoneNumber() { return PhoneCode; }

        public string GetRegions() { return Regions; }

        public int GetNumberOfPeople() { return NumberOfPeople; }

        public void SetCityName(string cityName) { CityName = cityName; }

        public void SetCountryName(string countryName) { CountryName = countryName; }

        public void SetPhoneNumber(string phoneNumber) { PhoneCode = phoneNumber; }

        public void SetRegions(string regions) { Regions = regions; }

        public void SetNumberOfPeople(int numberOfPeople) { NumberOfPeople = numberOfPeople; }

        public static City operator +(City left, int num)
        {
            left.NumberOfPeople += num;
            return left;
        }

        public static City operator -(City left, int num)
        {
            left.NumberOfPeople -= num;
            return left;
        }

        public static bool operator == (City left, City right)
        {
            return left.NumberOfPeople == right.NumberOfPeople;
        }

        public static bool operator != (City left, City right)
        {
            return left.NumberOfPeople != right.NumberOfPeople;
        }

        public static bool operator > (City left, City right)
        {
            return left.NumberOfPeople > right.NumberOfPeople;
        }

        public static bool operator < (City left, City right)
        {
            return left.NumberOfPeople != right.NumberOfPeople;
        }

        public override string ToString()
        {
            return this.GetNumberOfPeople().ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is City other)
            {
                return this == other;
            }
            return false;
        }
    }
}
