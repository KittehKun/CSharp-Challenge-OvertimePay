using System;
namespace CSharp_Challenge_OvertimePay.classes
{
    public class OverTime
    {
        // - Fields -
        private double[] workingDay; //Format for array goes [Start of Day (Decimal), End of Day (Decimal), Hourly Rate, Overtime Multiplier] | Time in 24hr Format
        private double startDay, endDay, hourlyRate, overtimeMultiplier;

        // - Constructor -
        public OverTime(double[] workingDay)
        {
            this.workingDay = workingDay;
            this.startDay = workingDay[0];
            this.endDay = workingDay[1];
            this.hourlyRate = workingDay[2];
            this.overtimeMultiplier = workingDay[3];
        }


        public double CalculatePay()
        {
            double hoursWorked = this.endDay - this.startDay; //Takes difference of hours to see how many hours employee worked
            double overtimeHours = 0, regularHours = 0;

            //Checks if employee worked after 5PM | Calculates hours of overtime
            if (this.endDay > 17) 
            {
                overtimeHours = this.endDay - 17;
            }

            //Checks for 9AM - 5PM | Regular hours
            if (this.startDay >= 9) 
            {
                regularHours = 17 - this.startDay;
            } else
            {
                Console.WriteLine("WARNING: Employee started before 9AM.");
            }

            return (regularHours * this.hourlyRate) + (overtimeHours * this.hourlyRate * this.overtimeMultiplier);
        }
    }
}

