
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;



namespace Modul10_103022400121.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> Games = new List<Game>
        {
            new Game(01, "Valorant", "Riot Games",2020, "FPS", 8.5,["PC"], ["Multiplayer"], true, 0),
            new Game(02,"GTA V", "Rockstar Games",2013, "Open World", 9.5,["PC", "PS4", "PS5","Xbox"], ["Singleplayer", "Multiplayer"], true, 3000000),
            new Game(03, "The Witcher 3", "CD Projekt Red",20215, "RPG", 9.7,["PC", "PS4", "PS5","Xbox", "Switch"], ["Singleplayer"], false, 250000),

        };

        [HttpGet]
        public IEnumerable<Game> GetAll()
        {
            return Games;
        }
        [HttpGet("{id}")]
        public Game GetById(int id)
        {
            return Games[id];
        }
        [HttpPost]
        public void Post([FromBody] Game newGame)
        {
            Games.Add(newGame);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Games.RemoveAt(id);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Game updategame)
        {

            var index = Games.FindIndex(g => g.id == id);
            if (index == -1)
            {
                return NotFound();
                Games[index] = updategame;
                
            }
            return Ok("update game");
        }


    }
}
