using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
    internal class WordRepository : BaseRepository<Word>, IWordRepository
    {
        internal WordRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
