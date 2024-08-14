using DivarAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;


namespace DivarAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class DivarController : ControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult<List<Divar>>> GetAllAds()
        {
            var ads = new List<Divar>
            {
                new Divar
                {
                    ID = 1,
                    Title = "پیراهن",
                    Description= "سایز 44",
                    Category="پوشاک",
                    Price= 589.000M

                }
            };
            return Ok(ads);


        }
    }
}
