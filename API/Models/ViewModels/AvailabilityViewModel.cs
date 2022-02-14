namespace API.Models.ViewModels
{
    public class AvailabilityViewModel
    {
        public string Status { get; set; }

        public bool? AvailableToBrowse { get; set; }

        public bool? AvailableToBorrow { get; set; }

        public bool? AvailableToWaitlist { get; set; }

        public bool? IsPrintDisabled { get; set; }

        public bool? IsReadable { get; set; }

        public bool? IsLendable { get; set; }

        public bool? IsPreviewable { get; set; }

        public string Identifier { get; set; }

        public string Isbn { get; set; }

        public string Oclc { get; set; }

        public string OpenLibraryWork { get; set; }

        public string OpenLibraryEdition { get; set; }

        public string LastLoanDate { get; set; }

        public bool? IsRestricted { get; set; }

        public bool? IsBrowseable { get; set; }
    }
}
