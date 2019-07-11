namespace MCSeeds.models
{
    public class seed
    {
        public int SeedID { get; set; }

        public string SeedValue { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ImageID { get; set; }

        public int versionID { get; set; }
    }
}