using Sample.Data.Entities;
using Sample.Data;


using var db = new LibraryContext();

var gamestodelete = db.VideoGames.Where(x => x.Developer == "CD Projekt Red");

foreach (var deletegame in gamestodelete)
    db.VideoGames.Remove(deletegame);

VideoGame videoGame1 = new VideoGame()
{
    Name = "The Witcher 3: Wild Hunt",
    Genre = "RPG",
    Platform = "PlayStation 4",
    Developer = "CD Projekt Red",
    Created = new DateTime(2015, 5, 19),
    Price = 29.99
};

VideoGame videoGame2 = new VideoGame()
{
    Name = "The Legend of Zelda: Breath of the Wild",
    Genre = "Adventure",
    Platform = "Nintendo Switch",
    Developer = "Nintendo",
    Created = new DateTime(2017, 3, 3),
    Price = 59.99
};

VideoGame videoGame3 = new VideoGame()
{
    Name = "Cyberpunk 2077",
    Genre = "RPG",
    Platform = "PC",
    Developer = "CD Projekt Red",
    Created = new DateTime(2020, 12, 10),
    Price = 49.99
};

db.VideoGames.Add(videoGame1);
db.VideoGames.Add(videoGame2);
db.VideoGames.Add(videoGame3);

db.SaveChanges();

var developersgames = db.VideoGames.Where(x => x.Developer == "CD Projekt Red");

foreach (var item  in developersgames)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Genre);
    Console.WriteLine(item.Platform);
    Console.WriteLine(item.Developer);
    Console.WriteLine(item.Price);
}