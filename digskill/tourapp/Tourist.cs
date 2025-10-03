using digskill.tourapp.abstracts;
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

    public bool Pay(TouristSpot touristSpot)
    {
        bool paid = false;
        string name = touristSpot.Name();
        int cost = touristSpot.Claim();
        string log = name + "を利用します。";
        this.logger.Out(log);

        if (cost <= this.money)
        {
            this.money -= cost;
            log = cost + "円を支払いました";
            paid = true;
        }
        else
        {
            log = cost + "円を持っていません・・・";
        }
        this.logger.Out(log);
        return paid;
    }

    public void Visit(TouristSpot touristSpot)
    {
        string log = touristSpot.Exhibition();
        log += "・・・感動しました！";
        this.logger.Out(log);
    }
}