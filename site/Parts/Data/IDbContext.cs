using System.Data.Entity;

namespace Site.Parts.Data {
    public interface IDbContext {
        IDbSet<T> Set<T>() where T : class;

        void SaveChanges();
    }
}