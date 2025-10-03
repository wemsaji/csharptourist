using digskill.tourapp.abstracts;

namespace digskill.tourapp.restaurant;

public class French : Restaurant
{
    public French(string order) : base("フレンチ", order, "でございます。")
    {
        this.menu["ステーキ"] = 9000;
        this.menu["コーヒー"] = 800;
    }

    public override int Claim()
    {
        return (int)(base.Claim() * 1.1);
    }
}