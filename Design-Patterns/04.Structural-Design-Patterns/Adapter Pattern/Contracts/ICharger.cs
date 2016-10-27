namespace Adapter_Pattern.Contracts
{
    public interface ICharger
    {
        string Charge(IRechargeble rechargebleItem);
    }
}
