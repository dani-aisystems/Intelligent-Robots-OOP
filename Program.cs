using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DeliveryRobot delivery = new DeliveryRobot(
            "D-01", "X1", 100, "Plovdiv, Bulgaria");

        CleaningRobot cleaning = new CleaningRobot(
            "C-01", "CleanPro", 80, 150);

        RescueRobot rescue = new RescueRobot(
            "R-01", "RescueX", 90, 4);

        MedicalRobot medical = new MedicalRobot(
            "M-01", "MediBot", 100, "Антибиотици");

        List<Robot> robots = new List<Robot>();

        robots.Add(delivery);
        robots.Add(cleaning);
        robots.Add(rescue);
        robots.Add(medical);

        foreach (Robot robot in robots)
        {
            robot.ShowInfo();
            robot.PerformTask();
            Console.WriteLine("----------");
        }
    }
}
