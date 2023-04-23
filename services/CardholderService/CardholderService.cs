namespace cardholders.Services.CardholderService
{
    public class CardholderService : ICardholderService
    {

         private static List<Cardholder> cardholders = new List<Cardholder>{
                new Cardholder {name = "Shan Siriwardana",cardNumber = "111111111111",cvc = "111",expiryDate = "12/23"}
        };

        //  private static List<Cardholder> cardholders = new List<Cardholder>{
        //         new Cardholder {id = 1,name = "Shan Siriwardana",cardNumber = "111111111111",cvc = "111",expiryDate = "12/23"}
        // };


        public List<Cardholder> CreateCardholder(Cardholder cardholder)
        {
            cardholders.Add(cardholder);
            return cardholders;
        }

        public List<Cardholder> GetCardholders()
        {
            return cardholders;
        }

        public Cardholder GetSingleCardholder(string name)
        {
            
            var cardholder = cardholders.Find(x => x.name == name);

            if(cardholder is null)
                return null;
            return cardholder;
        }
    }
}