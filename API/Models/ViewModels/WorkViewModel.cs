namespace API.Models.ViewModels
{
    public class WorkViewModel
    {
        public string Key { get; set; }

        public string Title { get; set; }

        public int? EditionCount { get; set; }

        public int? CoverId { get; set; }

        public string CoverEditionKey { get; set; }

        public string[] Subject { get; set; }

        public string[] IaCollection { get; set; }

        public bool? LendingLibrary { get; set; }

        public bool? PrintDisabled { get; set; }

        public string LendingEdition { get; set; }

        public AuthorViewModel[] Authors { get; set; }

        public string FirstPublishYear { get; set; }

        public string Ia { get; set; }

        public bool? PublicScan { get; set; }

        public bool? HasFullText { get; set; }

        public AvailabilityViewModel Availability { get; set; }
    }
}
