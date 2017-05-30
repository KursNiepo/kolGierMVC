using System.Linq;

namespace KolekcjaGierMVC1.Models {
    public class Game {
        public int GameID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public int CategoryID { get; set; }
        public virtual IQueryable<Category> Categories { get; set; }
    }
}