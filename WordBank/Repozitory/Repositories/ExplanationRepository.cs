using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
    internal class ExplanationRepository: BaseRepository<Explanation>, IExplanationRepository
    {
        internal ExplanationRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
