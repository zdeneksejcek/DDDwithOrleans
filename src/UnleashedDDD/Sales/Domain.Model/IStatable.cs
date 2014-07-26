namespace UnleashedDDD.Sales.Domain.Model
{
    public interface IStatable<T>
    {
        T GetState();
    }
}
