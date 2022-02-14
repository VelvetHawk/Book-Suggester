namespace API.Models.TransferModels
{
    public class WorkDto
    {
        public string Key { get; set; }

        public string Title { get; set; }

        public int? Edition_Count { get; set; }

        public int? Cover_Id { get; set; }

        public string Cover_Edition_Key { get; set; }

        public string[] Subject { get; set; }

        public string[] Ia_Collection { get; set; }

        public bool? LendingLibrary { get; set; }

        public bool? PrintDisabled { get; set; }

        public string Lending_Edition { get; set; }

        public AuthorDto[] Authors { get; set; }

        public string First_Publish_Year { get; set; }

        public string Ia { get; set; }

        public bool? Public_Scan { get; set; }

        public bool? Has_Fulltext { get; set; }

        public AvailabilityDto Availability { get; set; }
    }
}
