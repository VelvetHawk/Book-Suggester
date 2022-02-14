namespace API.Models.TransferModels
{
    public class AvailabilityDto
    {
        public string Status { get; set; }

        public bool? Available_To_Browse { get; set; }

        public bool? Available_To_Borrow { get; set; }

        public bool? Available_To_Waitlist { get; set; }

        public bool? Is_PrintDisabled { get; set; }

        public bool? Is_Readable { get; set; }

        public bool? Is_Lendable { get; set; }

        public bool? Is_Previewable { get; set; }

        public string Identifier { get; set; }

        public string Isbn { get; set; }

        public string Oclc { get; set; }

        public string OpenLibrary_Work { get; set; }

        public string OpenLibrary_Edition { get; set; }

        public string LastLoanDate { get; set; }

        public bool? Is_Restricted { get; set; }

        public bool? Is_Browseable { get; set; }
    }
}
