using System;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class Quantity
    {
        public decimal Value { get; private set; }

        public Quantity(decimal value)
        {
            if (value < 0)
                throw new ArgumentException("Product quantity must be positive");

            Value = value;
        }

        static public implicit operator Quantity(decimal value)
        {
            return new Quantity(value);
        }

        static public implicit operator decimal(Quantity quantity)
        {
            return quantity.Value;
        }
    }
}