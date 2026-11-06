using System;

public class DeliveryRobot : Robot
{
    public string DeliveryAddress { get; private set; }

    public DeliveryRobot(string name, string model, int battery, string deliveryAddress)
        : base(name, model, battery)
    {
        this.DeliveryAddress = deliveryAddress;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Робот за доставки");
        base.ShowInfo();
        Console.WriteLine($"Адрес за доставка: {this.DeliveryAddress}");
    }

    public override void PerformTask()
    {
        if (!this.CanPerformTask())
        {
            return;
        }

        Console.WriteLine($"{this.Name} доставя пратка до {this.DeliveryAddress}.");
        this.UseBattery(15);
        Console.WriteLine($"Оставаща батерия: {this.Battery}%");
    }
}
