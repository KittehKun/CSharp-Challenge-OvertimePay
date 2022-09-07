using System;
namespace CSharp_Challenge_OvertimePay.classes
{
    public class OverTime
    {
        private double[] workingDay; //Format for array goes [Start of Day (Decimal), End of Day (Decimal), Hourly Rate, Overtime Multiplier] | Time in 24hr Format

        public OverTime(double[] workingDay)
        {
            this.workingDay = workingDay;
        }
    }
}

