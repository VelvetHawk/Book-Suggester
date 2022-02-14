namespace API.Models.ViewModels
{
    public class SubjectViewModel
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string SubjectType { get; set; }

        public int WorkCount { get; set; }

        public int EBookCount { get; set; }

        public WorkViewModel[] Works { get; set; }
    }
}
