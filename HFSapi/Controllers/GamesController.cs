using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HFSapi.Models;
using HFSapi.Services;
using HFSapi.Filter;
using HFSapi.Wrappers;
using HFSapi.Helpers;

namespace HFSapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
      private HFSapiContext _db;
      private readonly IUriService uriService;

      public GamesController(HFSapiContext db, IUriService uriService)
      {
        _db = db;
        this.uriService = uriService;
      }
      [HttpGet]
      public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter )
      {
        var route = Request.Path.Value;
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var query = _db.Games.AsQueryable();
        query = query.Skip((validFilter.PageNumber -1 ) * validFilter.PageSize).Take(validFilter.PageSize);
        var totalRecords = await _db.Games.CountAsync();
        var pagedResponse = PaginationHelper.CreatePagedReponse<Game>(query.ToList(), validFilter, totalRecords, uriService, route);
        return Ok(pagedResponse);
      }

      //by game id
      [HttpGet("{id}")]
      public async Task<IActionResult> GetById(int id)
      {
          var game = await _db.Games.Where(a => a.GameId == id).FirstOrDefaultAsync();
          return Ok(new Response<Game>(game));
      }

      [HttpGet("search")]
      public async Task<IActionResult> Search([FromQuery] PaginationFilter filter, int Season, int Week, int PlayerId, string Team)
      {
        var route = Request.Path.Value;
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var query = _db.Games.AsQueryable();

        if (Season != 0)
        {
            query = query.Where(entry => entry.Season == Season); 
        }
        if (Week != 0)
        {
            query = query.Where(entry => entry.Week == Week);
        }
        if (PlayerId != 0)
        {
            query = query.Where(entry => entry.PlayerId == PlayerId);
        }
        if (Team != null)
        {
            query = query.Where(entry => entry.Team == Team);
        }

        query = query.Skip((validFilter.PageNumber - 1) * validFilter.PageSize).Take(validFilter.PageSize);

        var totalRecords = await _db.Games.CountAsync();
        var pagedResponse = PaginationHelper.CreatePagedReponse<Game>(query.ToList(), validFilter, totalRecords, uriService, route);

        return Ok(pagedResponse);
      }
      [HttpGet("GetGame")]
      public IActionResult GetRandomGameByWeek(int Week, int PlayerId)
      {
        
        var query = _db.Games.AsQueryable();

        if (PlayerId != 0)
        {
            query = query.Where(entry => entry.PlayerId == PlayerId);
        }
        if (Week != 0)
        {
            query =  query.Where(entry => entry.Week == Week);
        }
        
        
        Random random = new Random();
        Game game = query.ToList()[random.Next(query.ToList().Count)];
        return Ok(new Response<Game>(game));
      }



    }
}