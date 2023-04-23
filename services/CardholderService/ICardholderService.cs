namespace cardholders.Services.CardholderService
{
    public interface ICardholderService
    {
        Task<List<Cardholder>> GetCardholders();
        Task<Cardholder?> GetSingleCardholder(string name);
        Task<List<Cardholder>> CreateCardholder(Cardholder cardholder);
    }
}