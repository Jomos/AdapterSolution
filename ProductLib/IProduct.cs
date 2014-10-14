namespace ProductLib
{
    public interface IProduct
    {
        decimal UnitPrice { get; }
        string BarCode { get; }
        string Title { get; }
    }
}
