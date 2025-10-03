using digskill.tourapp.abstracts;

namespace digskill.tourapp.restaurant;

public class Cafe : Restaurant
{
    public Cafe(string order) : base("カフェ", order, "でーす！")
    {
        this.menu["パスタ"] = 1500;
        this.menu["コーヒー"] = 400;
    }
}