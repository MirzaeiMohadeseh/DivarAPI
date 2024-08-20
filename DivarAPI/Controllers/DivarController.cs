using DivarAPI.Data;
using DivarAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;


namespace DivarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivarController : ControllerBase
    {
        private readonly DataContext _context;
        public DivarController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Divar>>> GetAllAds()
        {
            var ads = await _context.Divars.ToListAsync();
            return Ok(ads);


        }
        [HttpGet("{ID}")]
        public async Task<ActionResult<List<Divar>>> GetAd(int ID)
        {
            var ad = await _context.Divars.FindAsync(ID);
            if (ad is null)
                return NotFound("Advertisement not found.");
            return Ok(ad);


        }
        [HttpPost]
        public async Task<ActionResult<List<Divar>>> PostAd(Divar ad)
        {
            _context.Divars.Add(ad);
            await _context.SaveChangesAsync();
            return Ok(await _context.Divars.ToListAsync());


        }
        [HttpPut]
        public async Task<ActionResult<List<Divar>>> UpdateAd(Divar updatedAd)
        {
            var dbAd = await _context.Divars.FindAsync(updatedAd.ID);
            if (dbAd is null)
                return NotFound("Advertisement not found.");
            dbAd.Title = updatedAd.Title;
            dbAd.Category = updatedAd.Category;
            dbAd.Description = updatedAd.Description;
            dbAd.Price = updatedAd.Price;
            dbAd.ImagePath = updatedAd.ImagePath;
            dbAd.City = updatedAd.City;
            dbAd.CreationDate = updatedAd.CreationDate;
            return Ok(await _context.Divars.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<Divar>>> DeleteAd(int id)
        {
            var dbAd = await _context.Divars.FindAsync(id);
            if (dbAd is null)
                return NotFound("Advertisement not found.");
            _context.Divars.Remove(dbAd);
            await _context.SaveChangesAsync();
            return Ok(await _context.Divars.ToListAsync());

        }
    }
}
