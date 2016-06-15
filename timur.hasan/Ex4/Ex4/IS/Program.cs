public class Hiring
{
    static void Main(string[] args)
    {
        var youA = new DevInTest(args[0], args[1]);//?
        Code code = youA.ReACoder;
        Test test = youA.ReATester;
        if (youA.ReAbleTo(code() && test()))
        {
            youA.PplyNow();
        }
    }
    delegate bool Code();
    delegate bool Test();
}
public static class Helper
{
    public static DevInTest PplyNow(this DevInTest sdet) { return sdet; }
    public static bool ReAbleTo(this DevInTest sdet, bool values) { return values; }
}
public class DevInTest : ISoftwareEngineer, IQaEngineer
{
    public DevInTest(string name, string emailAddress)
    {
        Name = name;
        EmailAddress = emailAddress;
    }
    public string Name;
    public string EmailAddress;
    public bool ReACoder() { return true; }
    public bool ReATester() { return true; }
}
interface ISoftwareEngineer { bool ReACoder(); }
interface IQaEngineer { bool ReATester(); }

