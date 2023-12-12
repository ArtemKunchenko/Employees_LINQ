namespace Tables
{
    public class Country
    {
        public int CountryId { get; set; }   // Идентификатор страны
        public string CountryName { get; set; } // Название страны

        public Country(int countryId, string countryName)
        {
            CountryId = countryId;
            CountryName = countryName;
        }
    }


}
