

using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using SQLitePCL;

namespace PropertySurveyService.Data
{
    public interface IMainRepo
    {
        AppDBContext Db { get; }

        IEnumerable<PhotoImage> GetSurveyItemImages(string contractCode, int itemNumber);
    }
    public class MainRepo : IMainRepo
    {
        private readonly AppDBContext _context;

        public AppDBContext Db => _context;

        public MainRepo(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<PhotoImage> GetSurveyItemImages(string contractCode, int itemNumber)
        {
            string pattern = $"{contractCode:00000000}____{itemNumber:000}%"; // using _ as a wildcard ( would have been cAZ and dAZ )

            var photoimages = _context.Images
                .Where(x => EF.Functions.Like(x.Filename, pattern))
                .OrderByDescending(x => x.Filename.Substring(9, 1))
                .ToList();

            return photoimages ?? new List<PhotoImage>();
        }




    }
}
