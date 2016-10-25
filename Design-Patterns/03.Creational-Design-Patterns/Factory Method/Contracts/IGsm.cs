namespace Factory_Method.Contracts
{
    public interface IGsm
    {
        string Manufacturer { get; }

        string Model { get; }

        double DisplaySize { get; }

        int Colors { get; }
    }
}
