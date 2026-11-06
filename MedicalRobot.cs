using System;

public class MedicalRobot : Robot
{
    public string MedicineType { get; private set; }

    public MedicalRobot(string name, string model, int battery, string medicineType)
        : base(name, model, battery)
    {
        this.MedicineType = medicineType;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Медицински робот");
        base.ShowInfo();
        Console.WriteLine($"Вид лекарство: {this.MedicineType}");
    }

    public override void PerformTask()
    {
        if (!this.CanPerformTask())
        {
            return;
        }

        Console.WriteLine($"{this.Name} доставя {this.MedicineType} на пациентите.");
        this.UseBattery(10);
        Console.WriteLine($"Оставаща батерия: {this.Battery}%");
    }
}
