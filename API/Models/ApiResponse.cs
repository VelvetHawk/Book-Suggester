namespace API.Models
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }

        public string[] Messages { get; set; }
    }
}
