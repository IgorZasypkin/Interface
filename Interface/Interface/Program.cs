using Interface.Model;

var quadcopter = new Quadcopter();
Console.WriteLine(quadcopter.GetInfo());
Console.WriteLine(quadcopter.GetComponents());
Console.WriteLine(quadcopter.GetRobotType());

quadcopter.Charge();