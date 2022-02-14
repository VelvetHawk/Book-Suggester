namespace API.Models.TransferModels
{
    public class SubjectDto
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Subject_Type { get; set; }

        public int Work_Count { get; set; }

        public int EBook_Count { get; set; }

        public WorkDto[] Works { get; set; }
    }
}
