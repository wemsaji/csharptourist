using digskill.utility;

namespace digskill.tourapp;

public class Tourist
{
    private int money;
    private Logger logger = new Logger("旅の記録", 0);

    public Tourist(int money)
    {
        this.money = money;
    }

    public void TourStart()
    {
        string log = this.money + "円を持って旅に出ます。";
        this.logger.Out(log);
    }

    public void TourEnd()
    {
        string log = "残金は" + this.money + "円。";
        log += "最高の旅でした！";
        this.logger.Out(log);
    }
}