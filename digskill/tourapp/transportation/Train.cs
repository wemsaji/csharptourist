using digskill.tourapp.abstracts;

namespace digskill.tourapp.transportation;

public class Train : Transportation
{
    public Train(int distanceKm) : base("電車", distanceKm, 20, "ガタンゴトン")
    {
    }
}