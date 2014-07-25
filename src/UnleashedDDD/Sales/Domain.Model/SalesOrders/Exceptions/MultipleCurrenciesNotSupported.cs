using System;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders.Exceptions
{
    public class MultipleCurrenciesNotSupported : Exception
    {
        public SalesOrderId SalesOrder { get; private set; }
        public Currency UnsupportedCurrency { get; private set; }

        public MultipleCurrenciesNotSupported(SalesOrderId salesOrder, Currency unsupportedCurrency)
        {
            SalesOrder = salesOrder;
            UnsupportedCurrency = unsupportedCurrency;
        }
    }
}
