using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IWordRepository Words { get; }
        IExplanationRepository Explanations { get; }
        IExampleRepository Examples { get; }
        void BeginTransaction();
        void Commit();
        void RollBack();
        void SaveChanges();
    }
}
