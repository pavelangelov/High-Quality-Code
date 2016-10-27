namespace Decorator_Pattern.Contracts
{
    public interface INetClient
    {
        string Name { get; set; }

        bool IsConnect { get; set; }

        // Check for new videos from Telerik :)
        string SurfInNet();
    }
}
