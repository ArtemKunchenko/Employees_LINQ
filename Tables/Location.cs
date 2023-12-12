namespace Tables
{
    public class Location
    {
        public int LocationId { get; set; }       // Идентификатор локации
        public string StreetAddress { get; set; } // Улица и номер дома
        public string City { get; set; }          // Город
        public string StateProvince { get; set; } // Провинция или штат
        public Country Country { get; set; }      // Объект страны, связывающий локацию с соответствующей страной

       public Location(int locationId, string streetAddress, string city, string stateProvince, Country country)
        {
            LocationId = locationId;
            StreetAddress = streetAddress;
            City = city;
            StateProvince = stateProvince;
            Country = country;

        }
    }

}
