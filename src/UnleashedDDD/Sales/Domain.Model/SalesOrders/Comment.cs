namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class Comment
    {
        public string Value { get; private set; }

        public Comment(string value)
        {
            Value = value;
        }
    }
}