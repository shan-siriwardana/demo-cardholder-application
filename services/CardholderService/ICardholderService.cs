namespace cardholders.Services.CardholderService
{
    public interface ICardholderService
    {
        List<Cardholder> GetCardholders();
        Cardholder? GetSingleCardholder(string name);
        List<Cardholder> CreateCardholder(Cardholder cardholder);
    }
}