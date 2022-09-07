using CSharp_Challenge_OvertimePay.classes;
// See https://aka.ms/new-console-template for more information

OverTime overtime = new OverTime(new double[] { 9, 17, 30, 1.5 }); //Expected output $240.00
Console.WriteLine($"${overtime.CalculatePay().ToString("#.00")}");

OverTime overtime2 = new OverTime(new double[] { 16, 18, 30, 1.8 }); //Expected output $54.00
Console.WriteLine($"${overtime2.CalculatePay().ToString("#.00")}");

OverTime overtime3 = new OverTime(new double[] { 13.25, 15, 30, 1.5 });
Console.WriteLine($"${overtime3.CalculatePay().ToString("#.00")}"); //Expected output $52.50
