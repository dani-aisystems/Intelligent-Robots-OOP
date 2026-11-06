using System;

public class CleaningRobot : Robot
{
    public int Area { get; private set; }

    public CleaningRobot(string name, string model, int battery, int area)
        : base(name, model, battery)
    {
        this.Area = area;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Почистващ робот");
        base.ShowInfo();
        Console.WriteLine($"Площ за почистване: {this.Area} кв.м");
    }

    public override void PerformTask()
    {
        if (!this.CanPerformTask())
        {
            return;
        }

        Console.WriteLine($"{this.Name} почиства площ от {this.Area} кв.м.");
        this.UseBattery(25);
        Console.WriteLine($"Оставаща батерия: {this.Battery}%");
    }
}
