namespace UnleashedDDD.Sales.Domain.Model
{
    public class Currency
    {
        public string CurrencyName { get; private set; }

        public Currency(string threeLettersName)
        {
            CurrencyName = threeLettersName;
        }
    }
}
