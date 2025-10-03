using digskill.tourapp.abstracts;

namespace digskill.tourapp.transportation;

public class Airplane : Transportation
{
    public Airplane(int distanceKm) : base("飛行機", distanceKm, 40, "ブーン")
    {
    }
}