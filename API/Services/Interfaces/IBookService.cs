using API.Models.ViewModels;
using System.Threading.Tasks;

namespace API.Services.Interfaces
{
    public interface IBookService
    {
        Task<SubjectViewModel> RetrieveWorksBySubject(string subject);

        Task<WorkViewModel> RetrieveWorkById(string workId);
    }
}
