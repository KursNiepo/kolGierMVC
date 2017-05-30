using System.Linq;

namespace KolekcjaGierMVC1.Models.Abstracted {
    public interface IRepository {
        IQueryable<Game> Games { get; set; }
        IQueryable<Category> Categories { get; set; }
    }
}