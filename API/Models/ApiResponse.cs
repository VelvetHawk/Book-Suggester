namespace API.Models
{
    public class ApiResponse<T>
    {
        public T Response { get; set; }

        public string[] Messages { get; set; }
    }
}
