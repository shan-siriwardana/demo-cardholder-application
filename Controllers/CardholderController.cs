using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cardholders.Services.CardholderService;
// using cardholders.Models;



namespace cardholders.Controllers
{ 
    [Route("api")]
    [ApiController]
    public class CardholderController : ControllerBase
    {
       
        private readonly ICardholderService _cardholderService;

        public CardholderController(ICardholderService cardholderService)
        {
            _cardholderService = cardholderService;
        }

        [HttpGet("cardholders")]
        public async Task<ActionResult<List<Cardholder>>> GetCardholders()
        {
            var result = _cardholderService.GetCardholders();
            return Ok(result);
        }

        [HttpGet("cardholder/{name}")]
        public async Task<ActionResult<Cardholder>> GetSingleCardholder(string name)
        {
            var result = _cardholderService.GetSingleCardholder(name);
            if (result is null)
                return NotFound("cardholder not found");
            
            return Ok(result);
        }

        [HttpPost("cardholder")]
        public async Task<ActionResult<List<Cardholder>>> CreateCardholder(Cardholder cardholder)
        {
            var result = _cardholderService.CreateCardholder(cardholder);
            return Ok(result);
        }
    }
}
