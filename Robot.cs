using System;

public abstract class Robot
{
    private int battery;

    public string Name { get; private set; }
    public string Model { get; private set; }

    public int Battery
    {
        get { return this.battery; }
        protected set
        {
            if (value < 0)
            {
                this.battery = 0;
            }
            else if (value > 100)
            {
                this.battery = 100;
            }
            else
            {
                this.battery = value;
            }
        }
    }

    protected Robot(string name, string model, int battery)
    {
        this.Name = name;
        this.Model = model;
        this.Battery = battery;
    }

    public abstract void PerformTask();

    public void Charge()
    {
        this.Battery = this.Battery + 20;
        Console.WriteLine($"{this.Name} се зареди. Батерия: {this.Battery}%");
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Име: {this.Name}");
        Console.WriteLine($"Модел: {this.Model}");
        Console.WriteLine($"Батерия: {this.Battery}%");
    }

    protected bool CanPerformTask()
    {
        if (this.Battery < 20)
        {
            Console.WriteLine($"{this.Name} няма достатъчно батерия ({this.Battery}%) и не може да изпълни задачата.");
            return false;
        }

        return true;
    }

    protected void UseBattery(int amount)
    {
        this.Battery = this.Battery - amount;
    }
}
