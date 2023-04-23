using cardholders.Data;

namespace cardholders.Services.CardholderService
{
    public class CardholderService : ICardholderService
    {
        private readonly DataContext _context;

        public CardholderService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Cardholder>> CreateCardholder(Cardholder cardholder)
        {
            _context.Cardholders.Add(cardholder);
            await _context.SaveChangesAsync();
            return await _context.Cardholders.ToListAsync();
        }

        public async Task<List<Cardholder>> GetCardholders()
        {
            var cardholders = await _context.Cardholders.ToListAsync();
            return cardholders;
        }

        public async Task<Cardholder?> GetSingleCardholder(string name)
        {
            var cardholder = await _context.Cardholders.FirstOrDefaultAsync(c => c.name == name);

            if(cardholder is null)
                return null;
            return cardholder;
        }
    }
}