namespace digskill.tourapp.abstracts;

public abstract class TouristSpot
{
    private string name;
    private int cost;
    private string voice;

    protected TouristSpot(string name, int cost, string voice)
    {
        this.name = name;
        this.cost = cost;
        this.voice = voice;
    }

    public string Name()
    {
        return "ずっと来たかった" + this.name;
    }

    public int Claim()
    {
        return this.cost;
    }

    public string Exhibition()
    {
        return this.voice;
    }
}