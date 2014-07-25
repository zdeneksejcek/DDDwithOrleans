using System;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class MonetaryValue
    {
        public decimal Amount { get; private set; }
        public Currency Currency { get; private set; }

        public MonetaryValue(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static MonetaryValue operator +(MonetaryValue c1, MonetaryValue c2)
        {
            if (c1.Currency != c2.Currency)
                throw new Exception("Currencies have to match to add MonetaryValues");

            return new MonetaryValue(c1.Amount + c2.Amount, c1.Currency);
        }
    }
}