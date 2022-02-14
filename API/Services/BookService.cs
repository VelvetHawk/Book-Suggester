using API.Models.ViewModels;
using API.Services.Interfaces;
using System.Threading.Tasks;

namespace API.Services
{
    public class BookService : IBookService
    {
        public Task<WorkViewModel> RetrieveWorkById(string workId)
        {
            throw new System.NotImplementedException();
        }

        public Task<SubjectViewModel> RetrieveWorksBySubject(string subject)
        {
            throw new System.NotImplementedException();
        }
    }
}
