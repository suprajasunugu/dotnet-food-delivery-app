using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDelivery.Customer.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        //create a method which is used to search the location based on pin code
        [HttpGet]
        public ActionResult SearchLocation([FromQuery] int pincode)
        {
            return Ok();
        }
        //git changes
        //push
        //fetch
        //pull
        //commit
       //git branches 
    }
}
