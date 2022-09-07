using CSharp_Challenge_OvertimePay.classes;
// See https://aka.ms/new-console-template for more information

OverTime overtime = new OverTime(new double[] { 9, 17, 30, 1.5 });
Console.WriteLine($"${overtime.CalculatePay().ToString("#.00")}");
OverTime overtime2 = new OverTime(new double[] { 16, 18, 30, 1.8 });
Console.WriteLine($"${overtime2.CalculatePay().ToString("#.00")}");