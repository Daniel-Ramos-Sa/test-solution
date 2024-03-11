using API_Teste.API_Teste.Application;
using API_Teste.API_Teste.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/animes")]
public class AnimeController : ControllerBase
{
    /// <summary>
    /// API - CRUD Completo
    /// </summary>
    private readonly IAnimeService _animeService;

    public AnimeController(IAnimeService animeService)
    {
        _animeService = animeService;
    }

    // GET: api/animes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Anime>>> GetAllAnimes()
    {
        var animes = await _animeService.GetAllAnimesAsync();
        return Ok(animes);
    }

    // GET: api/animes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Anime>> GetAnimeById(int id)
    {
        var anime = await _animeService.GetAnimeByIdAsync(id);

        if (anime == null)
        {
            return NotFound();
        }

        return Ok(anime);
    }

    // POST: api/animes
    [HttpPost]
    public async Task<ActionResult<int>> CreateAnime([FromBody] Anime anime)
    {
        var animeId = await _animeService.CreateAnimeAsync(anime);
        return CreatedAtAction(nameof(GetAnimeById), new { id = animeId }, animeId);
    }

    // PUT: api/animes/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAnime(int id, [FromBody] Anime anime)
    {
        if (id != anime.Id)
        {
            return BadRequest();
        }

        await _animeService.UpdateAnimeAsync(anime);
        return NoContent();
    }

    // DELETE: api/animes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnime(int id)
    {
        await _animeService.SoftDeleteAnimeAsync(id);
        return NoContent();
    }
}

