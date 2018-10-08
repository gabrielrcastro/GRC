using GRC.Domain.Interfaces;
using GRC.Data.Context;

namespace GRC.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GRCContext _context;

        public UnitOfWork(GRCContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
