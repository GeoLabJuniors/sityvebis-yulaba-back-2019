using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IWordRepository Words => new WordRepository(_context);

        public IExplanationRepository Explanations => new ExplanationRepository(_context);

        public IExampleRepository Examples =>  new ExampleRepository(_context);

        public IContactInfoRepository Contacts => new ContactInfoRepository(_context);

        public void BeginTransaction()
        {
            if (_context.Database.CurrentTransaction == null)
                _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CurrentTransaction?.Commit();
        }

        public void RollBack()
        {
            _context.Database.CurrentTransaction?.Rollback();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Database.CurrentTransaction?.Dispose();
            _context.Dispose();
        }
    }
}
