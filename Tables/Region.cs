namespace Tables
{
    public class Region
    {
        public int RegionId { get; set; }     // Идентификатор региона
        public string RegionName { get; set; } // Название региона

        public Region(int regionId, string regionName) 
        { 
            RegionId = regionId;
            RegionName = regionName;
        }
    }

}