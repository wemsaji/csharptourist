namespace digskill.utility;

public class Logger
{
    private string type;
    private int counter;

    public Logger(string type, int counter)
    {
        this.type = type;
        this.counter = 0;
    }

    public void Out(object output)
    {
        string label = GetNow();
        label += " " + this.type + ":";
        label += ++this.counter + " ";
        Console.WriteLine(label + output);
    }

    public static string GetNow()
    {
        return DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss.fff]");
    }
}
