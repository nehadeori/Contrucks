using Contrucks.model.ViewModels;
using System.Collections.Generic;

namespace Contrucks.Service.Interfaces
{
    public interface IRecentJobPostService
    {
        IEnumerable<RecentpostViewmodel> GetAll();
        void AddData(RecentpostViewmodel usertables);
    }
}
