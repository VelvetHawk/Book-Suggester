using API.Models.ViewModels;
using System.Threading.Tasks;

namespace API.Services.Interfaces
{
    public interface IBookService
    {
        Task<WorkViewModel> RetrieveWorkById(string workId);

        Task<SubjectViewModel> RetrieveWorksBySubject(string subject);

        Task<SubjectViewModel> RetrieveWorksBySubject(string subject, int offset, int limit);
    }
}
