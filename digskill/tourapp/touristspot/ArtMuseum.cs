namespace digskill.tourapp.touristspot;

public class ArtMuseum
{
    private string name;
    private int cost;
    private string voice;

    public ArtMuseum()
    {
        this.name = "美術館";
        this.cost = 5500;
        this.voice = "美しい";
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