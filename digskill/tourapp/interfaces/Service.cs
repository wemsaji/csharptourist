namespace digskill.tourapp.interfaces;

public interface Service
{

    public const double TaxRate = 1.1;

    public const double ReducedTaxRate = 1.08;

    public string Name();

    public int Cost();

    public int Claim()
    {
        return (int)(this.Cost() * Service.TaxRate);
    }
}
