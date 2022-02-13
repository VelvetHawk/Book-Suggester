using API.Models.Enums;

namespace API.Models
{
    public class ResponseMessage
    {
        public ResponseMessageCode Type { get; set; }

        public string Text { get; set; }
    }
}
