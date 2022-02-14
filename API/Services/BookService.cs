using API.Models.ViewModels;
using API.Services.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class BookService : IBookService
    {
        public async Task<WorkViewModel> RetrieveWorkById(string workId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SubjectViewModel> RetrieveWorksBySubject(string subject)
        {
            var bookCount = 10;

            return new SubjectViewModel
            {
                Key = "abc",
                Name = "cooking",
                SubjectType = "subject",
                WorkCount = bookCount,
                Works = Enumerable.Range(1, bookCount).Select(index => new WorkViewModel
                {
                    Key = index.ToString(),
                    Title = $"Sample Book {index}",
                    EditionCount = 1,
                    CoverId = 1,
                    CoverEditionKey = "1",
                    Subject = new string[] { "cooking" },
                    IaCollection = null,
                    LendingLibrary = false,
                    LendingEdition = "abc",
                    Authors = new AuthorViewModel[] { new AuthorViewModel { Key = "abc", Name = "John Doe" } },
                    FirstPublishYear = null,
                    PublicScan = false,
                    HasFullText = true,
                    Availability = null

                }).ToArray()
            };
        }

        public async Task<SubjectViewModel> RetrieveWorksBySubject(string subject, int offset, int limit)
        {
            throw new System.NotImplementedException();
        }
    }
}
