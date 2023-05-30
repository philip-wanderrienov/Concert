using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Entity;

namespace UseCase.Repository
{
    public interface IAudienceRepository
    {
        void Insert(Audience audience);
        void Delete(Audience audience);
        List<Audience> GetListAudience();
    }
}
