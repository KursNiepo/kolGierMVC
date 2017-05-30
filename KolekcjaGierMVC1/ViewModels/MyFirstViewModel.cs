using System.Collections.Generic;
using KolekcjaGierMVC1.Models;

namespace KolekcjaGierMVC1.ViewModels {
    public class MyFirstViewModel {
        public MyFirstViewModel(List<Game> games,List<Category> categories) {
            Games = games;
            Categories = categories;
        }
        public List<Game> Games { get; set; }
        public List<Category> Categories { get; set; }
    }
}