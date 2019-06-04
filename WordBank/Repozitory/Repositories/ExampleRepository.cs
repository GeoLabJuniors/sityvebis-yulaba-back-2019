using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
    internal class ExampleRepository: BaseRepository<Example>, IExampleRepository
    {
        internal ExampleRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
