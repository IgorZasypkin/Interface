namespace Interface.Model.Interface
{
    public interface IRobot
    {
        string GetRobotType();
        List<string> GetComponents();
        string GetInfo();
    }
}