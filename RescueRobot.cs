using System;

public class RescueRobot : Robot
{
    public int Sensors { get; private set; }

    public RescueRobot(string name, string model, int battery, int sensors)
        : base(name, model, battery)
    {
        this.Sensors = sensors;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Спасителен робот");
        base.ShowInfo();
        Console.WriteLine($"Брой сензори: {this.Sensors}");
    }

    public override void PerformTask()
    {
        if (!this.CanPerformTask())
        {
            return;
        }

        Console.WriteLine($"{this.Name} изпълнява спасителна мисия с {this.Sensors} сензора.");
        this.UseBattery(30);
        Console.WriteLine($"Оставаща батерия: {this.Battery}%");
    }
}
