using Interface.Model.Interface;

namespace Interface.Model
{
    public class Quadcopter : IRobot, IChargeable
    {
        List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };

        public string GetInfo()
        {
            return "GetInfo";
        }

        public List<string> GetComponents()
        {
            return _components;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}