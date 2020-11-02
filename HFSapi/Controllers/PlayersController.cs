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
    public class PlayersController : ControllerBase
    {
      private HFSapiContext _db;
      private readonly IUriService uriService;

      public PlayersController(HFSapiContext db, IUriService uriService)
      {
        _db = db;
        this.uriService = uriService;
      }
      [HttpGet]
      public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter )
      {
        var route = Request.Path.Value;
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var query = _db.Players.AsQueryable();
        query = query.Skip((validFilter.PageNumber -1 ) * validFilter.PageSize).Take(validFilter.PageSize);
        var totalRecords = await _db.Players.CountAsync();
        var pagedResponse = PaginationHelper.CreatePagedReponse<Player>(query.ToList(), validFilter, totalRecords, uriService, route);
        return Ok(pagedResponse);
      }

      //by game id
      [HttpGet("{id}")]
      public async Task<IActionResult> GetById(int id)
      {
          var player = await _db.Players.Where(a => a.PlayerId == id).FirstOrDefaultAsync();
         // System.Console.WriteLine(";;;;;;;;;;;;;;;;  " + game.PlayerId);
          return Ok(new Response<Player>(player));
      }

      [HttpGet("search")]
      public async Task<IActionResult> Search([FromQuery] PaginationFilter filter, string Name, string Position)
      {
        var route = Request.Path.Value;
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var query = _db.Players.AsQueryable();

        if (Name != null)
        {
            query = query.Where(entry => entry.Name == Name); 
        }
        
        if (Position != null)
        {
            query = query.Where(entry => entry.Position == Position);
        }

        query = query.Skip((validFilter.PageNumber - 1) * validFilter.PageSize).Take(validFilter.PageSize);

        var totalRecords = await _db.Games.CountAsync();
        var pagedResponse = PaginationHelper.CreatePagedReponse<Player>(query.ToList(), validFilter, totalRecords, uriService, route);

        return Ok(pagedResponse);
      }
      



    }
}