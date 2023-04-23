using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cardholders.Models;



namespace cardholders.Controllers
{ 
    [Route("api")]
    [ApiController]
    public class CardholderController : ControllerBase
    {
        private static List<Cardholder> cardholders = new List<Cardholder>{
                new Cardholder {id = 1,name = "Shan Siriwardana",cardNumber = "111111111111",cvc = "111",expiryDate = "12/23"}
        };

        [HttpGet("cardholders")]
        public async Task<ActionResult<List<Cardholder>>> GetCardholders()
        {
            return Ok(cardholders);
        }

        [HttpGet("cardholder/{id}")]
        public async Task<ActionResult<Cardholder>> GetSingleCardholder(int id)
        {
            var cardholder = cardholders.Find(x => x.id == id);

            if(cardholder is null)
                return NotFound("Cardholder does not exist.");
            return Ok(cardholder);
        }

        [HttpPost("cardholder")]
        public async Task<ActionResult<List<Cardholder>>> CreateCardholder(Cardholder cardholder)
        {
            cardholders.Add(cardholder);
            return Ok(cardholders);
        }
    }
}
