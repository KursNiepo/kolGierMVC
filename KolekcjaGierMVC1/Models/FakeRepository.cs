using System.Collections.Generic;
using System.Linq;
using KolekcjaGierMVC1.Models.Abstracted;

namespace KolekcjaGierMVC1.Models {
    public class FakeRepository :IRepository{
        public FakeRepository() {
            Games = new List<Game> {
                new Game() {GameID = 1,Description = "jakiś opis",Score = 6,CategoryID = 1,Title = "Gra1"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 8,CategoryID = 1,Title = "Gra2"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 5,CategoryID = 3,Title = "Gra3"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 2,CategoryID = 3,Title = "Gra4"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 9,CategoryID = 2,Title = "Gra4"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 10,CategoryID = 2,Title = "Gra5"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 5,CategoryID = 2,Title = "Gra6"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 7,CategoryID = 3,Title = "Gra7"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 6,CategoryID = 3,Title = "Gra8"},
                new Game() {GameID = 1,Description = "jakiś opis",Score = 5,CategoryID = 1,Title = "Gra9"},

            }.AsQueryable();
            Categories = new List<Category>() {
                new Category() {CategoryID = 1,Name = "Akcja"},
                new Category() {CategoryID = 2,Name = "RPG"},
                new Category() {CategoryID = 3,Name = "Symulator"},
                new Category() {CategoryID = 4,Name = "Strategia"},

            }.AsQueryable();
        }
        public IQueryable<Game> Games { get; set; }
        public IQueryable<Category> Categories { get; set; }
    }
}