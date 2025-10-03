
using digskill.tourapp.interfaces;

namespace digskill.tourapp.abstracts;

public abstract class Restaurant : Service
{
    private string name;
    private string order;
    private string talk;
    protected Dictionary<string, int> menu;

    protected Restaurant(string name, string order, string talk)
    {
        this.name = name;
        this.order = order;
        this.talk = talk;
        this.menu = new Dictionary<string, int>();
    }

    public string Name()
    {
        return "美味しいと噂の" + this.name;
    }

    public int Claim()
    {
        return this.menu[this.order];
    }

    public string Serve()
    {
        return this.order + this.talk;
    }
}