namespace ContratosPrototype.Abstractions
{
    public interface IContractPrototype
    {
        IContractPrototype Clone();
        void Print();
    }
}
