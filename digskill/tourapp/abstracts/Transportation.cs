using digskill.tourapp.interfaces;

namespace digskill.tourapp.abstracts;

public abstract class Transportation : Service
{
    private string name;
    private int distanceKm;
    private int costPerKm;
    private string sound;

    public Transportation(string name, int distanceKm, int costPerKm, string sound)
    {
        this.name = name;
        this.distanceKm = distanceKm;
        this.costPerKm = costPerKm;
        this.sound = sound;
    }

    public string Name()
    {
        return "移動手段として" + this.name;
    }

    public int Cost()
    {
        return this.costPerKm * distanceKm;
    }

    public string Distance()
    {
        return this.distanceKm + "km";
    }

    public string Transport()
    {
        return this.sound;
    }
}