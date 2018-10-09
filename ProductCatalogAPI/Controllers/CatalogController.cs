using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductCatalogAPI.Data;
using ProductCatalogAPI.Domain;

namespace ProductCatalogAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Catalog")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _catalogContext;
        private readonly IConfiguration _configuration;
        public CatalogController(CatalogContext catalogContext, IConfiguration configuration)
        {
            _catalogContext = catalogContext;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogEventTypes()
        {
            var events = await _catalogContext.CatalogEventTypes.ToListAsync();
            return Ok(events);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogEventCategories()
        {
            var events = await _catalogContext.CatalogEventCategories.ToListAsync();
            return Ok(events);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogEventLocations()
        {
            var events = await _catalogContext.CatalogEventLocations.ToListAsync();
            return Ok(events);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Items(
            [FromQuery] int pageSize = 3,
            [FromQuery] int pageIndex = 0)
        {
            var totalItems = await _catalogContext.CatalogEventItems.LongCountAsync();
            var itemsOnPage = await 
                _catalogContext.CatalogEventItems
                .OrderBy(c => c.Name).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();

            itemsOnPage = ChangeUrlPlaceHolder(itemsOnPage);
            return Ok(itemsOnPage);
        }

        [HttpGet]
        [Route("[action]/withname/{name:minlength(1)}")]
        public async Task<IActionResult> Items(
            string name,
           [FromQuery] int pageSize = 3,
           [FromQuery] int pageIndex = 0)
        {
            var totalItems = await _catalogContext.CatalogEventItems.Where(c => c.Name.StartsWith(name)).LongCountAsync();
            var itemsOnPage = await
                _catalogContext.CatalogEventItems.Where(c => c.Name.StartsWith(name))
                .OrderBy(c => c.Name).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();

            itemsOnPage = ChangeUrlPlaceHolder(itemsOnPage);
            return Ok(itemsOnPage);
        }

        [HttpGet]
        [Route("items/{id:int}")]
        public async Task<IActionResult> GetItemById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var item = await _catalogContext.CatalogEventItems.SingleOrDefaultAsync(c => c.Id == id);
            if (item != null)
            {
                item.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced", _configuration["ExternalCatalogBaseUrl"]);
                return Ok(item);
            }
            return NotFound();
        }


        private List<CatalogEventItem> ChangeUrlPlaceHolder(List<CatalogEventItem> items)
        {
            items.ForEach(
                x => x.PictureUrl = x.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced", _configuration["ExternalCatalogBaseUrl"]));
            return items;
        }
    }
}